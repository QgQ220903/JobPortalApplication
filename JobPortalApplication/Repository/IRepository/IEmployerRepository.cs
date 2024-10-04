using JobPortalApplication.Models;

namespace JobPortalApplication.Repository.IRepository
{
    public interface IEmployerRepository : IRepository<Employer>
    {
        void Update(Employer employer);
    }
}
