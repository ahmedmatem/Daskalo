using AutoMapper;
using Daskalo.Core.Contracts;
using Daskalo.Infrastructure.Data.Models;
using Daskalo.Web.Areas.Teacher.Models.Group;
using Daskalo.Web.Extensions;
using Microsoft.AspNetCore.Mvc;

#nullable disable

namespace Daskalo.Web.Areas.Teacher.Controllers
{
    public class GroupsController : BaseTeacherController
    {
        private readonly IMapper mapper;
        private readonly IGroupService groupService;

        public GroupsController(
            IMapper _mapper,
            IGroupService _groupService)
        {
            mapper = _mapper;
            groupService = _groupService;
        }

        public async Task<IActionResult> Index()
        {
            var teacherGroups = await groupService.AllByCreatorAsync(User.Id());
            var model = mapper.Map<IEnumerable<GroupCardViewModel>>(teacherGroups);

            return View(model);
        }
    }
}
