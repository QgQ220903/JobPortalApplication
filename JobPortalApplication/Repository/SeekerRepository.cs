using JobPortalApplication.Data;
using JobPortalApplication.Models;
using JobPortalApplication.Repository.IRepository;

namespace JobPortalApplication.Repository
{
    public class SeekerRepository : Repository<JobSeeker>, ISeekerRepository
    {
        private ApplicationDbContext _context;
        public SeekerRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(JobSeeker seeker)
        {
            _context.JobSeekers.Update(seeker);
        }
    }
}
