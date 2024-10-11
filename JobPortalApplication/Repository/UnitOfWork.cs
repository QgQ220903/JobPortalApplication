using JobPortalApplication.Data;
using JobPortalApplication.Repository.IRepository;

namespace JobPortalApplication.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;
        public ISkillRepository SkillRepo { get; private set; }

        public ICompanyRepository CompanyRepo { get; private set; }
        public IEmployerRepository EmployerRepo { get; private set; }
        public IJobTypeRepository JobTypeRepo { get; }
        public ILevelRepository LevelRepo { get; private set; }
        public ISeekerRepository SeekerRepo { get; private set; }
        public IJobRepository JobRepo { get; private set; }



        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            SkillRepo = new SkillRepository(_context);
            CompanyRepo = new CompanyRepository(_context);
            EmployerRepo = new EmployerRepository(_context);
            JobTypeRepo= new JobTypeRepository(_context);
            LevelRepo = new LevelRepository(_context);
            SeekerRepo = new SeekerRepository(_context);
            JobRepo = new JobRepository(_context);

        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
