using JobPortalApplication.Models;

namespace JobPortalApplication.Repository.IRepository
{
    public interface ICompanyRepository : IRepository<Company>
    { 
        void Update(Company company);
    }
}
