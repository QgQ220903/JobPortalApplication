using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobPortalApplication.Migrations
{
    /// <inheritdoc />
    public partial class renameEmployer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdateAt",
                table: "Employers",
                newName: "Update");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "Employers",
                newName: "Create");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Employers",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Employers");

            migrationBuilder.RenameColumn(
                name: "Update",
                table: "Employers",
                newName: "UpdateAt");

            migrationBuilder.RenameColumn(
                name: "Create",
                table: "Employers",
                newName: "CreateAt");

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2022, 10, 4, 9, 15, 12, 943, DateTimeKind.Local).AddTicks(1226), new DateTime(2024, 10, 4, 9, 15, 12, 943, DateTimeKind.Local).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2021, 10, 4, 9, 15, 12, 943, DateTimeKind.Local).AddTicks(1250), new DateTime(2024, 10, 4, 9, 15, 12, 943, DateTimeKind.Local).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2019, 10, 4, 9, 15, 12, 943, DateTimeKind.Local).AddTicks(1252), new DateTime(2024, 10, 4, 9, 15, 12, 943, DateTimeKind.Local).AddTicks(1253) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2023, 10, 4, 9, 15, 12, 943, DateTimeKind.Local).AddTicks(1255), new DateTime(2024, 10, 4, 9, 15, 12, 943, DateTimeKind.Local).AddTicks(1255) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2020, 10, 4, 9, 15, 12, 943, DateTimeKind.Local).AddTicks(1257), new DateTime(2024, 10, 4, 9, 15, 12, 943, DateTimeKind.Local).AddTicks(1258) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Create", "Update" },
                values: new object[] { new DateTime(2018, 10, 4, 9, 15, 12, 943, DateTimeKind.Local).AddTicks(1260), new DateTime(2024, 10, 4, 9, 15, 12, 943, DateTimeKind.Local).AddTicks(1260) });
        }
    }
}
