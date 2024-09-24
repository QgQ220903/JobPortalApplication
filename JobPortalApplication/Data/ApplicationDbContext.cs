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
        }
    }
}
