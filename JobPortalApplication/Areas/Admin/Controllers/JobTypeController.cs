using Microsoft.AspNetCore.Mvc;

namespace JobPortalApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class JobTypeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
