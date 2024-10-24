using JobPortalApplication.Models;
using JobPortalApplication.Models.Enum;
using JobPortalApplication.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace JobPortalApplication.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Skill> Skills { get; set; }
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
			modelBuilder.Entity<Job>().HasData(
				new Job
				{
					Id = 1,
					
					Title = "Fresher Java Developer (English/Chinese)",
					
					Description = "Analyze system requirements from business departments." +
					"Tìm hiểu, phân tích yêu cầu hệ thống từ các phòng ban nghiệp vụ." +
					"Analyze, design necessary services based on business requirements to ensure compliance with the system development procedure. with the insurance business regulation, and the company's compliance." +
					"Phân tích, thiết kế các dịch vụ cần thiết dựa trên các yêu cầu nghiệp vụ đảm bảo tuân thủ quy định của quy trình phát triển ứng dụng. quy định của nghiệp vụ bảo hiểm, và tuân thủ quy định của công ty." +
					"   Analyze data, design and develop reports to meet business requirements." +
					"Phân tích dữ liệu, thiết kế và phát triển các báo cáo đáp ứng yêu cầu nghiệp vụ." +
					"Maintain and develop the functions of the application system according to the assigned modules." +
					"Bảo trì, phát triển các chức năng của hệ thống ứng dụng theo yêu cầu nghiệp vụ được giao." +
					"Administrate, operate the company's applications in accordance with the company's SOP." +
					"Quản trị, vận hành các ứng dụng của công ty theo đúng quy trình và tiêu chuẩn của công ty",
					
					Requirements = "Graduated College / Bachelor degree major IT" +
					"Tốt nghiệp Cao Đẳng/ Đại học chuyên ngành liên quan" +
					"Able to use English or Chinese in working (prefer)" +
					"Có khả năng sử dụng Tiếng Anh hoặc Tiếng Trung trong công việc (ưu tiên)" +
					"Knowledge about Java, JavaScript, Java Swing. " +
					"Hiểu biết về Java, JavaScript, Java Swing.",

					Benefits = "BHXH & Bảo hiểm khác/Social Insurance & Other Insurances" +
					"Du lịch/ Travel" +
					"Thưởng/ Bonus" +
					"Huấn luyện đào tạo/Trainning" +
					"Chăm sóc sức khỏe/ Health care" +
					"Chính sách review lương/Annual Salary Review" +
					"Phép năm/Annual Leave" +
					"Từ thứ hai đến thứ sáu: 8:30 – 17:30/ From Monday to Friday: 08:30am – 05:30pm",

                    ExpiredDate = DateTime.Now.AddMonths(3),
                    CreateOn = DateTime.Now,
                    EmployerId = 1, // Replace with the actual employer ID
                    JobLevel = JobLevel.Intern,
                    JobType = JobType.InOffice,
                    JobStatus = JobStatus.Approved,
                    IsHot = true,
                    IsFeature = false,
                    IsDeleted = false
                },
				new Job
                {
					Id = 2,
					Title = "Project Leader (BrSE, Sign-on Bonus)",
					Description = "ONE OF THE TOP ICT JAPANESE COMPANIES IN VIETNAM." +
					"NEC Corp is a leader in the integration of IT and network technologies that benefit businesses and people around the world. " +
					"NEC has more than 50 countries, 289 branches, and 117,418 employees worldwide. Under the company's corporate message of " +
					"Orchestrating a brighter world," +
					"NEC aims to help solve a wide range of challenging issues and to create new social value for the changing world of tomorrow." +
					"Established in 2006, up to now, NEC Vietnam has grown with more than 200 employees in Hanoi and Ho Chi Minh City. We have been working hard to carry out many social contribution activities to bring more laughter and improve the quality of life.",
					Requirements = "Graduated College / Bachelor degree major IT" +
                    "Tốt nghiệp Cao Đẳng/ Đại học chuyên ngành liên quan" +
                    "Able to use English or Chinese in working (prefer)" +
                    "Có khả năng sử dụng Tiếng Anh hoặc Tiếng Trung trong công việc (ưu tiên)" +
                    "Knowledge about Java, JavaScript, Java Swing. " +
                    "Hiểu biết về Java, JavaScript, Java Swing.",
					Benefits = "BHXH & Bảo hiểm khác/Social Insurance & Other Insurances" +
                    "Du lịch/ Travel" +
                    "Thưởng/ Bonus" +
                    "Huấn luyện đào tạo/Trainning" +
                    "Chăm sóc sức khỏe/ Health care" +
                    "Chính sách review lương/Annual Salary Review" +
                    "Phép năm/Annual Leave" +
                    "Từ thứ hai đến thứ sáu: 8:30 – 17:30/ From Monday to Friday: 08:30am – 05:30pm",
                    ExpiredDate = DateTime.Now.AddMonths(5),
                    CreateOn = DateTime.Now,
                    EmployerId = 2, // Replace with the actual employer ID
                    JobLevel = JobLevel.Senior,
                    JobType = JobType.InOffice,
                    JobStatus = JobStatus.Pending,
                    IsHot = true,
                    IsFeature = false,
                    IsDeleted = false
                }
			);
        }
	}

}
