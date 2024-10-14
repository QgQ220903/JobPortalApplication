using JobPortalApplication.Data;
using JobPortalApplication.Models;
using JobPortalApplication.Repository;
using JobPortalApplication.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace JobPortalApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class JobSkillController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public JobSkillController(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Skill> skillList = _unitOfWork.SkillRepo.GetAll().ToList();
            return View(skillList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Skill skill)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.SkillRepo.Add(skill);
                _unitOfWork.Save();
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
            Skill? skill = _unitOfWork.SkillRepo.Get(x => x.Id == id);

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
                _unitOfWork.SkillRepo.Update(skill);
                _unitOfWork.Save();
                TempData["success"] = "Skill updated successfully";

                return RedirectToAction("Index", "JobSkill");
            }
            return View();
        }

/*        public IActionResult Delete(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Skill? skill = _unitOfWork.SkillRepo.Get(x => x.Id == id);
<<<<<<< Updated upstream
=======
            if(skill == null)
            {
                return NotFound();
            }
            return View(skill);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int id)
        {
            Skill? skill = _unitOfWork.SkillRepo.Get(x=>x.Id == id);
>>>>>>> Stashed changes
            if (skill == null)
            {
                return NotFound();
            }
<<<<<<< Updated upstream
            return View(skill);
        }*/
/*        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int id)
        {
            Skill? skill = _unitOfWork.SkillRepo.Get(x => x.Id == id);
            if (skill == null)
            {
                return NotFound();
            }
=======
>>>>>>> Stashed changes
            _unitOfWork.SkillRepo.Remove(skill);
            _unitOfWork.Save();
            TempData["success"] = "Skill deleted successfully";
            return RedirectToAction("Index", "JobSkill");
        }*/


        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Skill> skillListObj = _unitOfWork.SkillRepo.GetListTrue(x => x.Status == true).ToList();
            return Json(new { data = skillListObj });
        }

        public IActionResult Delete(int id)
        {
            var skillDelete = _unitOfWork.SkillRepo.Get(x => x.Id == id);
            if (skillDelete == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            skillDelete.Status = false;
            _unitOfWork.SkillRepo.Update(skillDelete);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successfully" });
        }
        #endregion
    }
}