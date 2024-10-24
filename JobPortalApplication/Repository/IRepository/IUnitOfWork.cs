namespace JobPortalApplication.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ISkillRepository SkillRepo { get; }
        ICompanyRepository CompanyRepo { get; }
        ISeekerRepository SeekerRepo { get; }
        IEmployerRepository EmployerRepo { get; }
        IJobRepository JobRepo { get; }
        void Save();
    }
}
