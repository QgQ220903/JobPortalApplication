using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobPortalApplication.Migrations
{
    /// <inheritdoc />
    public partial class addjob : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Requirements = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Benefits = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    Create = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Update = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Expired = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmployerId = table.Column<int>(type: "int", nullable: false),
                    JobLevelId = table.Column<int>(type: "int", nullable: false),
                    JobTypeId = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jobs_Employers_EmployerId",
                        column: x => x.EmployerId,
                        principalTable: "Employers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jobs_JobLevels_JobLevelId",
                        column: x => x.JobLevelId,
                        principalTable: "JobLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jobs_JobTypes_JobTypeId",
                        column: x => x.JobTypeId,
                        principalTable: "JobTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2022, 10, 10, 10, 20, 48, 409, DateTimeKind.Local).AddTicks(4926), new DateTime(2024, 10, 10, 10, 20, 48, 409, DateTimeKind.Local).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2021, 10, 10, 10, 20, 48, 409, DateTimeKind.Local).AddTicks(4949), new DateTime(2024, 10, 10, 10, 20, 48, 409, DateTimeKind.Local).AddTicks(4950) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2019, 10, 10, 10, 20, 48, 409, DateTimeKind.Local).AddTicks(4952), new DateTime(2024, 10, 10, 10, 20, 48, 409, DateTimeKind.Local).AddTicks(4953) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2023, 10, 10, 10, 20, 48, 409, DateTimeKind.Local).AddTicks(4954), new DateTime(2024, 10, 10, 10, 20, 48, 409, DateTimeKind.Local).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2020, 10, 10, 10, 20, 48, 409, DateTimeKind.Local).AddTicks(4956), new DateTime(2024, 10, 10, 10, 20, 48, 409, DateTimeKind.Local).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2018, 10, 10, 10, 20, 48, 409, DateTimeKind.Local).AddTicks(4959), new DateTime(2024, 10, 10, 10, 20, 48, 409, DateTimeKind.Local).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2022, 10, 10, 10, 20, 48, 409, DateTimeKind.Local).AddTicks(5012), new DateTime(2024, 10, 10, 10, 20, 48, 409, DateTimeKind.Local).AddTicks(5014) });

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_EmployerId",
                table: "Jobs",
                column: "EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_JobLevelId",
                table: "Jobs",
                column: "JobLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_JobTypeId",
                table: "Jobs",
                column: "JobTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2022, 10, 9, 19, 15, 12, 952, DateTimeKind.Local).AddTicks(7471), new DateTime(2024, 10, 9, 19, 15, 12, 952, DateTimeKind.Local).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2021, 10, 9, 19, 15, 12, 952, DateTimeKind.Local).AddTicks(7495), new DateTime(2024, 10, 9, 19, 15, 12, 952, DateTimeKind.Local).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2019, 10, 9, 19, 15, 12, 952, DateTimeKind.Local).AddTicks(7498), new DateTime(2024, 10, 9, 19, 15, 12, 952, DateTimeKind.Local).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2023, 10, 9, 19, 15, 12, 952, DateTimeKind.Local).AddTicks(7500), new DateTime(2024, 10, 9, 19, 15, 12, 952, DateTimeKind.Local).AddTicks(7501) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2020, 10, 9, 19, 15, 12, 952, DateTimeKind.Local).AddTicks(7503), new DateTime(2024, 10, 9, 19, 15, 12, 952, DateTimeKind.Local).AddTicks(7504) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2018, 10, 9, 19, 15, 12, 952, DateTimeKind.Local).AddTicks(7506), new DateTime(2024, 10, 9, 19, 15, 12, 952, DateTimeKind.Local).AddTicks(7507) });

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2022, 10, 9, 19, 15, 12, 952, DateTimeKind.Local).AddTicks(7566), new DateTime(2024, 10, 9, 19, 15, 12, 952, DateTimeKind.Local).AddTicks(7568) });
        }
    }
}
