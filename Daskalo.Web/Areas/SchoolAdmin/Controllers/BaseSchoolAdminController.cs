using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Daskalo.Web.Areas.SchoolAdmin.Controllers
{
    [Area("SchoolAdmin")]
    [Authorize(Roles = "SchoolAdmin")]
    public class BaseSchoolAdminController : Controller
    {

    }
}
