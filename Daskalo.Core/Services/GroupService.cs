
using Daskalo.Core.Contracts;
using Daskalo.Infrastructure.Data.DataRepository;
using Daskalo.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Daskalo.Core.Services
{
    public class GroupService : IGroupService
    {
        private readonly IRepository repository;

        public GroupService(IRepository _repository)
        {
            repository = _repository;
        }

        /// <summary>
        /// Gets all groups in the school excluding marled as deleted.
        /// </summary>
        /// <param name="schoolId">School unique identifier.</param>
        /// <returns>Returns list of all groups in the school excluding deleted ones.</returns>
        public async Task<IEnumerable<Group>> AllAsync(string schoolId)
        {
            return await repository
                .AllReadonly<Group>()
                .ToListAsync();
        }

        /// <summary>
        /// Gets the count of all groups in all schools,
        /// excluding ones marked as deleted.
        /// </summary>
        public async Task<int> GetGroupsCountAsync()
        {
            return await repository
                .AllReadonly<Group>()
                .CountAsync();
        }

        /// <summary>
        /// Gets all counts of all groups in given school,
        /// excluding ones marked as deleted.
        /// </summary>
        /// <param name="schoolid">The schooll unique identifier.</param>
        public async Task<int> GetGroupsCountInSchoolAsync(string schoolid)
        {
            return await repository
                .AllReadonly<Group>()
                .Where(g => g.SchoolId == schoolid)
                .CountAsync();
        }
    }
}
