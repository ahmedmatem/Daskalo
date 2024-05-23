using AutoMapper;
using Daskalo.Core.Contracts;
using Daskalo.Infrastructure.Data.Models;
using Daskalo.Web.Areas.Teacher.Models.Group;
using Daskalo.Web.Extensions;
using Microsoft.AspNetCore.Mvc;
using static Daskalo.Infrastructure.Data.Constants.DataConstants;
using static Daskalo.Infrastructure.Data.Constants.ErrorMessages;
using static Daskalo.Core.Constants.ToastMessageConstants;
using Daskalo.Infrastructure.Data.Constants;

#nullable disable

namespace Daskalo.Web.Areas.Teacher.Controllers
{
    public class GroupsController : BaseTeacherController
    {
        private readonly IMapper mapper;
        private readonly IGroupService groupService;
        private readonly IAzureStorageService storageService;

        public GroupsController(
            IMapper _mapper,
            IGroupService _groupService,
            IAzureStorageService _storageService)
        {
            mapper = _mapper;
            groupService = _groupService;
            storageService = _storageService;

        }

        public async Task<IActionResult> Index()
        {
            var teacherGroups = await groupService.AllByCreatorAsync(User.Id());
            var model = mapper.Map<IEnumerable<GroupCardViewModel>>(teacherGroups);

            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(
            GroupFormViewModel model,
            IFormFile postedFile)
        {
            if (postedFile == null)
            {
                ModelState.AddModelError("Image", string.Format(RequiredErrorMessage, ""));
            }
            else if (postedFile.Length > 0)
            {
                if(!postedFile.IsImage())
                {
                    ModelState.AddModelError("Image",
                        string.Format(FileITypeErrorMessage, postedFile.FileName));
                }
                if (postedFile.FileSizeValid(PostedFileMaxSizeInBytes) == false)
                {
                    ModelState.AddModelError("Image",
                        string.Format(FileISizeErrorMessage, PostedFileMaxSizeInBytes / 1024));
                }
            }
            else
            {
                ModelState.AddModelError("Image", FileISizeZeroErrorMessage);
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            string blobName = postedFile.RandomName();
            model.TeacherId = User.Id();
            model.SchoolId = User.SchoolId();
            model.Image = storageService.BlobContainerURL + blobName;

            var newGroup = mapper.Map<Group>(model);

            var addSucceeded = await groupService.AddAsync(newGroup);
            if(addSucceeded)
            {
                
                await storageService.UploadFileAsync(postedFile, blobName);
                
                TempData[MessageSuccess] = "Групата е създадена успешно.";
            }
            else
            {
                TempData[MessageError] = "Възникна грешка при създаване на групата.";
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
