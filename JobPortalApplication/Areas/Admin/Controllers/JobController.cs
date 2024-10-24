using JobPortalApplication.Models.ViewModels;
using JobPortalApplication.Models;
using JobPortalApplication.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Hosting;
using NuGet.Common;
using JobPortalApplication.Helpers;
using JobPortalApplication.Models.Enum;

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
            List<Job> JobList = _unitOfWork.JobRepo.GetAll_WSET(e => e.IsDeleted == false, includeProperties: "Employer,Employer.Company").ToList();
            return View(JobList);

        }

        public IActionResult Update(int id)
        {
            JobVM jobVM = new JobVM()
            {
                JobLevelList = Enum.GetValues(typeof(JobLevel)).Cast<JobLevel>().Select(jobLevel => new SelectListItem
                {
                    Text = jobLevel.ToString(),
                    Value = ((int)jobLevel).ToString()
                }).ToList(),
                JobTypeList = Enum.GetValues(typeof(JobType)).Cast<JobType>().Select(jobType => new SelectListItem
                {
                    Text = jobType.ToString(),
                    Value = ((int)jobType).ToString()
                }).ToList(),
                JobStatusList = Enum.GetValues(typeof(JobStatus)).Cast<JobStatus>().Select(jobStatus => new SelectListItem
                {
                    Text = jobStatus.ToString(),
                    Value = ((int)jobStatus).ToString()
                }).ToList(),

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


/*        [HttpPost]
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
                return View(jobVM);
            }
        }*/

/*        public IActionResult Detail(int id)
        {
            JobVM jobVM = new JobVM()
            {
                EmployerList = _unitOfWork.EmployerRepo.GetAll_WSET(e => e.Status == true, includeProperties: "Company").Select(u => new SelectListItem
                {
                    Text = u.Fullname,
                    Value = u.Id.ToString()
                })

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
*/        //[HttpPost, ActionName("Delete")]
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
            List<Job> JobList = _unitOfWork.JobRepo.GetAll_WSET(e => e.IsDeleted == false, includeProperties: "Employer,Employer.Company").ToList();
            var jobViewModel = JobList.Select(j => new
            {
                j.Id,
                j.Title,
                j.Description,
                employerEmail = j.Employer.Email,
                companyName = j.Employer.Company.Name,
                j.Requirements,
                j.Benefits,
                j.Salary,
                j.ExpiredDate,
                j.CreateOn,
                j.UpdatedOn,
                j.IsFeature,
                j.IsHot,
                j.IsDeleted,
                jobType = EnumHelper.GetEnumDescription(j.JobType),
                jobLevel = EnumHelper.GetEnumDescription(j.JobLevel),
                jobStatus = EnumHelper.GetEnumDescription(j.JobStatus)

            }).ToList();
            return Json(new { Data = jobViewModel });
        }


        [HttpPut]
        public IActionResult Hidden(int? id)
        {
            Job? job = _unitOfWork.JobRepo.Get(x => x.Id == id);
            job.IsDeleted = true;

            _unitOfWork.JobRepo.Update(job);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete Successful" });
        }
    }
}
