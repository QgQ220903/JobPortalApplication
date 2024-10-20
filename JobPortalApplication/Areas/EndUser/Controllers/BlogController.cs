using Microsoft.AspNetCore.Mvc;

namespace JobPortalApplication.Areas.EndUser.Controllers
{
    [Area("EndUser")]
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }
    }
}
