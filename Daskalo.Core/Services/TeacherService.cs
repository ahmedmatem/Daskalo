
using Daskalo.Core.Contracts;
using Daskalo.Infrastructure.Data.DataRepository;
using Daskalo.Infrastructure.Data.Models;
using Daskalo.Infrastructure.Data.Types;
using Microsoft.EntityFrameworkCore;

namespace Daskalo.Core.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly IRepository repository;

        public TeacherService(IRepository _repository)
        {
            repository = _repository;
        }

        /// <summary>
        /// Gets the teacher by id.
        /// </summary>
        /// <param name="id">User unique identifier.</param>
        /// <returns>Returns Teacher entity or null if not found.</returns>
        public async Task<ApplicationUser?> GetByIdAsync(string id)
        {
            return await repository.GetByIdAsync<ApplicationUser>(id);
        }

        /// <summary>
        /// Gets the count of all teachers in all schools.
        /// </summary>
        public async Task<int> GetTeachersCountAsync()
        {
            return await repository.AllReadonly<ApplicationUser>()
                .Where(u => !u.IsDeleted && u.Role == Role.Teacher)
                .CountAsync();
        }

        /// <summary>
        /// Gets the count of all teachers in the school.
        /// </summary>
        /// <param name="schoolId">The school unique identifier.</param>
        public async Task<int> GetTeachersCountInSchoolAsync(string schoolId)
        {
            return await repository.AllReadonly<ApplicationUser>()
               .Where(u =>
                    u.SchoolId == schoolId 
                    && !u.IsDeleted 
                    && u.Role == Role.Teacher)
               .CountAsync();
        }

        /// <summary>
        /// Gets all teachers in he school suitable for select view.
        /// </summary>
        /// <param name="schoolId">The school unique identifier</param>
        public async Task<IEnumerable<KeyValuePair<string, string>>> TeachersInSchoolSelectList(string schoolId)
        {
            return await repository.AllReadonly<ApplicationUser>()
                .Where(u => u.SchoolId == schoolId && u.Role == Role.Teacher && !u.IsDeleted)
                .Select(t => new KeyValuePair<string, string>(t.FullName, t.Id))
                .ToListAsync();
        }
    }
}
