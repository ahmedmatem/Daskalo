using Daskalo.Core.Contracts;
using Daskalo.Web.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Daskalo.Web.Areas.Teacher.Controllers
{
    public class ResourcesController : BaseTeacherController
    {
        private readonly ITopicResourceService resourceService;

        public ResourcesController(ITopicResourceService _resourceService)
        {
            resourceService = _resourceService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await resourceService.AllByOwnerAsync(User.Id()!);

            return View(model);
        }
    }
}
