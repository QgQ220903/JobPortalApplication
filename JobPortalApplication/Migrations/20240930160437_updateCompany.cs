using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobPortalApplication.Migrations
{
    /// <inheritdoc />
    public partial class updateCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Update",
                table: "Companys",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "Companys",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2022, 9, 30, 23, 4, 37, 358, DateTimeKind.Local).AddTicks(3923), new DateTime(2024, 9, 30, 23, 4, 37, 358, DateTimeKind.Local).AddTicks(3946) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2021, 9, 30, 23, 4, 37, 358, DateTimeKind.Local).AddTicks(3953), new DateTime(2024, 9, 30, 23, 4, 37, 358, DateTimeKind.Local).AddTicks(3955) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2019, 9, 30, 23, 4, 37, 358, DateTimeKind.Local).AddTicks(3957), new DateTime(2024, 9, 30, 23, 4, 37, 358, DateTimeKind.Local).AddTicks(3958) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2023, 9, 30, 23, 4, 37, 358, DateTimeKind.Local).AddTicks(3960), new DateTime(2024, 9, 30, 23, 4, 37, 358, DateTimeKind.Local).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2020, 9, 30, 23, 4, 37, 358, DateTimeKind.Local).AddTicks(3965), new DateTime(2024, 9, 30, 23, 4, 37, 358, DateTimeKind.Local).AddTicks(3968) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2018, 9, 30, 23, 4, 37, 358, DateTimeKind.Local).AddTicks(3970), new DateTime(2024, 9, 30, 23, 4, 37, 358, DateTimeKind.Local).AddTicks(3970) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Update",
                table: "Companys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "Companys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
