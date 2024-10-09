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
    [Migration("20241008143422_updateEmailEmployer")]
    partial class updateEmailEmployer
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
                            Create = new DateTime(2022, 10, 8, 21, 34, 21, 531, DateTimeKind.Local).AddTicks(3366),
                            Description = "Leading company in tech innovations and AI solutions.",
                            Email = "contact@techinnovators.com",
                            Industry = "Technology",
                            Logo = "",
                            Name = "Tech Innovators",
                            Phone = "123-456-7890",
                            Status = true,
                            Update = new DateTime(2024, 10, 8, 21, 34, 21, 531, DateTimeKind.Local).AddTicks(3381),
                            Website = "https://www.techinnovators.com"
                        },
                        new
                        {
                            Id = 2,
                            Create = new DateTime(2021, 10, 8, 21, 34, 21, 531, DateTimeKind.Local).AddTicks(3385),
                            Description = "Sustainable solutions for a greener future.",
                            Email = "info@greenearth.com",
                            Industry = "Environmental",
                            Logo = "",
                            Name = "Green Earth Co.",
                            Phone = "987-654-3210",
                            Status = true,
                            Update = new DateTime(2024, 10, 8, 21, 34, 21, 531, DateTimeKind.Local).AddTicks(3386),
                            Website = "https://www.greenearth.com"
                        },
                        new
                        {
                            Id = 3,
                            Create = new DateTime(2019, 10, 8, 21, 34, 21, 531, DateTimeKind.Local).AddTicks(3388),
                            Description = "Providing innovative healthcare solutions worldwide.",
                            Email = "support@healthfirst.com",
                            Industry = "Healthcare",
                            Logo = "",
                            Name = "HealthFirst Inc.",
                            Phone = "555-678-1234",
                            Status = true,
                            Update = new DateTime(2024, 10, 8, 21, 34, 21, 531, DateTimeKind.Local).AddTicks(3389),
                            Website = "https://www.healthfirst.com"
                        },
                        new
                        {
                            Id = 4,
                            Create = new DateTime(2023, 10, 8, 21, 34, 21, 531, DateTimeKind.Local).AddTicks(3390),
                            Description = "Investing in future leaders and breakthrough industries.",
                            Email = "contact@globalventures.com",
                            Industry = "Investment",
                            Logo = "",
                            Name = "Global Ventures",
                            Phone = "321-987-6543",
                            Status = true,
                            Update = new DateTime(2024, 10, 8, 21, 34, 21, 531, DateTimeKind.Local).AddTicks(3391),
                            Website = "https://www.globalventures.com"
                        },
                        new
                        {
                            Id = 5,
                            Create = new DateTime(2020, 10, 8, 21, 34, 21, 531, DateTimeKind.Local).AddTicks(3392),
                            Description = "Developing renewable energy solutions for the future.",
                            Email = "support@futureenergy.com",
                            Industry = "Energy",
                            Logo = "",
                            Name = "Future Energy Corp",
                            Phone = "222-333-4444",
                            Status = true,
                            Update = new DateTime(2024, 10, 8, 21, 34, 21, 531, DateTimeKind.Local).AddTicks(3394),
                            Website = "https://www.futureenergy.com"
                        },
                        new
                        {
                            Id = 6,
                            Create = new DateTime(2018, 10, 8, 21, 34, 21, 531, DateTimeKind.Local).AddTicks(3395),
                            Description = "Bringing technology into the classroom to transform learning.",
                            Email = "info@edutech.com",
                            Industry = "Education",
                            Logo = "",
                            Name = "EduTech Solutions",
                            Phone = "999-888-7777",
                            Status = true,
                            Update = new DateTime(2024, 10, 8, 21, 34, 21, 531, DateTimeKind.Local).AddTicks(3396),
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
                            Create = new DateTime(2022, 10, 8, 21, 34, 21, 531, DateTimeKind.Local).AddTicks(3413),
                            Email = "contact@techinnovators.com",
                            Fullname = "Phan Duy Cuu",
                            Location = "Bac ruong",
                            Password = "123456789Aa",
                            Status = true,
                            Update = new DateTime(2024, 10, 8, 21, 34, 21, 531, DateTimeKind.Local).AddTicks(3414),
                            Username = "phanduycuu"
                        });
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
#pragma warning restore 612, 618
        }
    }
}
