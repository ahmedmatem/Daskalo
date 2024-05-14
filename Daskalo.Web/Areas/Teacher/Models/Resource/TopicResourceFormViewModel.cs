using System.ComponentModel.DataAnnotations;
using static Daskalo.Infrastructure.Data.Constants.DataConstants;
using static Daskalo.Infrastructure.Data.Constants.ErrorMessages;

namespace Daskalo.Web.Areas.Teacher.Models.Resource
{
    public class TopicResourceFormViewModel
    {
        /// <summary>
        /// Unique identifier of an owner(a teacher) of the topic resource.
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        public string OwnerId { get; set; } = string.Empty;

        /// <summary>
        /// Link to the resource.
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [Display(Name = "Връзка към ресурс")]
        public string Link { get; set; } = string.Empty;

        /// <summary>
        /// User friendly text to display.
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [MaxLength(ResourceTextToDisplayMaxLength)]
        [Display(Name = "Описателно име на линка към ресурса")]
        public string TextToDisplay { get; set; } = string.Empty;

        /// <summary>
        /// Icon relevant to the specific resource type: video, image or some file types.
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [Display(Name = "Иконка")]
        public string Icon { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Display(Name = "Ресурсен файл")]
        public IFormFile? ResourceFile { get; set; }
    }
}
