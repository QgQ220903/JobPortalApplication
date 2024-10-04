using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobPortalApplication.Migrations
{
    /// <inheritdoc />
    public partial class addDataEmployer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Employers",
                columns: new[] { "Id", "CompanyId", "Create", "Email", "Fullname", "Password", "Status", "Update", "Username" },
                values: new object[] { 1, 3, new DateTime(2022, 10, 4, 10, 31, 30, 386, DateTimeKind.Local).AddTicks(664), "contact@techinnovators.com", "Phan Duy Cuu", "123456789Aa", true, new DateTime(2024, 10, 4, 10, 31, 30, 386, DateTimeKind.Local).AddTicks(665), "phanduycuu" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2022, 10, 4, 10, 29, 10, 792, DateTimeKind.Local).AddTicks(9574), new DateTime(2024, 10, 4, 10, 29, 10, 792, DateTimeKind.Local).AddTicks(9595) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2021, 10, 4, 10, 29, 10, 792, DateTimeKind.Local).AddTicks(9601), new DateTime(2024, 10, 4, 10, 29, 10, 792, DateTimeKind.Local).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2019, 10, 4, 10, 29, 10, 792, DateTimeKind.Local).AddTicks(9643), new DateTime(2024, 10, 4, 10, 29, 10, 792, DateTimeKind.Local).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2023, 10, 4, 10, 29, 10, 792, DateTimeKind.Local).AddTicks(9646), new DateTime(2024, 10, 4, 10, 29, 10, 792, DateTimeKind.Local).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2020, 10, 4, 10, 29, 10, 792, DateTimeKind.Local).AddTicks(9648), new DateTime(2024, 10, 4, 10, 29, 10, 792, DateTimeKind.Local).AddTicks(9649) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2018, 10, 4, 10, 29, 10, 792, DateTimeKind.Local).AddTicks(9651), new DateTime(2024, 10, 4, 10, 29, 10, 792, DateTimeKind.Local).AddTicks(9652) });
        }
    }
}
