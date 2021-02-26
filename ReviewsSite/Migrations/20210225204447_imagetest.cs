using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class imagetest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReviewList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BevId = table.Column<int>(type: "int", nullable: false),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReviewList_Bevs_BevId",
                        column: x => x.BevId,
                        principalTable: "Bevs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Bevs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "Images/coke.jpg");

            migrationBuilder.InsertData(
                table: "ReviewList",
                columns: new[] { "Id", "BevId", "Content", "Rating", "ReviewDate", "ReviewerName" },
                values: new object[] { 2, 0, "Offensive to the pallete", "0", new DateTime(2021, 2, 25, 15, 44, 46, 691, DateTimeKind.Local).AddTicks(8255), "Davis" });

            migrationBuilder.InsertData(
                table: "ReviewList",
                columns: new[] { "Id", "BevId", "Content", "Rating", "ReviewDate", "ReviewerName" },
                values: new object[] { 1, 0, "Too carbonated.", "5", new DateTime(2021, 2, 25, 15, 44, 46, 688, DateTimeKind.Local).AddTicks(3851), "Carlos" });

            migrationBuilder.CreateIndex(
                name: "IX_ReviewList_BevId",
                table: "ReviewList",
                column: "BevId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReviewList");

            migrationBuilder.UpdateData(
                table: "Bevs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "");
        }
    }
}
