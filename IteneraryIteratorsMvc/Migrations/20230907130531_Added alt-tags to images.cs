using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IteneraryIteratorsMvc.Migrations
{
    /// <inheritdoc />
    public partial class Addedalttagstoimages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AltTag",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AltTag",
                table: "Activities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "AltTag",
                value: "A buildning with a ship on top");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "AltTag",
                value: "Entrance of Skansen");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "AltTag",
                value: "The building of Bonniers konsthall");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "AltTag",
                value: "Animated image of the amusement park during the evening");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "AltTag",
                value: "Park with a fountain");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "AltTag",
                value: "War ship");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "AltTag",
                value: "Two ladies walking in a the garden.");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "AltTag",
                value: "Overlooking the garden infront of a building");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "AltTag",
                value: "Old church in middle of Uppsala");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                column: "AltTag",
                value: "Image of a pond with a willow tree next to it.");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 11,
                column: "AltTag",
                value: "People riding bikes on the street.");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 12,
                column: "AltTag",
                value: "Overhead view of a castle in Malmö");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 13,
                column: "AltTag",
                value: "Aurora borialis on the night sky");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 14,
                column: "AltTag",
                value: "Waterfall");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 15,
                column: "AltTag",
                value: "The inside of a mine with blue lights along the walls.");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1000,
                column: "AltTag",
                value: "Laid tables at Mahalo");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1100,
                column: "AltTag",
                value: "Laid tables at Vollmers");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1200,
                column: "AltTag",
                value: "Laid tables at Aster");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1300,
                column: "AltTag",
                value: "Overlooking the bar at Lyran Matbar");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1400,
                column: "AltTag",
                value: "Cheeseburger without bacon");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1500,
                column: "AltTag",
                value: "Entrance of Enoks");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1600,
                column: "AltTag",
                value: "Dining hall");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2000,
                column: "AltTag",
                value: "Laid tables at Linglong");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3000,
                column: "AltTag",
                value: "Laid tables at Tranan");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4000,
                column: "AltTag",
                value: "Tabel with different cusines");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5000,
                column: "AltTag",
                value: "Laid tables at Panos Panos Tavern");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 6000,
                column: "AltTag",
                value: "Laid tables at Bord 27");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 7000,
                column: "AltTag",
                value: "Laid tables at Aaltos Italian Grill");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 8000,
                column: "AltTag",
                value: "Laid tables at Hambergs Fisk");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 9000,
                column: "AltTag",
                value: "Laid tables at Miss Voon");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AltTag",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "AltTag",
                table: "Activities");
        }
    }
}
