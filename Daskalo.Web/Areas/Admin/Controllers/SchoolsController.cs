using Daskalo.Core.Contracts;
using Daskalo.Web.Areas.Admin.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Daskalo.Web.Areas.Admin.Controllers
{
    public class SchoolsController : BaseAdminController
    {
        private readonly ISchoolService schoolService;
        private readonly ITeacherService teacherService;

        public SchoolsController(
            ISchoolService _schoolService,
            ITeacherService _teacherService)
        {
            schoolService = _schoolService;
            teacherService = _teacherService;

        }

        public async Task<IActionResult> Index()
        {
            var model = await schoolService.AllSchoolsAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AddSchoolAdmin(string id)
        {
            var school = await schoolService.GetByIdAsync(id);
            if (school == null)
            {
                return BadRequest();
            }

            var model = new AddSchoolAdminFormViewModel
            {
                Scholl = school,
                TeachersInSchool = (await teacherService.TeachersInSchoolSelectList(id))
                .Select(x => new SelectListItem()
                {
                    Text = x.Key,
                    Value = x.Value
                })
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddSchoolAdmin(AddSchoolAdminFormViewModel model)
        {
            string schoolId = model.Scholl.Id;
            string teacherId = model.TeacherId;

            await schoolService.TryAddSchoolAdminAsync(schoolId, teacherId);

            return RedirectToAction(nameof(Index));
        }
    }
}
