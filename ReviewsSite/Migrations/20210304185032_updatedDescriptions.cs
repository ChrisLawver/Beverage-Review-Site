using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class updatedDescriptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bevs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "A sweetened, carbonated soft drink flavored with vanilla, cinnamon, citrus oils and other flavorings. Most contain caffeine, which was originally sourced from the kola nut, leading to the drink's name, though other sources are now also used. Cola became popular worldwide after pharmacist John Pemberton invented Coca-Cola in 1886, which was later imitated by other manufacturers.His non-alcoholic recipe was inspired by the coca wine of pharmacist Angelo Mariani, created in 1863.");

            migrationBuilder.UpdateData(
                table: "Bevs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Pepsi is a carbonated soft drink manufactured by PepsiCo. Originally created and developed in 1893 by Caleb Bradham and introduced as Brad's Drink, it was renamed as Pepsi-Cola in 1898,[1] and then shortened to Pepsi in 1961.");

            migrationBuilder.UpdateData(
                table: "Bevs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Red Bull is an energy drink sold by Red Bull GmbH, an Austrian company created in 1987. Red Bull has the highest market share of any energy drink in the world, with 7.5 billion cans sold in a year (as of 2019).");

            migrationBuilder.UpdateData(
                table: "Bevs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Monster Energy is an energy drink that was introduced by Hansen Natural Company (now Monster Beverage Corporation) in April of 2002.[1] As of 2019, Monster Energy has a 35% share of the energy drink market,[2] the second highest share after Red Bull.");

            migrationBuilder.UpdateData(
                table: "Bevs",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "LaCroix or La Croix (/ləˈkrɔɪ/;) is an American brand of carbonated water that originated in La Crosse, Wisconsin by G. Heileman Brewing Company and is now distributed by National Beverage Corporation.");

            migrationBuilder.UpdateData(
                table: "Bevs",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "America's first sparkling water made with just real squeezed fruit.");

            migrationBuilder.UpdateData(
                table: "ReviewList",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2021, 3, 4, 13, 50, 31, 307, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "ReviewList",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2021, 3, 4, 13, 50, 31, 314, DateTimeKind.Local).AddTicks(9985));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bevs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Smooth caramel beverage.");

            migrationBuilder.UpdateData(
                table: "Bevs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Rough and tumble");

            migrationBuilder.UpdateData(
                table: "Bevs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "It gives you wings");

            migrationBuilder.UpdateData(
                table: "Bevs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Energizing drink");

            migrationBuilder.UpdateData(
                table: "Bevs",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Many flavors");

            migrationBuilder.UpdateData(
                table: "Bevs",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Fruit juice flavored sparkling water");

            migrationBuilder.UpdateData(
                table: "ReviewList",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2021, 3, 3, 13, 50, 51, 181, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "ReviewList",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2021, 3, 3, 13, 50, 51, 188, DateTimeKind.Local).AddTicks(3364));
        }
    }
}
