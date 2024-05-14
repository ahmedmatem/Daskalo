using AutoMapper;
using Daskalo.Core.Contracts;
using Daskalo.Infrastructure.Data.Models;
using Daskalo.Web.Areas.Teacher.Models.Topic;
using Daskalo.Web.Extensions;
using Microsoft.AspNetCore.Mvc;
using NuGet.Packaging;
using static Daskalo.Core.Constants.ToastMessageConstants;

namespace Daskalo.Web.Areas.Teacher.Controllers
{
    public class TopicsController : BaseTeacherController
    {
        private readonly IMapper mapper;
        private readonly ITopicService topicService;
        private readonly ITopicResourceService topicResourceService;

        public TopicsController(
            IMapper _mapper,
            ITopicService _topicService,
            ITopicResourceService _topicResourceService)
        {
            mapper = _mapper;
            topicService = _topicService;
            topicResourceService = _topicResourceService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await topicService.AllAsync(User.Id()!);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            TopicFormViewModel model = new TopicFormViewModel();
            ViewData["TopicResourceSelectList"] = 
                await topicResourceService.SelectListAsync(User.Id()!);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(TopicFormViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            var topic = mapper.Map<Topic>(model);
            topic.CreatorId = User.Id()!;

            await topicService.AddAsync(topic);
            await topicService.AddTopicAndResourcesAsync(
                topic.Id,
                model.SelectedResources.ToArray());

            TempData[MessageSuccess] = "Темата е добавена успешно.";

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var topic = await topicService.GetByIdAsync(id);
            if(topic == null || topic.CreatorId != User.Id())
            {
                return NotFound();
            }

            ViewData["CreatorAllTopicResorces"] =
                await topicResourceService.SelectListAsync(User.Id()!);
            var model = mapper.Map<TopicFormViewModel>(topic);

            return View(model);
        }
    }
}
