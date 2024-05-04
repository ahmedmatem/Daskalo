using Daskalo.Infrastructure.Data.Models;
using System.ComponentModel.DataAnnotations;
using static Daskalo.Infrastructure.Data.Constants.DataConstants;
using static Daskalo.Infrastructure.Data.Constants.ErrorMessages;

namespace Daskalo.Web.Areas.Admin.ViewModels
{
    public class SchoolFormViewModel
    {
        /// <summary>
        /// School unique identifier.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Unique identifier of the school administrator.
        /// NULL means that the school has not administrator yet.
        /// </summary>
        public string? SchoolAdminId { get; set; }

        /// <summary>
        /// School name.
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(
            SchoolNameMaxLength,
            MinimumLength = SchoolNameMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        [Display(Name = "Име", Prompt = "")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// School type.
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(
             SchoolTypeMaxLength,
             MinimumLength = SchoolTypeMinLength,
             ErrorMessage = StringLengthErrorMessage)]
        [Display(Name = "Тип", Prompt = "")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// The name of the city the school belongs to.
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(
            SchoolCityMaxLength,
            MinimumLength = SchoolCityMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        [Display(Name = "Населено място", Prompt = "")]
        public string City { get; set; } = string.Empty;

        /// <summary>
        /// School administrator. It is null if not set yet.
        /// </summary>
        [Display(Name = "Администратор на училище")]
        public ApplicationUser? SchoolAdmin { get; set; }
    }
}
