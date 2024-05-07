﻿using Daskalo.Core.Contracts;
using Daskalo.Infrastructure.Data.DataRepository;
using Daskalo.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Security.Claims;
using static Daskalo.Core.Constants.UserClaimsConstants;

namespace Daskalo.Core.Services
{
    public class SchoolService : ISchoolService
    {
        private readonly ILogger<SchoolService> logger;
        private readonly IRepository repository;
        private readonly UserManager<ApplicationUser> userManager;

        public SchoolService(
            ILogger<SchoolService> _logger,
            IRepository _repository,
            UserManager<ApplicationUser> _userManager)
        {
            repository = _repository;
            userManager = _userManager;
            logger = _logger;
        }

        /// <summary>
        /// Add scholl in datasource.
        /// </summary>
        /// <param name="school">The school which will be added.</param>
        public async Task AddAsync(School school)
        {
            await repository.AddAsync(school);
            await repository.SaveChangesAsync<School>();
        }

        /// <summary>
        /// Requests all schools from datasource.
        /// </summary>
        /// <returns>Returns all schools excluding deleted ones.</returns>
        public async Task<IEnumerable<School>> AllAsync()
        {
            return await repository
                .AllReadonly<School>()
                .Include(s => s.SchoolAdmin)
                .ToListAsync();
        }

        /// <summary>
        /// Requests all deleted schools from datasource.
        /// </summary>
        /// <returns>Returns all deleted schools.</returns>
        public async Task<IEnumerable<School>> AllBlockedAsync()
        {
            return await repository
                .AllDeletedReadonly<School>()
                .Include(s => s.SchoolAdmin)
                .ToListAsync();
        }

        /// <summary>
        /// Requests the number of all blocked schools.
        /// </summary>
        /// <returns>Returns the number of all blocked(deleted) schools.</returns>
        public async Task<int> GetBlockedSchoolsCountAsync()
        {
            return await repository
                .AllDeletedReadonly<School>()
                .CountAsync();
        }

        /// <summary>
        /// Gets the school by id.
        /// </summary>
        /// <param name="schoolId">School unique identifier.</param>
        /// <returns>Return School Entity or null if not found.</returns>
        public async Task<School?> GetByIdAsync(string id)
        {
            return await repository.GetByIdAsync<School>(id);
        }

        /// <summary>
        /// Requests the number of all registered schools.
        /// </summary>
        /// <returns>Returns the number of all school excluding deleted ones.</returns>
        public async Task<int> GetSchoolsCountAsync()
        {
            return await repository
                .AllReadonly<School>()
                .CountAsync();
        }

        /// <summary>
        /// Adds administrator to the school. 
        /// Using custom user claims sssigns School identifier and add
        /// user activated claim.
        /// </summary>
        /// <param name="schoolId">School unique identifier which the teacher becomes administrator on.</param>
        /// <param name="teacherId">Unique identifier of the teacher who will become administrator.</param>
        /// <returns></returns>
        public async Task<bool> TryAddSchoolAdminAsync(string schoolId, string teacherId)
        {
            var school = await repository.GetByIdAsync<School>(schoolId);
            var teacher = await userManager.FindByIdAsync(teacherId);

            if (school != null && teacher != null && school.SchoolAdmin == null)
            {
                // Add teacher in SchoolAdmin role.
                var result = await userManager.AddToRoleAsync(teacher, "SchoolAdmin");
                if (result.Succeeded)
                {
                    // Add school id in user claims.
                    await userManager.AddClaimAsync(
                        teacher, 
                        new Claim(SchoolIdentifierClaim, teacher.SchoolId));

                    // Update school with SchoolAdmin teacher.
                    school.SchoolAdmin = teacher;
                    await repository.SaveChangesAsync<School>();
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Update scholl.
        /// </summary>
        /// <param name="school">Tracked entity with updated properties.</param>
        public async Task UpdateAsync(School school)
        {
            repository.Update(school);
            await repository.SaveChangesAsync<School>();
        }
    }
}
