using Daskalo.Infrastructure.Data.Contracts;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static Daskalo.Infrastructure.Data.Constants.DataConstants;

namespace Daskalo.Infrastructure.Data.Models
{
    /// <summary>
    /// the model of Group.
    /// </summary>
    [Comment("Model of a group in the school.")]
    public class Group : DataModel
    {
        [Required]
        [Comment("Unique school identifier the group belongng to.")]
        public string SchoolId { get; set; } = string.Empty;

        /// <summary>
        /// Unique identifier of the teacher who is the group creator.
        /// </summary>
        [Required]
        [Comment("Group creator unique identifier.")]
        public string TeacherId { get; set; } = string.Empty;

        [Required]
        [MaxLength(GroupNameMaxLength)]
        [Comment("Group name.")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(GroupShortNameMaxLength)]
        [Comment("Group short name.")]
        public string ShortName { get; set; } = string.Empty;

        [MaxLength(GroupDescriptionMaxLength)]
        [Comment("Group description.")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Comment("Group image.")]
        public string Image { get; set; } = string.Empty;

        /**
         * Navigation properties.
         **/

        /// <summary>
        /// School which the group belongs to.
        /// </summary>
        public School School { get; set; } = null!;

        /// <summary>
        /// The creator of the group. Only teachers can create a group.
        /// </summary>
        public ApplicationUser Teacher { get; set; } = null!;

        /// <summary>
        /// The members of the group.
        /// </summary>
        public IList<ApplicationUser> Members { get; set; } = new List<ApplicationUser>();

        /// <summary>
        /// The list of all topics attached to the group.
        /// </summary>
        public IList<Topic> Topics { get; set; } = new List<Topic>();
    }
}
