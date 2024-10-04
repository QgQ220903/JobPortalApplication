namespace JobPortalApplication.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ISkillRepository SkillRepo { get; }

        ICompanyRepository CompanyRepo { get; }
        IEmployerRepository EmployerRepo { get; }
        void Save();
    }
}
