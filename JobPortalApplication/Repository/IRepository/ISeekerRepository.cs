using JobPortalApplication.Models;

namespace JobPortalApplication.Repository.IRepository
{
    public interface ISeekerRepository : IRepository<JobSeeker>
    {
        void Update(JobSeeker seeker);
    }
}
