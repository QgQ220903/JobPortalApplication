namespace JobPortalApplication.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ISkillRepository SkillRepo { get; }
        ICompanyRepository CompanyRepo { get; }
        ILevelRepository LevelRepo { get; }
        ISeekerRepository SeekerRepo { get; }

        void Save();
    }
}
