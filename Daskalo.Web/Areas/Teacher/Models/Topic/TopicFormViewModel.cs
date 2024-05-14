using Daskalo.Infrastructure.Data.Models;
using System.ComponentModel.DataAnnotations;
using static Daskalo.Infrastructure.Data.Constants.DataConstants;
using static Daskalo.Infrastructure.Data.Constants.ErrorMessages;

namespace Daskalo.Web.Areas.Teacher.Models.Topic
{
    public class TopicFormViewModel
    {
        /// <summary>
        /// Topic unique identifier
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Topic name
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(
            TopicNameMaxLength,
            MinimumLength = TopicNameMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        [Display(Name = "Име")]
        public string Name { get; set; } = string.Empty;

        [MaxLength(TopicDescriptionMaxLength, ErrorMessage = MaxLengthErrorMessage)]
        [Display(Name = "Описание")]
        public string? Description { get; set; }

        /// <summary>
        /// Topic contents items separated each in a new line.
        /// </summary>
        [Display(Name = "Съдържание")]
        public string Contents { get; set; } = string.Empty;

        public string CreatorId { get; set; } = string.Empty;

        /// <summary>
        /// Collection of topic resources.
        /// </summary>
        [Display(Name = "Ресурси")]
        public IEnumerable<TopicResource> Resources { get; set; } = new List<TopicResource>();

        /// <summary>
        /// Keeps selected resources for topic create by a teacher.
        /// </summary>
        [Display(Name = "Ресурси")]
        public IEnumerable<string> SelectedResources { get; set; } = new List<string>();
    }
}
