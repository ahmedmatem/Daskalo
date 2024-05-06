
using Daskalo.Infrastructure.Data.Models;

namespace Daskalo.Core.Contracts
{
    public interface IGroupService
    {
        /// <summary>
        /// Gets the count of all groups in all schools.
        /// </summary>
        Task<int> GetGroupsCountAsync();

        /// <summary>
        /// Gets all counts of all groups in given school.
        /// </summary>
        /// <param name="schoolid">The schooll unique identifier.</param>
        Task<int> GetGroupsCountInSchoolAsync(string schoolid);

        /// <summary>
        /// Gets all groups in the school.
        /// </summary>
        /// <param name="schoolId">School unique identifier.</param>
        /// <returns>Returns list of all groups in the school excluding deleted ones.</returns>
        Task<IEnumerable<Group>> AllAsync(string schoolId);
    }
}
