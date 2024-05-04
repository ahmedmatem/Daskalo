using Daskalo.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using static Daskalo.Infrastructure.Data.Constants.ErrorMessages;

namespace Daskalo.Web.Areas.Admin.ViewModels
{
    public class AddSchoolAdminFormViewModel
    {
        public School School { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Display(Name = "Администратор")]
        public string TeacherId { get; set; } = string.Empty;

        public IEnumerable<SelectListItem> TeachersInSchool { get; set; } = null!;
    }
}
