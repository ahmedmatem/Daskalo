using Daskalo.Core.Contracts;
using Daskalo.Core.Models.Common;
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

        public async Task<IEnumerable<Topic>> AllAsync(string creatorId)
        {
            return await repository
                .AllReadonly<Topic>(t => t.CreatorId == creatorId)
                .ToListAsync();
        }
    }
}
