using Microsoft.AspNetCore.Mvc;

namespace Daskalo.Web.Areas.Admin.Controllers
{
    public class SchoolsController : BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
