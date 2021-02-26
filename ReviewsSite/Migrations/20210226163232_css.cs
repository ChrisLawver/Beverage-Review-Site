using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class css : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ReviewList",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2021, 2, 26, 11, 32, 31, 445, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "ReviewList",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2021, 2, 26, 11, 32, 31, 449, DateTimeKind.Local).AddTicks(5205));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ReviewList",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2021, 2, 26, 11, 14, 47, 829, DateTimeKind.Local).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "ReviewList",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2021, 2, 26, 11, 14, 47, 834, DateTimeKind.Local).AddTicks(6465));
        }
    }
}
