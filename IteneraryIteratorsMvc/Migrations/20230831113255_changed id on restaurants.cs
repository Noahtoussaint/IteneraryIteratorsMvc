using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IteneraryIteratorsMvc.Migrations
{
    /// <inheritdoc />
    public partial class changedidonrestaurants : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "CityId", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1000, 1, "", "/Image/Mahalo.jpg", "Mahalo" },
                    { 1100, 4, "", "/Image/vollners.jpg", "Vollmers" },
                    { 1200, 4, "", "/Image/Aster.jpg", "Aster" },
                    { 1300, 4, "", "/Image/Lyran.jpg", "Lyran Matbar" },
                    { 1400, 5, "", "/Image/Annis.jpg", "Annis Grill" },
                    { 1500, 5, "", "/Image/Enok.jpg", "Enoks i Láddjujávri" },
                    { 1600, 5, "", "/Image/Nikkalukta.jpg", "Nikkaluokta Sarri" },
                    { 2000, 1, "", "/Image/linglong.jpg", "Linglong" },
                    { 3000, 1, "", "/Image/Tranan.jpg", "Tranan" },
                    { 4000, 2, "", "/Image/Daawat.jpg", "Daawat" },
                    { 5000, 2, "", "/Image/Panos.jpg", "Panos Panos Tavern" },
                    { 6000, 2, "", "/Image/Bord27.jpg", "Bord 27" },
                    { 7000, 3, "", "/Image/Aaltos.jpg", "Aaltos Italian Grill & Garden" },
                    { 8000, 3, "", "/Image/Hambergs Fisk.jpg", "Hambergs Fisk" },
                    { 9000, 3, "", "/Image/Missvoon.jpg", "Miss Voon" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1300);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1400);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1500);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1600);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2000);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3000);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4000);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5000);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 6000);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 7000);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 8000);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 9000);

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "CityId", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, 1, "", "/Image/Mahalo.jpg", "Mahalo" },
                    { 2, 1, "", "/Image/linglong.jpg", "Linglong" },
                    { 3, 1, "", "/Image/Tranan.jpg", "Tranan" },
                    { 4, 2, "", "/Image/Daawat.jpg", "Daawat" },
                    { 5, 2, "", "/Image/Panos.jpg", "Panos Panos Tavern" },
                    { 6, 2, "", "/Image/Bord27.jpg", "Bord 27" },
                    { 7, 3, "", "/Image/Aaltos.jpg", "Aaltos Italian Grill & Garden" },
                    { 8, 3, "", "/Image/Hambergs Fisk.jpg", "Hambergs Fisk" },
                    { 9, 3, "", "/Image/Missvoon.jpg", "Miss Voon" },
                    { 10, 4, "", "/Image/vollners.jpg", "Vollmers" },
                    { 11, 4, "", "/Image/Aster.jpg", "Aster" },
                    { 12, 4, "", "/Image/Lyran.jpg", "Lyran Matbar" },
                    { 13, 5, "", "/Image/Annis.jpg", "Annis Grill" },
                    { 14, 5, "", "/Image/Enok.jpg", "Enoks i Láddjujávri" },
                    { 15, 5, "", "/Image/Nikkalukta.jpg", "Nikkaluokta Sarri" }
                });
        }
    }
}
