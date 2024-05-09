
using Daskalo.Infrastructure.Data.Models;

namespace Daskalo.Core.Contracts
{
    public interface ITopicResourceService
    {
        /// <summary>
        /// Retrieve all resources belong to an owner.
        /// </summary>
        /// <param name="ownerId">Owner unique identifier which the resources belong to in.</param>
        Task<IEnumerable<TopicResource>> AllByOwnerAsync(string ownerId);
    }
}
