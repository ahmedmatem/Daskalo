
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

        public async Task<int> GetTeachersCountAsync()
        {
            return await repository.AllReadonly<ApplicationUser>()
                .Where(u => !u.IsDeleted && u.Role == Role.Teacher)
                .CountAsync();
        }
    }
}
