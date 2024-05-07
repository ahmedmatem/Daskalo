using Daskalo.Web.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Daskalo.Web.Areas.Teacher.Controllers
{
    [Area("Teacher")]
    [Authorize(Roles = "Teacher, SchoolAdmin")]
    [Activated]
    public class BaseTeacherController : Controller
    {
    }
}
