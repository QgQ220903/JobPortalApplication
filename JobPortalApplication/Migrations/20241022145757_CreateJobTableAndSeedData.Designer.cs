﻿// <auto-generated />
using System;
using JobPortalApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JobPortalApplication.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241022145757_CreateJobTableAndSeedData")]
    partial class CreateJobTableAndSeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JobPortalApplication.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Create")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Industry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Update")
                        .HasColumnType("datetime2");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companys");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Create = new DateTime(2022, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7731),
                            Description = "Leading company in tech innovations and AI solutions.",
                            Email = "contact@techinnovators.com",
                            Industry = "Technology",
                            Logo = "",
                            Name = "Tech Innovators",
                            Phone = "123-456-7890",
                            Status = true,
                            Update = new DateTime(2024, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7747),
                            Website = "https://www.techinnovators.com"
                        },
                        new
                        {
                            Id = 2,
                            Create = new DateTime(2021, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7751),
                            Description = "Sustainable solutions for a greener future.",
                            Email = "info@greenearth.com",
                            Industry = "Environmental",
                            Logo = "",
                            Name = "Green Earth Co.",
                            Phone = "987-654-3210",
                            Status = true,
                            Update = new DateTime(2024, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7752),
                            Website = "https://www.greenearth.com"
                        },
                        new
                        {
                            Id = 3,
                            Create = new DateTime(2019, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7753),
                            Description = "Providing innovative healthcare solutions worldwide.",
                            Email = "support@healthfirst.com",
                            Industry = "Healthcare",
                            Logo = "",
                            Name = "HealthFirst Inc.",
                            Phone = "555-678-1234",
                            Status = true,
                            Update = new DateTime(2024, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7754),
                            Website = "https://www.healthfirst.com"
                        },
                        new
                        {
                            Id = 4,
                            Create = new DateTime(2023, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7756),
                            Description = "Investing in future leaders and breakthrough industries.",
                            Email = "contact@globalventures.com",
                            Industry = "Investment",
                            Logo = "",
                            Name = "Global Ventures",
                            Phone = "321-987-6543",
                            Status = true,
                            Update = new DateTime(2024, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7757),
                            Website = "https://www.globalventures.com"
                        },
                        new
                        {
                            Id = 5,
                            Create = new DateTime(2020, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7759),
                            Description = "Developing renewable energy solutions for the future.",
                            Email = "support@futureenergy.com",
                            Industry = "Energy",
                            Logo = "",
                            Name = "Future Energy Corp",
                            Phone = "222-333-4444",
                            Status = true,
                            Update = new DateTime(2024, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7764),
                            Website = "https://www.futureenergy.com"
                        },
                        new
                        {
                            Id = 6,
                            Create = new DateTime(2018, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7766),
                            Description = "Bringing technology into the classroom to transform learning.",
                            Email = "info@edutech.com",
                            Industry = "Education",
                            Logo = "",
                            Name = "EduTech Solutions",
                            Phone = "999-888-7777",
                            Status = true,
                            Update = new DateTime(2024, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7767),
                            Website = "https://www.edutech.com"
                        });
                });

            modelBuilder.Entity("JobPortalApplication.Models.Employer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Create")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Update")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Employers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyId = 3,
                            Create = new DateTime(2022, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7817),
                            Email = "contact@techinnovators.com",
                            Fullname = "Phan Duy Cuu",
                            Location = "Bac ruong",
                            Password = "123456789Aa",
                            Status = true,
                            Update = new DateTime(2024, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7818),
                            Username = "phanduycuu"
                        });
                });

            modelBuilder.Entity("JobPortalApplication.Models.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Benefits")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ExpiredDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFeature")
                        .HasColumnType("bit");

                    b.Property<bool>("IsHot")
                        .HasColumnType("bit");

                    b.Property<int>("JobLevel")
                        .HasColumnType("int");

                    b.Property<int>("JobStatus")
                        .HasColumnType("int");

                    b.Property<int>("JobType")
                        .HasColumnType("int");

                    b.Property<string>("Requirements")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EmployerId");

                    b.ToTable("Jobs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Benefits = "BHXH & Bảo hiểm khác/Social Insurance & Other InsurancesDu lịch/ TravelThưởng/ BonusHuấn luyện đào tạo/TrainningChăm sóc sức khỏe/ Health careChính sách review lương/Annual Salary ReviewPhép năm/Annual LeaveTừ thứ hai đến thứ sáu: 8:30 – 17:30/ From Monday to Friday: 08:30am – 05:30pm",
                            CreateOn = new DateTime(2024, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7841),
                            Description = "Analyze system requirements from business departments.Tìm hiểu, phân tích yêu cầu hệ thống từ các phòng ban nghiệp vụ.Analyze, design necessary services based on business requirements to ensure compliance with the system development procedure. with the insurance business regulation, and the company's compliance.Phân tích, thiết kế các dịch vụ cần thiết dựa trên các yêu cầu nghiệp vụ đảm bảo tuân thủ quy định của quy trình phát triển ứng dụng. quy định của nghiệp vụ bảo hiểm, và tuân thủ quy định của công ty.   Analyze data, design and develop reports to meet business requirements.Phân tích dữ liệu, thiết kế và phát triển các báo cáo đáp ứng yêu cầu nghiệp vụ.Maintain and develop the functions of the application system according to the assigned modules.Bảo trì, phát triển các chức năng của hệ thống ứng dụng theo yêu cầu nghiệp vụ được giao.Administrate, operate the company's applications in accordance with the company's SOP.Quản trị, vận hành các ứng dụng của công ty theo đúng quy trình và tiêu chuẩn của công ty",
                            EmployerId = 1,
                            ExpiredDate = new DateTime(2025, 1, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7838),
                            IsDeleted = false,
                            IsFeature = false,
                            IsHot = true,
                            JobLevel = 0,
                            JobStatus = 1,
                            JobType = 0,
                            Requirements = "Graduated College / Bachelor degree major ITTốt nghiệp Cao Đẳng/ Đại học chuyên ngành liên quanAble to use English or Chinese in working (prefer)Có khả năng sử dụng Tiếng Anh hoặc Tiếng Trung trong công việc (ưu tiên)Knowledge about Java, JavaScript, Java Swing. Hiểu biết về Java, JavaScript, Java Swing.",
                            Salary = 0.0,
                            Title = "Fresher Java Developer (English/Chinese)"
                        },
                        new
                        {
                            Id = 2,
                            Benefits = "BHXH & Bảo hiểm khác/Social Insurance & Other InsurancesDu lịch/ TravelThưởng/ BonusHuấn luyện đào tạo/TrainningChăm sóc sức khỏe/ Health careChính sách review lương/Annual Salary ReviewPhép năm/Annual LeaveTừ thứ hai đến thứ sáu: 8:30 – 17:30/ From Monday to Friday: 08:30am – 05:30pm",
                            CreateOn = new DateTime(2024, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7845),
                            Description = "ONE OF THE TOP ICT JAPANESE COMPANIES IN VIETNAM.NEC Corp is a leader in the integration of IT and network technologies that benefit businesses and people around the world. NEC has more than 50 countries, 289 branches, and 117,418 employees worldwide. Under the company's corporate message of Orchestrating a brighter world,NEC aims to help solve a wide range of challenging issues and to create new social value for the changing world of tomorrow.Established in 2006, up to now, NEC Vietnam has grown with more than 200 employees in Hanoi and Ho Chi Minh City. We have been working hard to carry out many social contribution activities to bring more laughter and improve the quality of life.",
                            EmployerId = 2,
                            ExpiredDate = new DateTime(2025, 3, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7844),
                            IsDeleted = false,
                            IsFeature = false,
                            IsHot = true,
                            JobLevel = 4,
                            JobStatus = 0,
                            JobType = 0,
                            Requirements = "Graduated College / Bachelor degree major ITTốt nghiệp Cao Đẳng/ Đại học chuyên ngành liên quanAble to use English or Chinese in working (prefer)Có khả năng sử dụng Tiếng Anh hoặc Tiếng Trung trong công việc (ưu tiên)Knowledge about Java, JavaScript, Java Swing. Hiểu biết về Java, JavaScript, Java Swing.",
                            Salary = 0.0,
                            Title = "Project Leader (BrSE, Sign-on Bonus)"
                        });
                });

            modelBuilder.Entity("JobPortalApplication.Models.JobSeeker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Create_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Update_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JobSeekers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Create_at = new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "quangha@gmail.com",
                            FullName = "Nguyen Quang Ha",
                            Password = "quangha1",
                            Phone = "0354156978",
                            Status = true,
                            Update_at = new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "QuangHa"
                        },
                        new
                        {
                            Id = 2,
                            Create_at = new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "duycuu@gmail.com",
                            FullName = "Phan Duy Cuu",
                            Password = "duycuu1",
                            Phone = "0356786989",
                            Status = true,
                            Update_at = new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "DuyCuu"
                        },
                        new
                        {
                            Id = 3,
                            Create_at = new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "giaquy@gmail.com",
                            FullName = "Quach Gia Quy",
                            Password = "giaquy1",
                            Phone = "0354153324",
                            Status = true,
                            Update_at = new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "GiaQuy"
                        },
                        new
                        {
                            Id = 4,
                            Create_at = new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "quangtruong@gmail.com",
                            FullName = "Tran Quang Truong",
                            Password = "quangtruong1",
                            Phone = "0357564421",
                            Status = true,
                            Update_at = new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "QuangTruong"
                        },
                        new
                        {
                            Id = 5,
                            Create_at = new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "thienphuc@gmail.com",
                            FullName = "Le Thien Phuc",
                            Password = "thienphuc1",
                            Phone = "0357531486",
                            Status = true,
                            Update_at = new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "ThienPhuc"
                        });
                });

            modelBuilder.Entity("JobPortalApplication.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "HTML",
                            Status = true
                        },
                        new
                        {
                            Id = 2,
                            Name = "CSS",
                            Status = true
                        },
                        new
                        {
                            Id = 3,
                            Name = "Javascript",
                            Status = true
                        },
                        new
                        {
                            Id = 4,
                            Name = "Reactjs",
                            Status = true
                        },
                        new
                        {
                            Id = 5,
                            Name = "MongoDB",
                            Status = true
                        });
                });

            modelBuilder.Entity("JobPortalApplication.Models.Employer", b =>
                {
                    b.HasOne("JobPortalApplication.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("JobPortalApplication.Models.Job", b =>
                {
                    b.HasOne("JobPortalApplication.Models.Employer", "Employer")
                        .WithMany()
                        .HasForeignKey("EmployerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employer");
                });
#pragma warning restore 612, 618
        }
    }
}