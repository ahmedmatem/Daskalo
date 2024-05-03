using Microsoft.AspNetCore.Mvc.Rendering;

namespace Daskalo.Core.Contracts
{
    public interface ITeacherService
    {
        Task<int> GetTeachersCountAsync();

        Task<IEnumerable<KeyValuePair<string, string>>> TeachersInSchoolSelectList(string schoolId);
    }
}
