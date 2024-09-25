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
                TempData["success"] = "Skill created successfully";
                return RedirectToAction("Index", "JobSkill");
            }
            return View();
        }

        public IActionResult Update(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Skill? skill = _context.Skills.FirstOrDefault(x => x.Id == id);
            if(skill == null)
            {
                return NotFound();
            }
            return View(skill);
        }
        [HttpPost]
        public IActionResult Update(Skill skill)
        {
            if (ModelState.IsValid)
            {
                _context.Skills.Update(skill);
                _context.SaveChanges();
                TempData["success"] = "Skill updated successfully";

                return RedirectToAction("Index", "JobSkill");
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Skill? skill = _context.Skills.FirstOrDefault(x => x.Id == id);
            if(skill == null)
            {
                return NotFound();
            }
            return View(skill);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int id)
        {
            Skill? skill = _context.Skills.FirstOrDefault(x=>x.Id == id);
            if (skill == null)
            {
                return NotFound();
            }
            _context.Skills.Remove(skill);
            _context.SaveChanges();
            TempData["success"] = "Skill deleted successfully";
            return RedirectToAction("Index", "JobSkill");
        }
    }
}
