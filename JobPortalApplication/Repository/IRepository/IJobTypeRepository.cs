using JobPortalApplication.Models;

namespace JobPortalApplication.Repository.IRepository
{
    public interface IJobTypeRepository : IRepository<JobType>
    {
        void Update(JobType jobType);
    }
}
