using JobPortalApplication.Models;
using JobPortalApplication.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace JobPortalApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CompanyController : Controller
    {
		private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
		public CompanyController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
		{		
			_unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
		}
		public IActionResult Index()
        {
			List<Company> companyList = _unitOfWork.CompanyRepo.GetAll().ToList();
			return View(companyList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Company company, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;        

                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string companyPath = Path.Combine(wwwRootPath, @"admin\img\Company");

                    using( var fileStream = new FileStream(Path.Combine(companyPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    company.Logo = @"\admin\img\Company\" + fileName;
                }
              
                _unitOfWork.CompanyRepo.Add(company);
                _unitOfWork.Save();
                TempData["success"] = "Company created successfully";
                return RedirectToAction("Index", "Company");
            }
            if (file == null)
            {
                // Truyền thông báo lỗi bằng ViewBag
                ViewBag.ErrorMessage = "File logo không được để trống!";
                return View();
            }
            return View();

        }
        public IActionResult Detail(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Company? company = _unitOfWork.CompanyRepo.Get(x => x.Id == id);
            if (company == null)
            {
                return NotFound();
            }
            return View(company);
        }

        public IActionResult Update(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Company? company = _unitOfWork.CompanyRepo.Get(x => x.Id == id);
            if (company == null)
            {
                return NotFound();
            }
            return View(company);
        }
        [HttpPost]
        public IActionResult Update(Company company, IFormFile? file)
        {
            if (ModelState.IsValid)
             {
                 string wwwRootPath = _webHostEnvironment.WebRootPath;

                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string companyPath = Path.Combine(wwwRootPath, @"admin\img\Company");

                    if (!string.IsNullOrEmpty(company.Logo))
                    {
                        var oldLogo = Path.Combine(wwwRootPath,company.Logo.TrimStart('\\'));

                        if (System.IO.File.Exists(oldLogo))
                        {
                            System.IO.File.Delete(oldLogo);
                        }
                    }

                    using (var fileStream = new FileStream(Path.Combine(companyPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    company.Logo = @"\admin\img\Company\" + fileName;
                }
                _unitOfWork.CompanyRepo.Update(company);
                _unitOfWork.Save();
                TempData["success"] = "Company update successfully";
                return RedirectToAction("Index", "Company");
            }
            return View();

        }

        public IActionResult Delete(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Company? company = _unitOfWork.CompanyRepo.Get(x => x.Id == id);
            if (company == null)
            {
                return NotFound();
            }
            return View(company);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int id)
        {
            Company? company = _unitOfWork.CompanyRepo.Get(x => x.Id == id);
            if (company == null)
            {
                return NotFound();
            }

            if (!string.IsNullOrEmpty(company.Logo))
            {
                var oldLogo = Path.Combine(_webHostEnvironment.WebRootPath, company.Logo.TrimStart('\\'));

                if (System.IO.File.Exists(oldLogo))
                {
                    System.IO.File.Delete(oldLogo);
                }
            }
                         
            _unitOfWork.CompanyRepo.Remove(company);
            _unitOfWork.Save();
            TempData["success"] = "Company deleted successfully";
            return RedirectToAction("Index", "Company");
        }
    }
}
