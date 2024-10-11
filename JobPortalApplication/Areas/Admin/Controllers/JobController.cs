using JobPortalApplication.Models.ViewModels;
using JobPortalApplication.Models;
using JobPortalApplication.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Hosting;

namespace JobPortalApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class JobController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public JobController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            List<Job> JobList = _unitOfWork.JobRepo.GetAll_WSET(e => e.Status == true, includeProperties: "Employer,Employer.Company,JobLevel,JobType").ToList();
            return View(JobList);
        }

        public IActionResult Upsert(int? id)
        {
            JobVM jobVM = new JobVM()
            {
                EmployerList = _unitOfWork.EmployerRepo.GetAll_WSET(e => e.Status == true, includeProperties: "Company").Select(u => new SelectListItem
                {
                    Text = u.Fullname,
                    Value = u.Id.ToString()
                }),
                JobLevelList = _unitOfWork.LevelRepo.GetAll_WSET(e => e.Status == true).Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                JobTypeList = _unitOfWork.JobTypeRepo.GetAll_WSET(e => e.Status == true).Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                Job = new Job()

            };
            if (id == null || id == 0)
            {
                return View(jobVM);
            }
            else
            {
                jobVM.Job = _unitOfWork.JobRepo.Get(u => u.Id == id);
                return View(jobVM);
            }
        }
        [HttpPost]
        public IActionResult Upsert(JobVM jobVM, IFormFile? file)
        {

            if (ModelState.IsValid)
            {
                if (jobVM.Job.Id == 0)
                {
                    _unitOfWork.JobRepo.Add(jobVM.Job);
                }
                else
                {
                    _unitOfWork.JobRepo.Update(jobVM.Job);
                }
                _unitOfWork.Save();
                TempData["success"] = "Job created successfully";
                return RedirectToAction("Index", "Job");
            }
            else
            {
                jobVM.EmployerList = _unitOfWork.EmployerRepo.GetAll_WSET(e => e.Status == true, includeProperties: "Company").Select(u => new SelectListItem
                {
                    Text = u.Fullname,
                    Value = u.Id.ToString()
                });
                jobVM.JobLevelList = _unitOfWork.LevelRepo.GetAll_WSET(e => e.Status == true).Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                });
                jobVM.JobTypeList = _unitOfWork.JobTypeRepo.GetAll_WSET(e => e.Status == true).Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                });
                return View(jobVM);
            }



        }

        public IActionResult Detail(int id)
        {
            JobVM jobVM = new JobVM()
            {
                EmployerList = _unitOfWork.EmployerRepo.GetAll_WSET(e => e.Status == true, includeProperties: "Company").Select(u => new SelectListItem
                {
                    Text = u.Fullname,
                    Value = u.Id.ToString()
                }),
                JobLevelList = _unitOfWork.LevelRepo.GetAll_WSET(e => e.Status == true).Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                JobTypeList = _unitOfWork.JobTypeRepo.GetAll_WSET(e => e.Status == true).Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                Job = new Job()

            };
            if (id == null || id == 0)
            {
                return View(jobVM);
            }
            else
            {
                jobVM.Job = _unitOfWork.JobRepo.Get(u => u.Id == id);
                return View(jobVM);
            }
        }
        //[HttpPost, ActionName("Delete")]
        //public IActionResult DeletePOST(int id)
        //{
        //    Employer employer = _unitOfWork.EmployerRepo.Get(e => e.Id == id);
        //    employer.Status = false;
        //    _unitOfWork.EmployerRepo.Update(employer);
        //    _unitOfWork.Save();
        //    TempData["success"] = "Employer deleted successfully";
        //    return RedirectToAction("Index", "Employer");
        //}


        /* CALL API*/
        [HttpGet]
        public IActionResult GetAll()
        {
            //List<Company> companyList = _unitOfWork.CompanyRepo.GetAll().ToList();
            List<Job> JobList = _unitOfWork.JobRepo
                .GetAll_WSET(e => e.Status == true, includeProperties: "Employer,Employer.Company,JobLevel,JobType")
                .ToList();
            return Json(new { Data = JobList });
        }



        [HttpPut]
        public IActionResult Hidden(int? id)
        {
            Job? job = _unitOfWork.JobRepo.Get(x => x.Id == id);
            job.Status = false;

            _unitOfWork.JobRepo.Update(job);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete Successful" });
        }
    }
}
