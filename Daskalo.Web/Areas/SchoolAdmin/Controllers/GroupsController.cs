using Microsoft.AspNetCore.Mvc;

namespace Daskalo.Web.Areas.SchoolAdmin.Controllers
{
    public class GroupsController : BaseSchoolAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
