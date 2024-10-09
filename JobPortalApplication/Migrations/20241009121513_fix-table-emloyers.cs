using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobPortalApplication.Migrations
{
    /// <inheritdoc />
    public partial class fixtableemloyers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
