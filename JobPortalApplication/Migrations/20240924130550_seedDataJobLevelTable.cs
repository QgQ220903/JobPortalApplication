using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobPortalApplication.Migrations
{
    /// <inheritdoc />
    public partial class seedDataJobLevelTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "JobLevels",
                columns: new[] { "Id", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "Intern", true },
                    { 2, "Fresher", true },
                    { 3, "Junior", true },
                    { 4, "Middle", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JobLevels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JobLevels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "JobLevels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "JobLevels",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
