using JobPortalApplication.Models;

namespace JobPortalApplication.Repository.IRepository
{
    public interface IJobRepository : IRepository<Job>
    {
        void Update(Job job);
    }
}
