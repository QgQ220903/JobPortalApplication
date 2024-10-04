using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobPortalApplication.Migrations
{
    /// <inheritdoc />
    public partial class addEmployer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employers_Companys_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2022, 10, 4, 9, 15, 12, 943, DateTimeKind.Local).AddTicks(1226), new DateTime(2024, 10, 4, 9, 15, 12, 943, DateTimeKind.Local).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2021, 10, 4, 9, 15, 12, 943, DateTimeKind.Local).AddTicks(1250), new DateTime(2024, 10, 4, 9, 15, 12, 943, DateTimeKind.Local).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2019, 10, 4, 9, 15, 12, 943, DateTimeKind.Local).AddTicks(1252), new DateTime(2024, 10, 4, 9, 15, 12, 943, DateTimeKind.Local).AddTicks(1253) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2023, 10, 4, 9, 15, 12, 943, DateTimeKind.Local).AddTicks(1255), new DateTime(2024, 10, 4, 9, 15, 12, 943, DateTimeKind.Local).AddTicks(1255) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2020, 10, 4, 9, 15, 12, 943, DateTimeKind.Local).AddTicks(1257), new DateTime(2024, 10, 4, 9, 15, 12, 943, DateTimeKind.Local).AddTicks(1258) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2018, 10, 4, 9, 15, 12, 943, DateTimeKind.Local).AddTicks(1260), new DateTime(2024, 10, 4, 9, 15, 12, 943, DateTimeKind.Local).AddTicks(1260) });

            migrationBuilder.CreateIndex(
                name: "IX_Employers_CompanyId",
                table: "Employers",
                column: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employers");

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2022, 9, 30, 23, 8, 48, 702, DateTimeKind.Local).AddTicks(3354), new DateTime(2024, 9, 30, 23, 8, 48, 702, DateTimeKind.Local).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2021, 9, 30, 23, 8, 48, 702, DateTimeKind.Local).AddTicks(3382), new DateTime(2024, 9, 30, 23, 8, 48, 702, DateTimeKind.Local).AddTicks(3383) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2019, 9, 30, 23, 8, 48, 702, DateTimeKind.Local).AddTicks(3385), new DateTime(2024, 9, 30, 23, 8, 48, 702, DateTimeKind.Local).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2023, 9, 30, 23, 8, 48, 702, DateTimeKind.Local).AddTicks(3387), new DateTime(2024, 9, 30, 23, 8, 48, 702, DateTimeKind.Local).AddTicks(3388) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2020, 9, 30, 23, 8, 48, 702, DateTimeKind.Local).AddTicks(3389), new DateTime(2024, 9, 30, 23, 8, 48, 702, DateTimeKind.Local).AddTicks(3391) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2018, 9, 30, 23, 8, 48, 702, DateTimeKind.Local).AddTicks(3393), new DateTime(2024, 9, 30, 23, 8, 48, 702, DateTimeKind.Local).AddTicks(3393) });
        }
    }
}
