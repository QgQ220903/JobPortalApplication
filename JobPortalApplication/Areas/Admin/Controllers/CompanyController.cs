using Microsoft.AspNetCore.Mvc;

namespace JobPortalApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
