using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IteneraryIteratorsMvc.Migrations
{
    /// <inheritdoc />
    public partial class Addedbetterqualitypictures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1000,
                column: "ImageUrl",
                value: "/Image/Mahalo.jpeg");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1100,
                column: "ImageUrl",
                value: "/Image/Vollmers.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1200,
                column: "ImageUrl",
                value: "/Image/aster.jpeg");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1600,
                column: "ImageUrl",
                value: "/Image/Nik.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4000,
                column: "ImageUrl",
                value: "/Image/daawat.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5000,
                column: "ImageUrl",
                value: "/Image/panos.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 6000,
                column: "ImageUrl",
                value: "/Image/bord27.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 8000,
                column: "ImageUrl",
                value: "/Image/Hamberg.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 9000,
                column: "ImageUrl",
                value: "/Image/Miss.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1000,
                column: "ImageUrl",
                value: "/Image/Mahalo.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1100,
                column: "ImageUrl",
                value: "/Image/vollners.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1200,
                column: "ImageUrl",
                value: "/Image/Aster.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1600,
                column: "ImageUrl",
                value: "/Image/Nikkalukta.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4000,
                column: "ImageUrl",
                value: "/Image/Daawat.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5000,
                column: "ImageUrl",
                value: "/Image/Panos.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 6000,
                column: "ImageUrl",
                value: "/Image/Bord27.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 8000,
                column: "ImageUrl",
                value: "/Image/Hambergs Fisk.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 9000,
                column: "ImageUrl",
                value: "/Image/Missvoon.jpg");
        }
    }
}
