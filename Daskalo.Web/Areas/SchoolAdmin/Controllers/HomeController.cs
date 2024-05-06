using Daskalo.Core.Contracts;
using Daskalo.Web.Extensions;
using Microsoft.AspNetCore.Mvc;

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
            if(User.Id == null || User.SchoolId() == null)
            {
                return BadRequest();
            }

            var model = await schoolService.GetByIdAsync(User.SchoolId()!);
            return View(model);
        }
    }
}
