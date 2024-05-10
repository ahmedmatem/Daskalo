
using Daskalo.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Http;

namespace Daskalo.Core.Contracts
{
    public interface ITopicResourceService
    {
        /// <summary>
        /// Retrieve all resources belong to an owner.
        /// </summary>
        /// <param name="ownerId">Owner unique identifier which the resources belong to in.</param>
        Task<IEnumerable<TopicResource>> AllByOwnerAsync(string ownerId);

        /// <summary>
        /// Add topic resource in database and upload resource file in azure storage.
        /// </summary>
        /// <param name="topicResource">Topic resource service model.</param>
        /// <param name="file">Topic resource file.</param>
        Task AddAsync(TopicResource topicResource, IFormFile? file);
    }
}
