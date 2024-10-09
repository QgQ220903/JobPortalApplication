using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobPortalApplication.Migrations
{
    /// <inheritdoc />
    public partial class updateEmailEmployer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2022, 10, 8, 20, 46, 19, 192, DateTimeKind.Local).AddTicks(3200), new DateTime(2024, 10, 8, 20, 46, 19, 192, DateTimeKind.Local).AddTicks(3204) });
        }
    }
}
