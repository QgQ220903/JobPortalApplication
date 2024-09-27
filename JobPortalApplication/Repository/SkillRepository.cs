using JobPortalApplication.Data;
using JobPortalApplication.Models;
using JobPortalApplication.Repository.IRepository;

namespace JobPortalApplication.Repository
{
    public class SkillRepository : Repository<Skill>, ISkillRepository
    {
        private ApplicationDbContext _context;
        public SkillRepository(ApplicationDbContext context) : base(context)
        {
            _context  = context;
        }

        public void Update(Skill skill)
        {
            _context.Skills.Update(skill);
        }
    }
}
