using Microsoft.AspNetCore.Mvc;

namespace JobPortalApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class JobController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
