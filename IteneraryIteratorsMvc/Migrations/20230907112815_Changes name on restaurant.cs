using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IteneraryIteratorsMvc.Migrations
{
    /// <inheritdoc />
    public partial class Changesnameonrestaurant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 7000,
                column: "Name",
                value: "Aaltos Italian Grill");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 7000,
                column: "Name",
                value: "Aaltos Italian Grill & Garden");
        }
    }
}
