﻿// <auto-generated />
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
    [Migration("20240924130550_seedDataJobLevelTable")]
    partial class seedDataJobLevelTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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
#pragma warning restore 612, 618
        }
    }
}
