
using Daskalo.Core.Models.Common;
using Daskalo.Infrastructure.Data.Models;

namespace Daskalo.Core.Contracts
{
    public interface ITopicService
    {
        Task<IEnumerable<Topic>> AllAsync(string creatorId);
    }
}
