using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobPortalApplication.Migrations
{
    /// <inheritdoc />
    public partial class CreateJobTableAndSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2022, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7731), new DateTime(2024, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2021, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7751), new DateTime(2024, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2019, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7753), new DateTime(2024, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2023, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7756), new DateTime(2024, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2020, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7759), new DateTime(2024, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2018, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7766), new DateTime(2024, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2022, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7817), new DateTime(2024, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateOn", "ExpiredDate" },
                values: new object[] { new DateTime(2024, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7841), new DateTime(2025, 1, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateOn", "ExpiredDate" },
                values: new object[] { new DateTime(2024, 10, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7845), new DateTime(2025, 3, 22, 21, 57, 55, 872, DateTimeKind.Local).AddTicks(7844) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2022, 10, 22, 16, 43, 57, 994, DateTimeKind.Local).AddTicks(5888), new DateTime(2024, 10, 22, 16, 43, 57, 994, DateTimeKind.Local).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2021, 10, 22, 16, 43, 57, 994, DateTimeKind.Local).AddTicks(5910), new DateTime(2024, 10, 22, 16, 43, 57, 994, DateTimeKind.Local).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2019, 10, 22, 16, 43, 57, 994, DateTimeKind.Local).AddTicks(5914), new DateTime(2024, 10, 22, 16, 43, 57, 994, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2023, 10, 22, 16, 43, 57, 994, DateTimeKind.Local).AddTicks(5918), new DateTime(2024, 10, 22, 16, 43, 57, 994, DateTimeKind.Local).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2020, 10, 22, 16, 43, 57, 994, DateTimeKind.Local).AddTicks(5922), new DateTime(2024, 10, 22, 16, 43, 57, 994, DateTimeKind.Local).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2018, 10, 22, 16, 43, 57, 994, DateTimeKind.Local).AddTicks(5928), new DateTime(2024, 10, 22, 16, 43, 57, 994, DateTimeKind.Local).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2022, 10, 22, 16, 43, 57, 994, DateTimeKind.Local).AddTicks(6065), new DateTime(2024, 10, 22, 16, 43, 57, 994, DateTimeKind.Local).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateOn", "ExpiredDate" },
                values: new object[] { new DateTime(2024, 10, 22, 16, 43, 57, 994, DateTimeKind.Local).AddTicks(6102), new DateTime(2025, 1, 22, 16, 43, 57, 994, DateTimeKind.Local).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateOn", "ExpiredDate" },
                values: new object[] { new DateTime(2024, 10, 22, 16, 43, 57, 994, DateTimeKind.Local).AddTicks(6108), new DateTime(2025, 3, 22, 16, 43, 57, 994, DateTimeKind.Local).AddTicks(6107) });
        }
    }
}
