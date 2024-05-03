using Daskalo.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Daskalo.Web.Areas.Admin.ViewModels
{
    public class AddSchoolAdminFormViewModel
    {
        public School Scholl { get; set; } = null!;

        [Display(Name = "Администратор")]
        public string TeacherId { get; set; } = string.Empty;

        public IEnumerable<SelectListItem> TeachersInSchool { get; set; } = null!;
    }
}
