namespace JobPortalApplication.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ISkillRepository SkillRepo { get; }
        ICompanyRepository CompanyRepo { get; }
        ILevelRepository LevelRepo { get; }
        ISeekerRepository SeekerRepo { get; }
        IJobTypeRepository JobTypeRepo { get; }
        IEmployerRepository EmployerRepo { get; }
        IJobRepository JobRepo { get; }
        void Save();
    }
}
