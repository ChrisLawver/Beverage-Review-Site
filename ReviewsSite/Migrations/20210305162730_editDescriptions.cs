using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class editDescriptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bevs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Pepsi is a carbonated soft drink manufactured by PepsiCo. Originally created and developed in 1893 by Caleb Bradham and introduced as Brad's Drink, it was renamed as Pepsi-Cola in 1898, and then shortened to Pepsi in 1961.");

            migrationBuilder.UpdateData(
                table: "Bevs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Monster Energy is an energy drink that was introduced by Hansen Natural Company in April of 2002. As of 2019, Monster Energy has a 35% share of the energy drink market, the second highest share after Red Bull.");

            migrationBuilder.UpdateData(
                table: "Bevs",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "LaCroix or La Croix is an American brand of carbonated water that originated in La Crosse, Wisconsin by G. Heileman Brewing Company and is now distributed by National Beverage Corporation.");

            migrationBuilder.UpdateData(
                table: "ReviewList",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2021, 3, 5, 11, 27, 28, 953, DateTimeKind.Local).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "ReviewList",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2021, 3, 5, 11, 27, 28, 959, DateTimeKind.Local).AddTicks(4572));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bevs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Pepsi is a carbonated soft drink manufactured by PepsiCo. Originally created and developed in 1893 by Caleb Bradham and introduced as Brad's Drink, it was renamed as Pepsi-Cola in 1898,[1] and then shortened to Pepsi in 1961.");

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
    }
}
