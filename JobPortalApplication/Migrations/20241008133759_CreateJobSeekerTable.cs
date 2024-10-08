using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobPortalApplication.Migrations
{
    /// <inheritdoc />
    public partial class CreateJobSeekerTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobSeekers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Create_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Update_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSeekers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "JobSeekers",
                columns: new[] { "Id", "Create_at", "Email", "FullName", "Password", "Phone", "Status", "Update_at", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "quangha@gmail.com", "Nguyen Quang Ha", "quangha1", "0354156978", true, new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "QuangHa" },
                    { 2, new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "duycuu@gmail.com", "Phan Duy Cuu", "duycuu1", "0356786989", true, new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "DuyCuu" },
                    { 3, new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "giaquy@gmail.com", "Quach Gia Quy", "giaquy1", "0354153324", true, new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "GiaQuy" },
                    { 4, new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "quangtruong@gmail.com", "Tran Quang Truong", "quangtruong1", "0357564421", true, new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "QuangTruong" },
                    { 5, new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "thienphuc@gmail.com", "Le Thien Phuc", "thienphuc1", "0357531486", true, new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "ThienPhuc" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobSeekers");
        }
    }
}
