using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobPortalApplication.Migrations
{
    /// <inheritdoc />
    public partial class createCompanyTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Industry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Create = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Update = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companys", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Companys",
                columns: new[] { "Id", "Create", "Description", "Email", "Industry", "Logo", "Name", "Phone", "Status", "Update", "Website" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 29, 20, 54, 57, 492, DateTimeKind.Local).AddTicks(5422), "Leading company in tech innovations and AI solutions.", "contact@techinnovators.com", "Technology", "", "Tech Innovators", "123-456-7890", true, new DateTime(2024, 9, 29, 20, 54, 57, 492, DateTimeKind.Local).AddTicks(5450), "https://www.techinnovators.com" },
                    { 2, new DateTime(2021, 9, 29, 20, 54, 57, 492, DateTimeKind.Local).AddTicks(5452), "Sustainable solutions for a greener future.", "info@greenearth.com", "Environmental", "", "Green Earth Co.", "987-654-3210", true, new DateTime(2024, 9, 29, 20, 54, 57, 492, DateTimeKind.Local).AddTicks(5453), "https://www.greenearth.com" },
                    { 3, new DateTime(2019, 9, 29, 20, 54, 57, 492, DateTimeKind.Local).AddTicks(5489), "Providing innovative healthcare solutions worldwide.", "support@healthfirst.com", "Healthcare", "", "HealthFirst Inc.", "555-678-1234", true, new DateTime(2024, 9, 29, 20, 54, 57, 492, DateTimeKind.Local).AddTicks(5490), "https://www.healthfirst.com" },
                    { 4, new DateTime(2023, 9, 29, 20, 54, 57, 492, DateTimeKind.Local).AddTicks(5492), "Investing in future leaders and breakthrough industries.", "contact@globalventures.com", "Investment", "", "Global Ventures", "321-987-6543", true, new DateTime(2024, 9, 29, 20, 54, 57, 492, DateTimeKind.Local).AddTicks(5492), "https://www.globalventures.com" },
                    { 5, new DateTime(2020, 9, 29, 20, 54, 57, 492, DateTimeKind.Local).AddTicks(5494), "Developing renewable energy solutions for the future.", "support@futureenergy.com", "Energy", "", "Future Energy Corp", "222-333-4444", true, new DateTime(2024, 9, 29, 20, 54, 57, 492, DateTimeKind.Local).AddTicks(5497), "https://www.futureenergy.com" },
                    { 6, new DateTime(2018, 9, 29, 20, 54, 57, 492, DateTimeKind.Local).AddTicks(5499), "Bringing technology into the classroom to transform learning.", "info@edutech.com", "Education", "", "EduTech Solutions", "999-888-7777", true, new DateTime(2024, 9, 29, 20, 54, 57, 492, DateTimeKind.Local).AddTicks(5500), "https://www.edutech.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companys");
        }
    }
}
