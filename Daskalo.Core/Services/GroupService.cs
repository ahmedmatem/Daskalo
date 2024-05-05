
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
        /// Gets the count of all groups in all schools.
        /// </summary>
        public async Task<int> GetGroupsCountAsync()
        {
            return await repository.AllReadonly<Group>()
                .Where(g => !g.IsDeleted)
                .CountAsync();
        }

        /// <summary>
        /// Gets all counts of all groups in given school.
        /// </summary>
        /// <param name="schoolid">The schooll unique identifier.</param>
        public async Task<int> GetGroupsCountInSchoolAsync(string schoolid)
        {
            return await repository.AllReadonly<Group>()
                .Where(g => g.SchoolId == schoolid && !g.IsDeleted)
                .CountAsync();
        }
    }
}
