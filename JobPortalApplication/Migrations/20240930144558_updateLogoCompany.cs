using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobPortalApplication.Migrations
{
    /// <inheritdoc />
    public partial class updateLogoCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2022, 9, 30, 21, 45, 57, 299, DateTimeKind.Local).AddTicks(8635), new DateTime(2024, 9, 30, 21, 45, 57, 299, DateTimeKind.Local).AddTicks(8688) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2021, 9, 30, 21, 45, 57, 299, DateTimeKind.Local).AddTicks(8695), new DateTime(2024, 9, 30, 21, 45, 57, 299, DateTimeKind.Local).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2019, 9, 30, 21, 45, 57, 299, DateTimeKind.Local).AddTicks(8700), new DateTime(2024, 9, 30, 21, 45, 57, 299, DateTimeKind.Local).AddTicks(8701) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2023, 9, 30, 21, 45, 57, 299, DateTimeKind.Local).AddTicks(8704), new DateTime(2024, 9, 30, 21, 45, 57, 299, DateTimeKind.Local).AddTicks(8705) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2020, 9, 30, 21, 45, 57, 299, DateTimeKind.Local).AddTicks(8708), new DateTime(2024, 9, 30, 21, 45, 57, 299, DateTimeKind.Local).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2018, 9, 30, 21, 45, 57, 299, DateTimeKind.Local).AddTicks(8715), new DateTime(2024, 9, 30, 21, 45, 57, 299, DateTimeKind.Local).AddTicks(8716) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2022, 9, 29, 20, 54, 57, 492, DateTimeKind.Local).AddTicks(5422), new DateTime(2024, 9, 29, 20, 54, 57, 492, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2021, 9, 29, 20, 54, 57, 492, DateTimeKind.Local).AddTicks(5452), new DateTime(2024, 9, 29, 20, 54, 57, 492, DateTimeKind.Local).AddTicks(5453) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2019, 9, 29, 20, 54, 57, 492, DateTimeKind.Local).AddTicks(5489), new DateTime(2024, 9, 29, 20, 54, 57, 492, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2023, 9, 29, 20, 54, 57, 492, DateTimeKind.Local).AddTicks(5492), new DateTime(2024, 9, 29, 20, 54, 57, 492, DateTimeKind.Local).AddTicks(5492) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2020, 9, 29, 20, 54, 57, 492, DateTimeKind.Local).AddTicks(5494), new DateTime(2024, 9, 29, 20, 54, 57, 492, DateTimeKind.Local).AddTicks(5497) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2018, 9, 29, 20, 54, 57, 492, DateTimeKind.Local).AddTicks(5499), new DateTime(2024, 9, 29, 20, 54, 57, 492, DateTimeKind.Local).AddTicks(5500) });
        }
    }
}
