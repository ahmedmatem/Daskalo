using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Daskalo.Infrastructure.Data.Models;

namespace Daskalo.Web.Areas.Teacher.Models.Topic
{
    public class TopicViewModel
    {
        /// <summary>
        /// Topic unique identifier. 
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Unique identifier of creator of the topic. 
        /// </summary>
        public string CreatorId { get; set; } = string.Empty;

        /// <summary>
        /// Topic name.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Topic description.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Topic contents - each item is separated in a new line.
        /// </summary>
        [Display(Name = "Съдържание")]
        public string Contents { get; set; } = string.Empty;

        /// <summary>
        /// The list of all resources belonging to the topic.
        /// </summary>
        [Display(Name = "Ресурси")]
        public IList<TopicResource> Resources { get; set; } = new List<TopicResource>();
    }
}
