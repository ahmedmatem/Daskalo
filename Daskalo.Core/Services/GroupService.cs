
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

        public async Task<int> GetGroupsCountAsync()
        {
            return await repository.AllReadonly<Group>()
                .Where(g => !g.IsDeleted)
                .CountAsync();
        }
    }
}
