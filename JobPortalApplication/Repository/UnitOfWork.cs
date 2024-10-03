using JobPortalApplication.Data;
using JobPortalApplication.Repository.IRepository;

namespace JobPortalApplication.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;
        public ISkillRepository SkillRepo { get; private set; }
        public ICompanyRepository CompanyRepo { get; private set; }


        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            SkillRepo = new SkillRepository(_context);
            CompanyRepo = new CompanyRepository(_context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
