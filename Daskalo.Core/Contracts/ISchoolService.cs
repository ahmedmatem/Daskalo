using Daskalo.Infrastructure.Data.Models;

namespace Daskalo.Core.Contracts
{
    public interface ISchoolService
    {
        Task<int> GetSchoolsCountAsync();

        Task<IEnumerable<School>> AllAsync();

        Task<School?> GetByIdAsync(string id);

        Task<bool> TryAddSchoolAdminAsync(string schoolId, string teacherId);

        Task AddAsync(School school);

        Task UpdateAsync(School school);
    }
}
