﻿// <auto-generated />
using System;
using JobPortalApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JobPortalApplication.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Create = new DateTime(2022, 10, 10, 10, 20, 48, 409, DateTimeKind.Local).AddTicks(4926),
                            Description = "Leading company in tech innovations and AI solutions.",
                            Email = "contact@techinnovators.com",
                            Industry = "Technology",
                            Logo = "",
                            Name = "Tech Innovators",
                            Phone = "123-456-7890",
                            Status = true,
                            Update = new DateTime(2024, 10, 10, 10, 20, 48, 409, DateTimeKind.Local).AddTicks(4942),
                            Website = "https://www.techinnovators.com"
                        },
                        new
                        {
                            Id = 2,
                            Create = new DateTime(2021, 10, 10, 10, 20, 48, 409, DateTimeKind.Local).AddTicks(4949),
                            Description = "Sustainable solutions for a greener future.",
                            Email = "info@greenearth.com",
                            Industry = "Environmental",
                            Logo = "",
                            Name = "Green Earth Co.",
                            Phone = "987-654-3210",
                            Status = true,
                            Update = new DateTime(2024, 10, 10, 10, 20, 48, 409, DateTimeKind.Local).AddTicks(4950),
                            Website = "https://www.greenearth.com"
                        },
                        new
                        {
                            Id = 3,
                            Create = new DateTime(2019, 10, 10, 10, 20, 48, 409, DateTimeKind.Local).AddTicks(4952),
                            Description = "Providing innovative healthcare solutions worldwide.",
                            Email = "support@healthfirst.com",
                            Industry = "Healthcare",
                            Logo = "",
                            Name = "HealthFirst Inc.",
                            Phone = "555-678-1234",
                            Status = true,
                            Update = new DateTime(2024, 10, 10, 10, 20, 48, 409, DateTimeKind.Local).AddTicks(4953),
                            Website = "https://www.healthfirst.com"
                        },
                        new
                        {
                            Id = 4,
                            Create = new DateTime(2023, 10, 10, 10, 20, 48, 409, DateTimeKind.Local).AddTicks(4954),
                            Description = "Investing in future leaders and breakthrough industries.",
                            Email = "contact@globalventures.com",
                            Industry = "Investment",
                            Logo = "",
                            Name = "Global Ventures",
                            Phone = "321-987-6543",
                            Status = true,
                            Update = new DateTime(2024, 10, 10, 10, 20, 48, 409, DateTimeKind.Local).AddTicks(4955),
                            Website = "https://www.globalventures.com"
                        },
                        new
                        {
                            Id = 5,
                            Create = new DateTime(2020, 10, 10, 10, 20, 48, 409, DateTimeKind.Local).AddTicks(4956),
                            Description = "Developing renewable energy solutions for the future.",
                            Email = "support@futureenergy.com",
                            Industry = "Energy",
                            Logo = "",
                            Name = "Future Energy Corp",
                            Phone = "222-333-4444",
                            Status = true,
                            Update = new DateTime(2024, 10, 10, 10, 20, 48, 409, DateTimeKind.Local).AddTicks(4958),
                            Website = "https://www.futureenergy.com"
                        },
                        new
                        {
                            Id = 6,
                            Create = new DateTime(2018, 10, 10, 10, 20, 48, 409, DateTimeKind.Local).AddTicks(4959),
                            Description = "Bringing technology into the classroom to transform learning.",
                            Email = "info@edutech.com",
                            Industry = "Education",
                            Logo = "",
                            Name = "EduTech Solutions",
                            Phone = "999-888-7777",
                            Status = true,
                            Update = new DateTime(2024, 10, 10, 10, 20, 48, 409, DateTimeKind.Local).AddTicks(4960),
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
                            Create = new DateTime(2022, 10, 10, 10, 20, 48, 409, DateTimeKind.Local).AddTicks(5012),
                            Email = "contact@techinnovators.com",
                            Fullname = "Phan Duy Cuu",
                            Location = "Bac ruong",
                            Password = "123456789Aa",
                            Status = true,
                            Update = new DateTime(2024, 10, 10, 10, 20, 48, 409, DateTimeKind.Local).AddTicks(5014),
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

                    b.Property<DateTime>("Create")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Expired")
                        .HasColumnType("datetime2");

                    b.Property<int>("JobLevelId")
                        .HasColumnType("int");

                    b.Property<int>("JobTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Requirements")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Update")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EmployerId");

                    b.HasIndex("JobLevelId");

                    b.HasIndex("JobTypeId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("JobPortalApplication.Models.JobLevel", b =>
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

                    b.ToTable("JobLevels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Intern",
                            Status = true
                        },
                        new
                        {
                            Id = 2,
                            Name = "Fresher",
                            Status = true
                        },
                        new
                        {
                            Id = 3,
                            Name = "Junior",
                            Status = true
                        },
                        new
                        {
                            Id = 4,
                            Name = "Middle",
                            Status = true
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

            modelBuilder.Entity("JobPortalApplication.Models.JobType", b =>
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

                    b.ToTable("JobTypes");
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

                    b.HasOne("JobPortalApplication.Models.JobLevel", "JobLevel")
                        .WithMany()
                        .HasForeignKey("JobLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobPortalApplication.Models.JobType", "JobType")
                        .WithMany()
                        .HasForeignKey("JobTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employer");

                    b.Navigation("JobLevel");

                    b.Navigation("JobType");
                });
#pragma warning restore 612, 618
        }
    }
}
