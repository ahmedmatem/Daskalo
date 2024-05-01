
namespace Daskalo.Infrastructure.Data.Models
{
    public class TopicAndResource
    {
        public string TopicId { get; set; } = string.Empty;

        public string TopicResurceId { get; set; } = string.Empty;

        public Topic Topic { get; set; } = null!;

        public TopicResource TopicResource { get; set; } = null!;
    }
}
