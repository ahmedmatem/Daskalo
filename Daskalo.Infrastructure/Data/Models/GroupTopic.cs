
namespace Daskalo.Infrastructure.Data.Models
{
    public class GroupTopic
    {
        public string GroupId { get; set; } = string.Empty;

        public string TopicId { get; set; } = string.Empty;

        public Group Group { get; set; } = null!;

        public Topic Topic { get; set; } = null!;
    }
}
