using Microsoft.AspNetCore.Mvc;

namespace JobPortalApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmployerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

