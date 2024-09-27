namespace JobPortalApplication.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ISkillRepository SkillRepo { get; }
        void Save();
    }
}
