
using Daskalo.Core.Contracts;
using Daskalo.Infrastructure.Data.DataRepository;
using Daskalo.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Daskalo.Core.Services
{
    public class TopicResourceService : ITopicResourceService
    {
        private readonly IRepository repository;

        public TopicResourceService(IRepository _reposoitory)
        {
            repository = _reposoitory;
        }

        /// <summary>
        /// Retrieve all resources belong to an owner.
        /// </summary>
        /// <param name="ownerId">Owner unique identifier which the resources belong to in.</param>
        public async Task<IEnumerable<TopicResource>> AllByOwnerAsync(string ownerId)
        {
            return await repository.AllReadonly<TopicResource>()
                .Where(r => r.OwnerId == ownerId)
                .ToListAsync();
        }
    }
}
