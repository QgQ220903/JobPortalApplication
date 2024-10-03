using JobPortalApplication.Models;

namespace JobPortalApplication.Repository.IRepository
{
        public interface ILevelRepository : IRepository<JobLevel>
        {
            void Update(JobLevel level);
        }
}
