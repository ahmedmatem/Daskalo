using Daskalo.Core.Contracts;
using Daskalo.Infrastructure.Data.DataRepository;
using Daskalo.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Daskalo.Core.Services
{
    public class TopicService : ITopicService
    {
        private readonly IRepository repository;

        public TopicService(
            IRepository _repository)
        {
            repository = _repository;
        }

        public async Task AddAsync(Topic topic)
        {
            await repository.AddAsync(topic);
            await repository.SaveChangesAsync<Topic>();
        }

        public async Task AddTopicAndResourcesAsync(string topicId, params string[] topicResourceIds)
        {
            foreach (var topicResourceId in topicResourceIds)
            {
                await repository.AddAsync(new TopicAndResource
                {
                    TopicId = topicId,
                    TopicResurceId = topicResourceId
                });
            }
            await repository.SaveChangesAsync<TopicAndResource>();
        }

        public async Task<IEnumerable<Topic>> AllAsync(string creatorId)
        {
            return await repository
                .AllReadonly<Topic>(t => t.CreatorId == creatorId)
                .ToListAsync();
        }

        public async Task<bool> DeleteTopicResourceFromTopicAsync(string topicId, string topicResourceId)
        {
            var resource = await repository
                .GetByIdAsync<TopicAndResource>(new[]
                {
                    topicId, topicResourceId
                });
            if (resource != null)
            {
                repository.Delete(resource);
                await repository.SaveChangesAsync<TopicAndResource>();
                return true;
            }

            return false;
        }

        public async Task<Topic?> GetByIdAsync(string id)
        {
            return await repository
                .AllReadonly<Topic>(t => t.Id == id)
                .Include(t => t.Resources)
                .FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(Topic modifiedTopic)
        {
            repository.Update(modifiedTopic);
            await repository.SaveChangesAsync<Topic>();
        }
    }
}
