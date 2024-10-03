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

            modelBuilder.Entity<JobSeeker>().HasData(
                new JobSeeker { Id = 1, UserName = "QuangHa",Password = "quangha1",Email = "quangha@gmail.com",FullName = "Nguyen Quang Ha",Phone = "0354156978",Create_at = new DateTime(2024, 10, 2),Update_at = new DateTime(2024, 10, 4) },
                new JobSeeker { Id = 2, UserName = "DuyCuu", Password = "duycuu1", Email = "duycuu@gmail.com", FullName = "Phan Duy Cuu", Phone = "0356786989", Create_at = new DateTime(2024, 10, 2), Update_at = new DateTime(2024, 10, 4) },
                new JobSeeker { Id = 3, UserName = "GiaQuy", Password = "giaquy1", Email = "giaquy@gmail.com", FullName = "Quach Gia Quy", Phone = "0354153324", Create_at = new DateTime(2024, 10, 2), Update_at = new DateTime(2024, 10, 4) },
                new JobSeeker { Id = 4, UserName = "QuangTruong", Password = "quangtruong1", Email = "quangtruong@gmail.com", FullName = "Tran Quang Truong", Phone = "0357564421", Create_at = new DateTime(2024, 10, 2), Update_at = new DateTime(2024, 10, 4) },
                new JobSeeker { Id = 5, UserName = "ThienPhuc", Password = "thienphuc1", Email = "thienphuc@gmail.com", FullName = "Le Thien Phuc", Phone = "0357531486", Create_at = new DateTime(2024, 10, 2), Update_at = new DateTime(2024, 10, 4) }
                );
        }
    }
}
