using Daskalo.Core.Contracts;
using Daskalo.Web.Areas.Teacher.Models.Resource;
using Daskalo.Web.Extensions;
using Microsoft.AspNetCore.Mvc;
using static Daskalo.Web.Constants.ResourceConstants;
using static Daskalo.Core.Constants.ToastMessageConstants;
using AutoMapper;
using Daskalo.Infrastructure.Data.Models;
using Elfie.Serialization;

namespace Daskalo.Web.Areas.Teacher.Controllers
{
    public class ResourcesController : BaseTeacherController
    {
        private readonly IMapper mapper;
        private readonly ITopicResourceService resourceService;
        private readonly ITopicResourceStorageService storageService;

        public ResourcesController(
            IMapper _mapper,
            ITopicResourceService _resourceService,
            ITopicResourceStorageService _storageService)
        {
            mapper = _mapper;
            resourceService = _resourceService;
            storageService = _storageService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await resourceService.AllByOwnerAsync(User.Id()!);

            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(ResourceFormViewModel model)
        {
            if (model.OwnerId != User.Id()
                || ResourceIconRefs.Keys.Contains(model.Icon) == false)
            {
                return BadRequest();
            }

            var topicResource = mapper.Map<TopicResource>(model);
            await resourceService.AddAsync(topicResource, model.ResourceFile);

            TempData[MessageSuccess] = "Ресурсът е добавен успешно.";

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var topicResource = await resourceService.GetByIdAsync(id);
            if(topicResource == null || topicResource.OwnerId != User.Id())
            {
                return BadRequest();
            }

            var model = mapper.Map<ResourceFormViewModel>(topicResource);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TopicResource model)
        {
            var topicResource = await resourceService.GetByIdAsync(model.Id);
            if (topicResource == null 
                || model.OwnerId != User.Id()
                || ResourceIconRefs.Keys.Contains(model.Icon) == false)
            {
                return BadRequest();
            }

            topicResource.TextToDisplay = model.TextToDisplay;
            if (topicResource.Link.Contains(storageService.ContainerUrl) == false)
            {
                // Link is not a blob.
                topicResource.Link = model.Link;
            }
            topicResource.Icon = model.Icon;

            await resourceService.UpdateAsync(topicResource);

            TempData[MessageSuccess] = "Ресурсът е променен успешно.";

            return RedirectToAction(nameof(Index));
        }
    }
}
