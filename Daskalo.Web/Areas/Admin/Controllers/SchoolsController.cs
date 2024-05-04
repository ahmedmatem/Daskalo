using Daskalo.Core.Contracts;
using Daskalo.Web.Areas.Admin.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using static Daskalo.Core.Constants.ToastMessageConstants;

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
                School = school,
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
            var schoolAdminAdded = await schoolService
                .TryAddSchoolAdminAsync(model.School.Id, model.TeacherId);

            if(schoolAdminAdded)
            {
                TempData[MessageSuccess] = "Администраторът бе добавен успешно.";
            }
            else
            {
                TempData[MessageError] = "Грешка при добавянето на администратор";
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
