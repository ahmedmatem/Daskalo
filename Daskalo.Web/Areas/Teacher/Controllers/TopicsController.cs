using Daskalo.Core.Contracts;
using Daskalo.Web.Areas.Teacher.Models.Topic;
using Daskalo.Web.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;

namespace Daskalo.Web.Areas.Teacher.Controllers
{
    public class TopicsController : BaseTeacherController
    {
        private readonly ITopicService topicService;
        private readonly ITopicResourceService topicResourceService;

        public TopicsController(
            ITopicService _topicService,
            ITopicResourceService _topicResourceService)
        {
            topicService = _topicService;
            topicResourceService = _topicResourceService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await topicService.AllAsync(User.Id()!);

            return View(model);
        }

        public async Task<IActionResult> Add()
        {
            TopicFormViewModel model = new TopicFormViewModel();
            ViewData["TopicResourceSelectList"] = 
                await topicResourceService.SelectListAsync(User.Id()!);

            return View(model);
        }
    }
}
