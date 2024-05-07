using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Daskalo.Web.Areas.Teacher.Controllers
{
    [Area("Teacher")]
    [Authorize(Roles = "Teacher, SchoolAdmin")]
    public class BaseTeacherController : Controller
    {
    }
}
