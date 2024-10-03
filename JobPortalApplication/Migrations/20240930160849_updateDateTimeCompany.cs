using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobPortalApplication.Migrations
{
    /// <inheritdoc />
    public partial class updateDateTimeCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
