﻿using JobPortalApplication.Models;
using JobPortalApplication.Models.ViewModels;
using JobPortalApplication.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace JobPortalApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmployerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public EmployerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Employer> employerlist = _unitOfWork.EmployerRepo.GetAll_WSET(e => e.Status == true,includeProperties:"Company").ToList();
            return View(employerlist);
        }

        public IActionResult Upsert(int? id)
        {
            EmployerVM employerVM = new EmployerVM()
            {
                CompanyList = _unitOfWork.CompanyRepo.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                Employer = new Employer()

            };
            if(id==null || id == 0)
            {
                return View(employerVM);
            }
            else
            {
                employerVM.Employer=_unitOfWork.EmployerRepo.Get(u=>u.Id==id);
                return View(employerVM);
            }
        }
        [HttpPost]
        public IActionResult Upsert(EmployerVM employerVM, IFormFile? file)
        {
            
                if (ModelState.IsValid)
                {
                    if (employerVM.Employer.Id == 0)
                    {   
                        _unitOfWork.EmployerRepo.Add(employerVM.Employer);
                    }
                    else
                    {
                    _unitOfWork.EmployerRepo.Update(employerVM.Employer);
                    }
                    _unitOfWork.Save();
                    TempData["success"] = "Employer created successfully";
                    return RedirectToAction("Index", "Employer");
                }
                else
                {
                    employerVM.CompanyList = _unitOfWork.CompanyRepo.GetAll().Select(u => new SelectListItem
                    {
                        Text = u.Name,
                        Value = u.Id.ToString()
                    });
                    return View(employerVM);
                }



        }

        public IActionResult Detail(int id)
        {
            EmployerVM employerVM = new EmployerVM()
            {
                CompanyList = _unitOfWork.CompanyRepo.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                Employer = new Employer()

            };
            if (id == null || id == 0)
            {
                return View(employerVM);
            }
            else
            {
                employerVM.Employer = _unitOfWork.EmployerRepo.Get(u => u.Id == id);
                return View(employerVM);
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
            List<Employer> employerList = _unitOfWork.EmployerRepo
              .GetAll_WSET(e => e.Status == true, includeProperties: "Company")
              .ToList();
            return Json(new { Data = employerList });
        }

        

        [HttpPut]
        public IActionResult Hidden(int? id)
        {
            Employer? employer = _unitOfWork.EmployerRepo.Get(x => x.Id == id);
            employer.Status = false;

            _unitOfWork.EmployerRepo.Update(employer);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete Successful" });
        }

    }
}

