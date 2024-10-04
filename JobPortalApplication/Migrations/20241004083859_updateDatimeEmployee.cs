using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobPortalApplication.Migrations
{
    /// <inheritdoc />
    public partial class updateDatimeEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Update",
                table: "Employers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2022, 10, 4, 15, 38, 58, 604, DateTimeKind.Local).AddTicks(173), new DateTime(2024, 10, 4, 15, 38, 58, 604, DateTimeKind.Local).AddTicks(193) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2021, 10, 4, 15, 38, 58, 604, DateTimeKind.Local).AddTicks(196), new DateTime(2024, 10, 4, 15, 38, 58, 604, DateTimeKind.Local).AddTicks(197) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2019, 10, 4, 15, 38, 58, 604, DateTimeKind.Local).AddTicks(198), new DateTime(2024, 10, 4, 15, 38, 58, 604, DateTimeKind.Local).AddTicks(199) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2023, 10, 4, 15, 38, 58, 604, DateTimeKind.Local).AddTicks(201), new DateTime(2024, 10, 4, 15, 38, 58, 604, DateTimeKind.Local).AddTicks(201) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2020, 10, 4, 15, 38, 58, 604, DateTimeKind.Local).AddTicks(203), new DateTime(2024, 10, 4, 15, 38, 58, 604, DateTimeKind.Local).AddTicks(204) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2018, 10, 4, 15, 38, 58, 604, DateTimeKind.Local).AddTicks(205), new DateTime(2024, 10, 4, 15, 38, 58, 604, DateTimeKind.Local).AddTicks(206) });

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2022, 10, 4, 15, 38, 58, 604, DateTimeKind.Local).AddTicks(223), new DateTime(2024, 10, 4, 15, 38, 58, 604, DateTimeKind.Local).AddTicks(225) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Update",
                table: "Employers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2022, 10, 4, 10, 31, 30, 386, DateTimeKind.Local).AddTicks(607), new DateTime(2024, 10, 4, 10, 31, 30, 386, DateTimeKind.Local).AddTicks(629) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2021, 10, 4, 10, 31, 30, 386, DateTimeKind.Local).AddTicks(633), new DateTime(2024, 10, 4, 10, 31, 30, 386, DateTimeKind.Local).AddTicks(634) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2019, 10, 4, 10, 31, 30, 386, DateTimeKind.Local).AddTicks(636), new DateTime(2024, 10, 4, 10, 31, 30, 386, DateTimeKind.Local).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2023, 10, 4, 10, 31, 30, 386, DateTimeKind.Local).AddTicks(638), new DateTime(2024, 10, 4, 10, 31, 30, 386, DateTimeKind.Local).AddTicks(639) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2020, 10, 4, 10, 31, 30, 386, DateTimeKind.Local).AddTicks(641), new DateTime(2024, 10, 4, 10, 31, 30, 386, DateTimeKind.Local).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2018, 10, 4, 10, 31, 30, 386, DateTimeKind.Local).AddTicks(644), new DateTime(2024, 10, 4, 10, 31, 30, 386, DateTimeKind.Local).AddTicks(644) });

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2022, 10, 4, 10, 31, 30, 386, DateTimeKind.Local).AddTicks(664), new DateTime(2024, 10, 4, 10, 31, 30, 386, DateTimeKind.Local).AddTicks(665) });
        }
    }
}
