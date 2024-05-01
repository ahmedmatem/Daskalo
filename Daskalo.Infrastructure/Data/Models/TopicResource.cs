using Daskalo.Infrastructure.Data.Contracts;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static Daskalo.Infrastructure.Data.Constants.DataConstants;

namespace Daskalo.Infrastructure.Data.Models
{
    /// <summary>
    /// The model of the resource that can be attached to a topic.
    /// </summary>
    public class TopicResource : DataModel
    {
        /// <summary>
        /// Unique identifier of an owner(a teacher) of the topic resource.
        /// </summary>
        [Required]
        [Comment("Unique identifier of the creator of the resource.")]
        public string OwnerId { get; set; } = string.Empty;

        /// <summary>
        /// Link to the resource.
        /// </summary>
        [Required]
        [Comment("Link to the resource.")]
        public string Link { get; set; } = string.Empty;

        /// <summary>
        /// User friendly text to display.
        /// </summary>
        [Required]
        [MaxLength(ResourceTextToDisplayMaxLength)]
        [Comment("Resource text to display.")]
        public string TextToDisplay { get; set; } = string.Empty;

        /// <summary>
        /// Icon relevant to the specific resource type: video, image or some file types.
        /// </summary>
        [Required]
        [Comment("Resource specific icon.")]
        public string Icon { get; set; } = string.Empty;

        /**
         * Navigation properties.
         **/

        /// <summary>
        /// The owner of the topic resource.
        /// </summary>
        public ApplicationUser Owner { get; set; } = null!;

        /// <summary>
        /// The list of all topics which the resource attached on.
        /// </summary>
        public IList<Topic> Topics { get; set; } = new List<Topic>();
    }
}
