using JobPortalApplication.Data;
using JobPortalApplication.Models;
using JobPortalApplication.Repository.IRepository;

namespace JobPortalApplication.Repository
{
    public class LevelRepository:Repository<JobLevel>, ILevelRepository
    {
        private ApplicationDbContext _context;
        public LevelRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(JobLevel level)
        {
            _context.JobLevels.Update(level);
        }
    }
}
