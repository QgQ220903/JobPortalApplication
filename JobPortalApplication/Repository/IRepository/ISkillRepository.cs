using JobPortalApplication.Models;

namespace JobPortalApplication.Repository.IRepository
{
    public interface ISkillRepository : IRepository<Skill>
    { 
        void Update(Skill skill);
    }
}
