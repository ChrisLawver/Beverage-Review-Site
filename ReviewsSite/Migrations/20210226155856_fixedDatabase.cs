using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class fixedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ReviewList",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BevId", "ReviewDate" },
                values: new object[] { 1, new DateTime(2021, 2, 26, 10, 58, 54, 899, DateTimeKind.Local).AddTicks(5047) });

            migrationBuilder.UpdateData(
                table: "ReviewList",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BevId", "ReviewDate" },
                values: new object[] { 2, new DateTime(2021, 2, 26, 10, 58, 54, 903, DateTimeKind.Local).AddTicks(9446) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ReviewList",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BevId", "ReviewDate" },
                values: new object[] { 0, new DateTime(2021, 2, 26, 10, 52, 57, 574, DateTimeKind.Local).AddTicks(2528) });

            migrationBuilder.UpdateData(
                table: "ReviewList",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BevId", "ReviewDate" },
                values: new object[] { 0, new DateTime(2021, 2, 26, 10, 52, 57, 580, DateTimeKind.Local).AddTicks(3380) });
        }
    }
}
