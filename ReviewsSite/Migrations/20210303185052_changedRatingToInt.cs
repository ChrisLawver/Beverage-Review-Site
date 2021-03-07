using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class changedRatingToInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "ReviewList",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ReviewList",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Rating", "ReviewDate" },
                values: new object[] { 5, new DateTime(2021, 3, 3, 13, 50, 51, 181, DateTimeKind.Local).AddTicks(6828) });

            migrationBuilder.UpdateData(
                table: "ReviewList",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Rating", "ReviewDate" },
                values: new object[] { 0, new DateTime(2021, 3, 3, 13, 50, 51, 188, DateTimeKind.Local).AddTicks(3364) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "ReviewList",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "ReviewList",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Rating", "ReviewDate" },
                values: new object[] { "5", new DateTime(2021, 2, 26, 13, 43, 43, 72, DateTimeKind.Local).AddTicks(6375) });

            migrationBuilder.UpdateData(
                table: "ReviewList",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Rating", "ReviewDate" },
                values: new object[] { "0", new DateTime(2021, 2, 26, 13, 43, 43, 76, DateTimeKind.Local).AddTicks(3100) });
        }
    }
}
