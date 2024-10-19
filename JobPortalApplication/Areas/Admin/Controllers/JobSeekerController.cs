using System.Text.RegularExpressions;
using JobPortalApplication.Models;
using JobPortalApplication.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace JobPortalApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class JobSeekerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public JobSeekerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<JobSeeker> seekerList = _unitOfWork.SeekerRepo.GetAll().ToList();
            return View(seekerList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(JobSeeker seeker)
        {
            if (ModelState.IsValid)
            {
                // Kiểm tra trùng username
                if (IsUserNameDuplicate(seeker.UserName))
                {
                    ModelState.AddModelError("UserName", "Username đã tồn tại!");
                    return View(seeker);
                }

                // Kiểm tra trùng email
                if (IsEmailDuplicate(seeker.Email))
                {
                    ModelState.AddModelError("Email", "Email đã tồn tại!");
                    return View(seeker);
                }

                // Kiểm tra trùng số điện thoại
                if (IsPhoneDuplicate(seeker.Phone))
                {
                    ModelState.AddModelError("Phone", "Số điện thoại đã tồn tại!");
                    return View(seeker);
                }

                // Kiểm tra số điện thoại hợp lệ
                if (!CheckPatternPhone(seeker.Phone))
                {
                    ModelState.AddModelError("Phone", "Số điện thoại không hợp lệ!");
                    return View(seeker);
                }

                // Kiểm tra email hợp lệ
                if (!CheckPatternEmail(seeker.Email))
                {
                    ModelState.AddModelError("Email", "Email không hợp lệ!");
                    return View(seeker);
                }

                seeker.Create_at = DateTime.Now;
                seeker.Update_at = DateTime.Now;
                _unitOfWork.SeekerRepo.Add(seeker);
                _unitOfWork.Save();
                TempData["success"] = "JobSeeker created successfully";
                return RedirectToAction("Index", "JobSeeker");
            }
            return View(seeker);
        }


        public IActionResult Update(int id)
        {
            if (id <= 0) // Kiểm tra xem ID có hợp lệ không
            {
                return NotFound();
            }

            // Lấy bản ghi seeker hiện có
            JobSeeker? existingSeeker = _unitOfWork.SeekerRepo.Get(x => x.Id == id);
            if (existingSeeker == null)
            {
                return NotFound();
            }

            return View(existingSeeker);
        }

        [HttpPost]
        public IActionResult Update(JobSeeker seeker)
        {
            if (ModelState.IsValid)
            {
                // Kiểm tra trùng username
                if (IsUserNameDuplicate(seeker.UserName, seeker.Id))
                {
                    ModelState.AddModelError("UserName", "Username đã tồn tại!");
                    return View(seeker);
                }

                // Kiểm tra trùng email
                if (IsEmailDuplicate(seeker.Email, seeker.Id))
                {
                    ModelState.AddModelError("Email", "Email đã tồn tại!");
                    return View(seeker);
                }

                // Kiểm tra trùng số điện thoại
                if (IsPhoneDuplicate(seeker.Phone, seeker.Id))
                {
                    ModelState.AddModelError("Phone", "Số điện thoại đã tồn tại!");
                    return View(seeker);
                }

                // Kiểm tra số điện thoại hợp lệ
                if (!CheckPatternPhone(seeker.Phone))
                {
                    ModelState.AddModelError("Phone", "Số điện thoại không hợp lệ!");
                    return View(seeker);
                }

                // Kiểm tra email hợp lệ
                if (!CheckPatternEmail(seeker.Email))
                {
                    ModelState.AddModelError("Email", "Email không hợp lệ!");
                    return View(seeker);
                }

                // Cập nhật các trường ngoại trừ Create_at
                var existingSeeker = _unitOfWork.SeekerRepo.Get(x => x.Id == seeker.Id);
                if (existingSeeker == null)
                {
                    return NotFound();
                }

                existingSeeker.UserName = seeker.UserName;
                existingSeeker.Password = seeker.Password;
                existingSeeker.Email = seeker.Email;
                existingSeeker.FullName = seeker.FullName;
                existingSeeker.Phone = seeker.Phone;
                existingSeeker.Update_at = DateTime.Now;

                _unitOfWork.SeekerRepo.Update(existingSeeker);
                _unitOfWork.Save();
                TempData["success"] = "JobSeeker đã được cập nhật thành công";

                return RedirectToAction("Index", "JobSeeker");
            }

            return View(seeker);
        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<JobSeeker> objJobSeeker = _unitOfWork.SeekerRepo.GetListTrue(x => x.Status == true).ToList();
            return Json(new { data = objJobSeeker });
        }

        public IActionResult Delete(int id)
        {
            var seekerDelete = _unitOfWork.SeekerRepo.Get(x => x.Id == id);
            if (seekerDelete == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            seekerDelete.Status = false;
            _unitOfWork.SeekerRepo.Update(seekerDelete);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });
        }
        #endregion

        // Kiểm tra số điện thoại
        public static bool CheckPatternPhone(string phone)
        {
            var pattern = @"^(0|\+?84)(3|5|7|8|9)[0-9]{8}$"; // Kiểm tra định dạng số điện thoại Việt Nam
            return Regex.IsMatch(phone, pattern);
        }

        // Kiểm tra email
        public static bool CheckPatternEmail(string email)
        {
            var pattern = @"^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$"; // Kiểm tra định dạng email
            return Regex.IsMatch(email, pattern);
        }

        // Kiểm tra trùng username
        public bool IsUserNameDuplicate(string username, int? id = null)
        {
            if (id == null)
            {
                return _unitOfWork.SeekerRepo.Get(x => x.UserName == username) != null;
            }
            else
            {
                return _unitOfWork.SeekerRepo.Get(x => x.UserName == username && x.Id != id) != null;
            }
        }

        // Kiểm tra trùng email
        public bool IsEmailDuplicate(string email, int? id = null)
        {
            if (id == null)
            {
                return _unitOfWork.SeekerRepo.Get(x => x.Email == email) != null;
            }
            else
            {
                return _unitOfWork.SeekerRepo.Get(x => x.Email == email && x.Id != id) != null;
            }
        }

        // Kiểm tra trùng số điện thoại
        public bool IsPhoneDuplicate(string phone, int? id = null)
        {
            if (id == null)
            {
                return _unitOfWork.SeekerRepo.Get(x => x.Phone == phone) != null;
            }
            else
            {
                return _unitOfWork.SeekerRepo.Get(x => x.Phone == phone && x.Id != id) != null;
            }
        }

    }
}
