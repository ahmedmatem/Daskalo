using Daskalo.Core.Models.School;
using Daskalo.Infrastructure.Data.Models;

namespace Daskalo.Core.Contracts
{
    public interface ISchoolService
    {
        Task<int> GetSchoolsCountAsync();

        Task<IEnumerable<SchoolServiceModel>> AllSchoolsAsync();

        Task<School?> GetByIdAsync(string id);

        Task<bool> TryAddSchoolAdminAsync(string schoolId, string teacherId);
    }
}
