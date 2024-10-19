using JobPortalApplication.Models;
using JobPortalApplication.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;

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
            List<JobLevel> levelList = _unitOfWork.LevelRepo.GetListTrue(x => x.Status == true).ToList();
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
                // Kiểm tra trùng username
                if (IsUserNameDuplicate(level.Name))
                {
                    ModelState.AddModelError("Name", "name đã tồn tại!");
                    return View(level);
                }
                _unitOfWork.LevelRepo.Add(level);
                _unitOfWork.Save();
                TempData["success"] = "Level created successfully";
                return RedirectToAction("Index", "JobLevel");
            }
            return View();
        }
        public IActionResult Update(int id)
        {
            if (id <= 0)
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
                // Kiểm tra trùng username
                if (IsUserNameDuplicate(level.Name, level.Id))
                {
                    ModelState.AddModelError("Name", "Name đã tồn tại!");
                    return View(level);
                }
                _unitOfWork.LevelRepo.Update(level);
                _unitOfWork.Save();
                TempData["success"] = "Level updated successfully";

                return RedirectToAction("Index", "JobLevel");
            }
            return View();
        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<JobLevel> objJobLevel = _unitOfWork.LevelRepo.GetListTrue(x => x.Status == true).ToList();
            return Json(new { data = objJobLevel });
        }

        public IActionResult Delete(int id)
        {
            var levelDelete = _unitOfWork.LevelRepo.Get(x => x.Id == id);
            if (levelDelete == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            levelDelete.Status = false;
            _unitOfWork.LevelRepo.Update(levelDelete);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });
        }
        #endregion

        // Kiểm tra trùng username
        public bool IsUserNameDuplicate(string username, int? id = null)
        {
            if (id == null)
            {
                return _unitOfWork.LevelRepo.Get(x => x.Name == username) != null;
            }
            else
            {
                return _unitOfWork.LevelRepo.Get(x => x.Name == username && x.Id != id) != null;
            }
        }
    }
}
