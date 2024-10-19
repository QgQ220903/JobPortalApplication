using JobPortalApplication.Data;
using JobPortalApplication.Models;
using JobPortalApplication.Repository.IRepository;

namespace JobPortalApplication.Repository
{
    public class JobTypeRepository : Repository<JobType>, IJobTypeRepository
    {
        private ApplicationDbContext _context;
        public JobTypeRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(JobType jobType)
        {
            _context.JobTypes.Update(jobType);
        }
    }
}
