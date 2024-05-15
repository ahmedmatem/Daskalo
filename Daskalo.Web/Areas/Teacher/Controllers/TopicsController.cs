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
            if (!ModelState.IsValid)
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
            if (topic == null || topic.CreatorId != User.Id())
            {
                return NotFound();
            }

            ViewData["CreatorAllTopicResorces"] =
                await topicResourceService.SelectListAsync(User.Id()!);
            var model = mapper.Map<TopicFormViewModel>(topic);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TopicFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var topic = await topicService.GetByIdAsync(model.Id);
            if (topic == null)
            {
                return NotFound();
            }

            var selectedTopicResources = await topicResourceService
                .GetAllByIdsAsync(model.SelectedResources.ToArray());

            mapper.Map(model, topic);
            topic.Resources.AddRange(selectedTopicResources);

            await topicService.UpdateAsync(topic);

            TempData[MessageSuccess] = "Темата беше променена успешно.";

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<JsonResult> DeleteResourceFromTopicAjax(
            string topicId,
            string creatorId,
            string resourceId)
        {
            if(creatorId != User.Id())
            {
                return new JsonResult(new { message = "Заявката е невалидна и не може да бъде обработена.", success = false });
            }

            bool isDeleted = await topicService
                .DeleteTopicResourceFromTopicAsync(topicId, resourceId);
            string message;
            if (isDeleted)
            {
                message = "Ресурсът е премахнат успешно от темата.";
            }
            else
            {
                message = "Възникна грешка при премахването на ресурс.";
            }

            return new JsonResult(new { message, success = isDeleted });
        }

        [HttpGet]
        public async Task<IActionResult> Topic(string id)
        {
            var topic = await topicService.GetByIdAsync(id);
            if(topic == null)
            {
                return BadRequest();
            }
            var model = mapper.Map<TopicViewModel>(topic);

            return View(model);
        }
    }
}
