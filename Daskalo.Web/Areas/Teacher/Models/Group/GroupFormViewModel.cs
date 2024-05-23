using System.ComponentModel.DataAnnotations;
using static Daskalo.Infrastructure.Data.Constants.DataConstants;
using static Daskalo.Infrastructure.Data.Constants.ErrorMessages;

namespace Daskalo.Web.Areas.Teacher.Models.Group
{
    public class GroupFormViewModel
    {
        /// <summary>
        /// Unique group identifier.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Name of the group.
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(
            GroupNameMaxLength,
            MinimumLength = GroupNameMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        [Display(Name = "Име")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Short name of the group.
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(
            GroupShortNameMaxLength,
            MinimumLength = GroupShortNameMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        [Display(Name = "Кратко име")]
        public string ShortName { get; set; } = string.Empty;

        /// <summary>
        /// Group short description.
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [MaxLength(GroupDescriptionMaxLength, ErrorMessage = MaxLengthErrorMessage)]
        [Display(Name = "Кратко описание")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Path reference to group icon.
        /// </summary>
        [Display(Name = "Картинка")]
        public string Image { get; set; } = string.Empty;

        public string SchoolId { get; set; } = string.Empty;

        public string TeacherId { get; set; } = string.Empty;
    }
}
