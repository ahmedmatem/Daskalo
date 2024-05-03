
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

        public async Task<int> GetStudentsCountAsync()
        {
            return await repository.AllReadonly<ApplicationUser>()
                .Where(u => !u.IsDeleted && u.Role == Role.Student)
                .CountAsync();
        }
    }
}
