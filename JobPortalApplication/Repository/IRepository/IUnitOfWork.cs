namespace JobPortalApplication.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ISkillRepository SkillRepo { get; }

        ICompanyRepository CompanyRepo { get; }
        void Save();
    }
}
