
using Daskalo.Core.Contracts;
using Daskalo.Infrastructure.Data.DataRepository;
using Daskalo.Infrastructure.Data.Models;
using Daskalo.Infrastructure.Data.Types;
using Microsoft.EntityFrameworkCore;

namespace Daskalo.Core.Services
{
    public class StudentService : IStudentService
    {
        private readonly IRepository repository;

        public StudentService(IRepository _repository)
        {
            repository = _repository;
        }

        /// <summary>
        /// Gets all students count excluding ones marked as deleted.
        /// </summary>
        public async Task<int> GetStudentsCountAsync()
        {
            return await repository
                .AllReadonly<ApplicationUser>()
                .Where(u => u.Role == Role.Student)
                .CountAsync();
        }

        /// <summary>
        /// Gets all students in school excluding ones marked as deleted.
        /// </summary>
        /// <param name="schoolId">School unique identifier.</param>
        public async Task<int> GetStudentsCountInSchoolAsync(string schoolId)
        {
            return await repository
                .AllReadonly<ApplicationUser>()
                .Where(u => u.SchoolId == schoolId && u.Role == Role.Student)
                .CountAsync();
        }
    }
}
