
using Daskalo.Core.Contracts;
using Daskalo.Infrastructure.Data.DataRepository;
using Daskalo.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Daskalo.Core.Services
{
    public class TopicResourceService : ITopicResourceService
    {
        private readonly IRepository repository;
        private readonly ITopicResourceStorageService storageService;

        public TopicResourceService(
            IRepository _reposoitory,
            ITopicResourceStorageService _storageService)
        {
            repository = _reposoitory;
            storageService = _storageService;

        }

        /// <summary>
        /// Add topic resource in database and upload resource file in azure storage.
        /// </summary>
        /// <param name="topicResource">Topic resource service topicResource.</param>
        /// <param name="file">Topic resource file.</param>
        public async Task AddAsync(TopicResource topicResource, IFormFile? file)
        {
            if (file != null)
            {
                var blobName = GetRandomBlobName(file);
                topicResource.Link = storageService.ContainerUrl + "/" + blobName;

                await storageService.UploadFileAsync(file, blobName);
            }

            await repository.AddAsync(topicResource);
            await repository.SaveChangesAsync<TopicResource>();
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

        private string GetRandomBlobName(IFormFile file)
        {
            return Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
        }
    }
}
