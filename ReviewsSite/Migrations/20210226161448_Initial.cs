using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bevs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Review = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bevs", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Bevs",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Review" },
                values: new object[,]
                {
                    { 1, "Soda", "Smooth caramel beverage.", "Images/coke.jpg", "Coke", " 10/10 Would reccomend." },
                    { 2, "Soda", "Rough and tumble", "Images/Pepsipic.jpg", "Pepsi", "Disappointing." },
                    { 3, "Energy Drink", "It gives you wings", "Images/RedBull.jpg", "Red Bull", "Yummy" },
                    { 4, "Energy Drink", "Energizing drink", "Images/Monster.jpg", "Monster", "It's mediocre" },
                    { 5, "Sparkling Water", "Many flavors", "Images/LaCroix.jpg", "La Croix", "Refreshlingy bubbly" },
                    { 6, "Sparkling Water", "Fruit juice flavored sparkling water", "Images/Spindrift.jpg", "SpinDrift", "It's like La Croix's cooler sibling" }
                });

            migrationBuilder.InsertData(
                table: "ReviewList",
                columns: new[] { "Id", "BevId", "Content", "Rating", "ReviewDate", "ReviewerName" },
                values: new object[] { 1, 1, "Too carbonated.", "5", new DateTime(2021, 2, 26, 11, 14, 47, 829, DateTimeKind.Local).AddTicks(7821), "Carlos" });

            migrationBuilder.InsertData(
                table: "ReviewList",
                columns: new[] { "Id", "BevId", "Content", "Rating", "ReviewDate", "ReviewerName" },
                values: new object[] { 2, 2, "Offensive to the pallete", "0", new DateTime(2021, 2, 26, 11, 14, 47, 834, DateTimeKind.Local).AddTicks(6465), "Davis" });

            migrationBuilder.CreateIndex(
                name: "IX_ReviewList_BevId",
                table: "ReviewList",
                column: "BevId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReviewList");

            migrationBuilder.DropTable(
                name: "Bevs");
        }
    }
}
