using Microsoft.AspNetCore.Mvc;

namespace JobPortalApplication.Areas.EndUser.Controllers
{
    [Area("EndUser")]
    public class AccountController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Profile() { 
            return View();
        }

        public IActionResult ProfileEmployer() { 
            return View();
        }

        public IActionResult ListApplicants()
        {
            return View();
        }

        public IActionResult PostJob() { 
            return View();
        }

        public IActionResult JobApply() {
            return View();
        }
        public IActionResult MyJob()
        {
            return View();
        }
        public IActionResult SavedJob()
        {
            return View();
        }
    }
}
