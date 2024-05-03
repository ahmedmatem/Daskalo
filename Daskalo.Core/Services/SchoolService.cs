﻿using Daskalo.Core.Contracts;
using Daskalo.Core.Models.School;
using Daskalo.Infrastructure.Data.DataRepository;
using Daskalo.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Security.Claims;

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

        public async Task<IEnumerable<SchoolServiceModel>> AllSchoolsAsync()
        {
            return await repository.AllReadonly<School>()
                .Where(s => !s.IsDeleted)
                .Include(s => s.SchoolAdmin)
                .Select(s => new SchoolServiceModel
                {
                    Id = s.Id,
                    SchoolAdminId = s.SchoolAdminId,
                    Name = s.Name,
                    Type = s.Type,
                    City = s.City,
                    SchoolAdmin = s.SchoolAdmin,
                })
                .ToListAsync();
        }

        public async Task<School?> GetByIdAsync(string id)
        {
            return await repository.GetByIdAsync<School>(id);
        }

        public async Task<int> GetSchoolsCountAsync()
        {
            return await repository.AllReadonly<School>()
                .Where(s => !s.IsDeleted)
                .CountAsync();
        }

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
                    // Activate teacher by assigning activation claim to it.
                    await userManager.AddClaimAsync(teacher, new Claim("Activated", "Activated"));

                    // Update school with SchoolAdmin teacher.
                    school.SchoolAdmin = teacher;
                    await repository.SaveChangesAsync<School>();
                    return true;
                }
            }

            return false;
        }
    }
}
