using Microsoft.AspNetCore.Mvc;

namespace Daskalo.Web.Areas.Teacher.Controllers
{
    public class GroupsController : BaseTeacherController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
