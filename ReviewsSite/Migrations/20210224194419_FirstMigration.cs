using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class FirstMigration : Migration
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
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Review = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bevs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Bevs",
                columns: new[] { "Id", "Category", "Description", "Name", "Review" },
                values: new object[] { 1, "Soda", "Smooth caramel beverage.", "Coke", " 10/10 Would reccomend." });

            migrationBuilder.InsertData(
                table: "Bevs",
                columns: new[] { "Id", "Category", "Description", "Name", "Review" },
                values: new object[] { 2, "Soda", "Rough and tumble", "Pepsi", "Disappointing." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bevs");
        }
    }
}
