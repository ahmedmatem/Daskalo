using Daskalo.Core.Contracts;
using Daskalo.Web.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Daskalo.Web.Areas.SchoolAdmin.Controllers
{
    public class GroupsController : BaseSchoolAdminController
    {
        private readonly IGroupService groupService;

        public GroupsController(IGroupService _groupService)
        {
            groupService = _groupService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await groupService.AllAsync(User.SchoolId());

            return View(model);
        }
    }
}
