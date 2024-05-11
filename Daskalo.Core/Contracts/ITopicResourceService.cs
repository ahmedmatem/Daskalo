
using Daskalo.Core.Models.Common;
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

        /// <summary>
        /// Retrieve topic resource entity by its id.
        /// </summary>
        /// <param name="id">Unique resource id.</param>
        Task<TopicResource?> GetByIdAsync(string id);

        Task<IEnumerable<TopicResource>> GetAllByIdsAsync(params string[] ids);

        /// <summary>
        /// Update topic resource.
        /// </summary>
        /// <param name="model">The topic resource will be updated.</param>
        Task UpdateAsync(TopicResource model);

        /// <summary>
        /// Extract text and value pair for topic resource select list. 
        /// </summary>
        /// <param name="ownerId">Owner unique identifier.</param>
        /// <returns>Returns list of select list item.</returns>
        Task<IEnumerable<SelectListItemServiceModel>> SelectListAsync(string ownerId);
    }
}
