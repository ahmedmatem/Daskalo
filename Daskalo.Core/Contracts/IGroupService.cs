
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
    }
}
