using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class changedBackground : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bevs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Review",
                value: " 10/10 Would recommend.");

            migrationBuilder.UpdateData(
                table: "ReviewList",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2021, 2, 26, 13, 43, 43, 72, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "ReviewList",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2021, 2, 26, 13, 43, 43, 76, DateTimeKind.Local).AddTicks(3100));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bevs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Review",
                value: " 10/10 Would reccomend.");

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
    }
}
