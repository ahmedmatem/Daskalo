using Daskalo.Infrastructure.Data.Contracts;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static Daskalo.Infrastructure.Data.Constants.DataConstants;

namespace Daskalo.Infrastructure.Data.Models
{
    /// <summary>
    /// The model of Topic.
    /// </summary>
    public class Topic : DataModel
    {
        /// <summary>
        /// Unique identifier of creator of the topic. 
        /// </summary>
        [Required]
        [Comment("Unique identifier of the creator of the topic.")]
        [ForeignKey("Creator")]
        public string CreatorId { get; set; } = string.Empty;

        /// <summary>
        /// Topic name.
        /// </summary>
        [Required]
        [MaxLength(TopicNameMaxLength)]
        [Comment("Topic name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Topic description.
        /// </summary>
        [MaxLength(TopicDescriptionMaxLength)]
        [Comment("Topic description.")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Topic contents - each item is separated in a new line.
        /// </summary>
        [Comment("Topic contents items separated each in a new line.")]
        public string Contents { get; set; } = string.Empty;

        /**
         * Navigation properties
         **/

        /// <summary>
        /// The list of all groups the topic participate in.
        /// </summary>
        public ApplicationUser Creator { get; set; } = null!;

        /// <summary>
        /// The list of all groups the topic participate in.
        /// </summary>
        public IList<Group> Groups { get; set; } = new List<Group>();

        /// <summary>
        /// The list of all resources belonging to the topic.
        /// </summary>
        public IList<TopicResource> Resources { get; set; } = new List<TopicResource>();
    }
}
