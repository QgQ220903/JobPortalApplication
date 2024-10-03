using JobPortalApplication.Models;
using JobPortalApplication.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace JobPortalApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class JobLevelController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public JobLevelController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<JobLevel> levelList = _unitOfWork.LevelRepo.GetAll().ToList();
            return View(levelList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(JobLevel level)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.LevelRepo.Add(level);
                _unitOfWork.Save();
                TempData["success"] = "Level created successfully";
                return RedirectToAction("Index", "JobLevel");
            }
            return View();
        }
        public IActionResult Update(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            JobLevel? level = _unitOfWork.LevelRepo.Get(x => x.Id == id);
            if (level == null)
            {
                return NotFound();
            }
            return View(level);
        }
        [HttpPost]
        public IActionResult Update(JobLevel level)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.LevelRepo.Update(level);
                _unitOfWork.Save();
                TempData["success"] = "Level updated successfully";

                return RedirectToAction("Index", "JobLevel");
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            JobLevel? level = _unitOfWork.LevelRepo.Get(x => x.Id == id);
            if (level == null)
            {
                return NotFound();
            }
            return View(level);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int id)
        {
            JobLevel? level= _unitOfWork.LevelRepo.Get(x => x.Id == id);
            if (level == null)
            {
                return NotFound();
            }
            _unitOfWork.LevelRepo.Remove(level);
            _unitOfWork.Save();
            TempData["success"] = "Level deleted successfully";
            return RedirectToAction("Index", "JobLevel");
        }
    }
}
