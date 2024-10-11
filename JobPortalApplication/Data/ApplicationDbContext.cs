using JobPortalApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace JobPortalApplication.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Skill> Skills { get; set; }
        public DbSet<JobLevel> JobLevels { get; set; }
		public DbSet<JobType> JobTypes { get; set; }
		public DbSet<Company> Companys { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Job> Jobs { get; set; }


        public DbSet<JobSeeker> JobSeekers { get; set; }

        // Seed data skill table 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skill>().HasData(
                new Skill { Id = 1, Name = "HTML", Status = true },
                new Skill { Id = 2, Name = "CSS", Status = true },
                new Skill { Id = 3, Name = "Javascript", Status = true },
                new Skill { Id = 4, Name = "Reactjs", Status = true },
                new Skill { Id = 5, Name = "MongoDB", Status = true }
            );


            modelBuilder.Entity<JobLevel>().HasData(
                new JobLevel { Id = 1, Name = "Intern", Status = true },
                new JobLevel { Id = 2, Name = "Fresher", Status = true },
                new JobLevel { Id = 3, Name = "Junior", Status = true },
                new JobLevel { Id = 4, Name = "Middle", Status = true }
            );

			modelBuilder.Entity<Company>().HasData(
				new Company
				{
					Id = 1,
					Name = "Tech Innovators",
					Industry = "Technology",
					Description = "Leading company in tech innovations and AI solutions.",
					Logo = "",
					Website = "https://www.techinnovators.com",
					Email = "contact@techinnovators.com",
					Phone = "123-456-7890",
					Create = DateTime.Now.AddYears(-2),
					Update = DateTime.Now,
					Status = true
				},
				new Company
				{
					Id = 2,
					Name = "Green Earth Co.",
					Industry = "Environmental",
					Description = "Sustainable solutions for a greener future.",
					Logo = "",
					Website = "https://www.greenearth.com",
					Email = "info@greenearth.com",
					Phone = "987-654-3210",
					Create = DateTime.Now.AddYears(-3),
					Update = DateTime.Now,
					Status = true
				},
				new Company
				{
					Id = 3,
					Name = "HealthFirst Inc.",
					Industry = "Healthcare",
					Description = "Providing innovative healthcare solutions worldwide.",
					Logo = "",
					Website = "https://www.healthfirst.com",
					Email = "support@healthfirst.com",
					Phone = "555-678-1234",
					Create = DateTime.Now.AddYears(-5),
					Update = DateTime.Now,
					Status = true
				},
				new Company
				{
					Id = 4,
					Name = "Global Ventures",
					Industry = "Investment",
					Description = "Investing in future leaders and breakthrough industries.",
					Logo = "",
					Website = "https://www.globalventures.com",
					Email = "contact@globalventures.com",
					Phone = "321-987-6543",
					Create = DateTime.Now.AddYears(-1),
					Update = DateTime.Now,
					Status = true
				},
				new Company
				{
					Id = 5,
					Name = "Future Energy Corp",
					Industry = "Energy",
					Description = "Developing renewable energy solutions for the future.",
					Logo = "",
					Website = "https://www.futureenergy.com",
					Email = "support@futureenergy.com",
					Phone = "222-333-4444",
					Create = DateTime.Now.AddYears(-4),
					Update = DateTime.Now,
					Status = true
				},
				new Company
				{
					Id = 6,
					Name = "EduTech Solutions",
					Industry = "Education",
					Description = "Bringing technology into the classroom to transform learning.",
					Logo = "",
					Website = "https://www.edutech.com",
					Email = "info@edutech.com",
					Phone = "999-888-7777",
					Create = DateTime.Now.AddYears(-6),
					Update = DateTime.Now,
					Status = true
				}
			);

            modelBuilder.Entity<JobSeeker>().HasData(
                new JobSeeker { Id = 1, UserName = "QuangHa", Password = "quangha1", Email = "quangha@gmail.com", FullName = "Nguyen Quang Ha", Phone = "0354156978", Create_at = new DateTime(2024, 10, 2), Update_at = new DateTime(2024, 10, 4), Status = true },
                new JobSeeker { Id = 2, UserName = "DuyCuu", Password = "duycuu1", Email = "duycuu@gmail.com", FullName = "Phan Duy Cuu", Phone = "0356786989", Create_at = new DateTime(2024, 10, 2), Update_at = new DateTime(2024, 10, 4), Status = true },
                new JobSeeker { Id = 3, UserName = "GiaQuy", Password = "giaquy1", Email = "giaquy@gmail.com", FullName = "Quach Gia Quy", Phone = "0354153324", Create_at = new DateTime(2024, 10, 2), Update_at = new DateTime(2024, 10, 4), Status = true },
                new JobSeeker { Id = 4, UserName = "QuangTruong", Password = "quangtruong1", Email = "quangtruong@gmail.com", FullName = "Tran Quang Truong", Phone = "0357564421", Create_at = new DateTime(2024, 10, 2), Update_at = new DateTime(2024, 10, 4), Status = true },
                new JobSeeker { Id = 5, UserName = "ThienPhuc", Password = "thienphuc1", Email = "thienphuc@gmail.com", FullName = "Le Thien Phuc", Phone = "0357531486", Create_at = new DateTime(2024, 10, 2), Update_at = new DateTime(2024, 10, 4), Status = true }
            );
           
            modelBuilder.Entity<Employer>().HasData(
                new Employer
                {
                    Id = 1,
                    Username = "phanduycuu",
                    Password = "123456789Aa",
                    Email = "contact@techinnovators.com",
                    CompanyId = 3,
                    Fullname = "Phan Duy Cuu",
					Location= "Bac ruong",
                    Create = DateTime.Now.AddYears(-2),
                    Update = DateTime.Now,
                    Status = true
                }

            );


        }
	}

}
