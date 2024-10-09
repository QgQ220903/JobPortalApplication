using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobPortalApplication.Migrations
{
    /// <inheritdoc />
    public partial class updateLocationEmployer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Employers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2022, 10, 8, 20, 46, 19, 192, DateTimeKind.Local).AddTicks(3123), new DateTime(2024, 10, 8, 20, 46, 19, 192, DateTimeKind.Local).AddTicks(3139) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2021, 10, 8, 20, 46, 19, 192, DateTimeKind.Local).AddTicks(3142), new DateTime(2024, 10, 8, 20, 46, 19, 192, DateTimeKind.Local).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2019, 10, 8, 20, 46, 19, 192, DateTimeKind.Local).AddTicks(3145), new DateTime(2024, 10, 8, 20, 46, 19, 192, DateTimeKind.Local).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2023, 10, 8, 20, 46, 19, 192, DateTimeKind.Local).AddTicks(3147), new DateTime(2024, 10, 8, 20, 46, 19, 192, DateTimeKind.Local).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2020, 10, 8, 20, 46, 19, 192, DateTimeKind.Local).AddTicks(3149), new DateTime(2024, 10, 8, 20, 46, 19, 192, DateTimeKind.Local).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2018, 10, 8, 20, 46, 19, 192, DateTimeKind.Local).AddTicks(3152), new DateTime(2024, 10, 8, 20, 46, 19, 192, DateTimeKind.Local).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Location", "Update" },
                values: new object[] { new DateTime(2022, 10, 8, 20, 46, 19, 192, DateTimeKind.Local).AddTicks(3200), "Bac ruong", new DateTime(2024, 10, 8, 20, 46, 19, 192, DateTimeKind.Local).AddTicks(3204) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Employers");

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
    }
}
