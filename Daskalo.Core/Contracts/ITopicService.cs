
using Daskalo.Infrastructure.Data.Models;

namespace Daskalo.Core.Contracts
{
    public interface ITopicService
    {
        Task<Topic?> GetByIdAsync(string id);

        Task<IEnumerable<Topic>> AllAsync(string creatorId);

        Task AddAsync(Topic topic);

        Task AddTopicAndResourcesAsync(string topicId, params string[] topicResourceIds);
    }
}
