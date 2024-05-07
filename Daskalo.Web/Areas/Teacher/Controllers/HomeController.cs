using Microsoft.AspNetCore.Mvc;

namespace Daskalo.Web.Areas.Teacher.Controllers
{
    public class HomeController : BaseTeacherController
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Groups");
        }
    }
}
