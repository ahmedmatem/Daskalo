using Daskalo.Core.Contracts;
using Daskalo.Web.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NuGet.DependencyResolver;

namespace Daskalo.Web.Areas.SchoolAdmin.Controllers
{
    public class HomeController : BaseSchoolAdminController
    {
        private readonly ISchoolService schoolService;
        private readonly ITeacherService teacherService;

        public HomeController(
            ISchoolService _schoolService,
            ITeacherService _teacherService)
        {
            schoolService = _schoolService;
            teacherService = _teacherService;
        }

        public async Task<IActionResult> Index()
        {
            var teacherId = User.Id();
            var schoolId = User.SchoolId();

            if(teacherId == null || schoolId == null)
            {
                return BadRequest();
            }

            var model = await schoolService.GetByIdAsync(schoolId);
            return View(model);
        }
    }
}
