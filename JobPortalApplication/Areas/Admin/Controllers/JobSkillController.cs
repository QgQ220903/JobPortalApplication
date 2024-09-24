using JobPortalApplication.Data;
using JobPortalApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobPortalApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class JobSkillController : Controller
    {
        private readonly ApplicationDbContext _context;
        public JobSkillController(ApplicationDbContext context) 
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Skill> skillList = _context.Skills.ToList();
            return View(skillList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Skill skill)
        {
            if(ModelState.IsValid)
            {
                _context.Skills.Add(skill);
                _context.SaveChanges();
                return RedirectToAction("Index", "JobSkill");
            }
            return View();
        }
    }
}
