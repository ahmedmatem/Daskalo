
namespace Daskalo.Infrastructure.Data.Models
{
    public class GroupMember
    {
        public string GroupId { get; set; } = string.Empty;

        public string MemberId { get; set; } = string.Empty;

        public Group Group { get; set; } = null!;

        public ApplicationUser Member { get; set; } = null!;
    }
}
