using Daskalo.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Daskalo.Core.Contracts
{
    public interface ITeacherService
    {
        /// <summary>
        /// Gets the count of all teachers in all schools.
        /// </summary>
        Task<int> GetTeachersCountAsync();

        /// <summary>
        /// Gets the count of all teachers in the school.
        /// </summary>
        /// <param name="schoolId">The school unique identifier.</param>
        Task<int> GetTeachersCountInSchoolAsync(string schoolId);

        /// <summary>
        /// Gets all teachers in he school suitable for select view.
        /// </summary>
        /// <param name="schoolId">The school unique identifier</param>
        Task<IEnumerable<KeyValuePair<string, string>>> TeachersInSchoolSelectList(string schoolId);

        /// <summary>
        /// Gets the teacher by id.
        /// </summary>
        /// <param name="id">User unique identifier.</param>
        /// <returns>Returns Teacher entity or null if not found.</returns>
        Task<ApplicationUser?> GetByIdAsync(string id);
    }
}
