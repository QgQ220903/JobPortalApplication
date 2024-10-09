using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobPortalApplication.Migrations
{
    /// <inheritdoc />
    public partial class updateEmployer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Employers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2022, 10, 9, 18, 42, 29, 840, DateTimeKind.Local).AddTicks(5028), new DateTime(2024, 10, 9, 18, 42, 29, 840, DateTimeKind.Local).AddTicks(5043) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2021, 10, 9, 18, 42, 29, 840, DateTimeKind.Local).AddTicks(5051), new DateTime(2024, 10, 9, 18, 42, 29, 840, DateTimeKind.Local).AddTicks(5051) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2019, 10, 9, 18, 42, 29, 840, DateTimeKind.Local).AddTicks(5053), new DateTime(2024, 10, 9, 18, 42, 29, 840, DateTimeKind.Local).AddTicks(5054) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2023, 10, 9, 18, 42, 29, 840, DateTimeKind.Local).AddTicks(5056), new DateTime(2024, 10, 9, 18, 42, 29, 840, DateTimeKind.Local).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2020, 10, 9, 18, 42, 29, 840, DateTimeKind.Local).AddTicks(5058), new DateTime(2024, 10, 9, 18, 42, 29, 840, DateTimeKind.Local).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2018, 10, 9, 18, 42, 29, 840, DateTimeKind.Local).AddTicks(5060), new DateTime(2024, 10, 9, 18, 42, 29, 840, DateTimeKind.Local).AddTicks(5061) });

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2022, 10, 9, 18, 42, 29, 840, DateTimeKind.Local).AddTicks(6322), new DateTime(2024, 10, 9, 18, 42, 29, 840, DateTimeKind.Local).AddTicks(6326) });

            migrationBuilder.CreateIndex(
                name: "IX_Employers_Email",
                table: "Employers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employers_Username",
                table: "Employers",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employers_Email",
                table: "Employers");

            migrationBuilder.DropIndex(
                name: "IX_Employers_Username",
                table: "Employers");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Employers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2022, 10, 8, 21, 34, 21, 531, DateTimeKind.Local).AddTicks(3366), new DateTime(2024, 10, 8, 21, 34, 21, 531, DateTimeKind.Local).AddTicks(3381) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2021, 10, 8, 21, 34, 21, 531, DateTimeKind.Local).AddTicks(3385), new DateTime(2024, 10, 8, 21, 34, 21, 531, DateTimeKind.Local).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2019, 10, 8, 21, 34, 21, 531, DateTimeKind.Local).AddTicks(3388), new DateTime(2024, 10, 8, 21, 34, 21, 531, DateTimeKind.Local).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2023, 10, 8, 21, 34, 21, 531, DateTimeKind.Local).AddTicks(3390), new DateTime(2024, 10, 8, 21, 34, 21, 531, DateTimeKind.Local).AddTicks(3391) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2020, 10, 8, 21, 34, 21, 531, DateTimeKind.Local).AddTicks(3392), new DateTime(2024, 10, 8, 21, 34, 21, 531, DateTimeKind.Local).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2018, 10, 8, 21, 34, 21, 531, DateTimeKind.Local).AddTicks(3395), new DateTime(2024, 10, 8, 21, 34, 21, 531, DateTimeKind.Local).AddTicks(3396) });

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2022, 10, 8, 21, 34, 21, 531, DateTimeKind.Local).AddTicks(3413), new DateTime(2024, 10, 8, 21, 34, 21, 531, DateTimeKind.Local).AddTicks(3414) });
        }
    }
}
