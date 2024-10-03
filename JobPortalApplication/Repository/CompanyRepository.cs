using JobPortalApplication.Data;
using JobPortalApplication.Models;
using JobPortalApplication.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace JobPortalApplication.Repository
{
	public class CompanyRepository : Repository<Company>, ICompanyRepository
	{
		private ApplicationDbContext _context;
		public CompanyRepository(ApplicationDbContext context) : base(context)
		{
			_context = context;
		}
		public void Update(Company company)
		{
			_context.Companys.Update(company);
			var objFromDb = _context.Companys.FirstOrDefault(u => u.Id == company.Id);
            if (objFromDb != null)
            {
				objFromDb.Name = company.Name;
                objFromDb.Industry = company.Industry;
                objFromDb.Description = company.Description;
                objFromDb.Website = company.Website;
                objFromDb.Email = company.Email;
                objFromDb.Phone = company.Phone;
                objFromDb.Create = company.Create;
                objFromDb.Update = company.Update;

				if (objFromDb.Logo != null)
				{
					objFromDb.Logo = objFromDb.Logo;
				}
            }
        }

	}
}
