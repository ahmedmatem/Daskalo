using AutoMapper;
using Daskalo.Core.Contracts;
using Daskalo.Infrastructure.Data.Models;
using Daskalo.Web.Areas.Admin.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using static Daskalo.Core.Constants.ToastMessageConstants;

namespace Daskalo.Web.Areas.Admin.Controllers
{
    public class SchoolsController : BaseAdminController
    {
        private readonly IMapper mapper;
        private readonly ISchoolService schoolService;
        private readonly ITeacherService teacherService;

        public SchoolsController(
            IMapper _mapper,
            ISchoolService _schoolService,
            ITeacherService _teacherService)
        {
            mapper = _mapper;
            schoolService = _schoolService;
            teacherService = _teacherService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await schoolService.AllAsync();

            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(SchoolFormViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            var school = mapper.Map<School>(model);

            await schoolService.AddAsync(school);

            TempData[MessageSuccess] = "Училището бе добавено успешно.";

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var school = await schoolService.GetByIdAsync(id);
            if(school == null)
            {
                return BadRequest();
            }

            var model = mapper.Map<SchoolFormViewModel>(school);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SchoolFormViewModel model)
        {
            var school = await schoolService.GetByIdAsync(model.Id);
            
            if(school == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            mapper.Map(model, school);
            await schoolService.UpdateAsync(school);

            TempData[MessageSuccess] = "Училището бе променено успешно.";

            return RedirectToAction(nameof(Index));
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
