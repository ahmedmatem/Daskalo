using Daskalo.Core.Contracts;
using Daskalo.Infrastructure.Data.DataRepository;
using Daskalo.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Daskalo.Core.Services
{
    public class SchoolService : ISchoolService
    {
        private readonly IRepository repository;

        public SchoolService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<int> GetSchoolsCountAsync()
        {
            return await repository.AllReadonly<School>()
                .Where(s => !s.IsDeleted)
                .CountAsync();
        }
    }
}
