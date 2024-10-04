using JobPortalApplication.Data;
using JobPortalApplication.Models;
using JobPortalApplication.Repository.IRepository;

namespace JobPortalApplication.Repository
{
    public class EmployerRepository : Repository<Employer>, IEmployerRepository
    {
        private ApplicationDbContext _context;
        public EmployerRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public void Update(Employer employer)
        {
            _context.Employers.Update(employer);
            var objFromDb = _context.Employers.FirstOrDefault(u => u.Id == employer.Id);
            if (objFromDb != null)
            {
                objFromDb.Username = employer.Username;
                objFromDb.Password = employer.Password;
                objFromDb.Email = employer.Email;
                objFromDb.Fullname = employer.Fullname;
                objFromDb.CompanyId = employer.CompanyId;
                objFromDb.Create = employer.Create;
                objFromDb.Update = employer.Update;

                
            }
        }

    }
}
