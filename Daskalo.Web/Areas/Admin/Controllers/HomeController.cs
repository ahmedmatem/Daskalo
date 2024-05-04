using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Daskalo.Web.Areas.Admin.Controllers
{
    public class HomeController : BaseAdminController
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
