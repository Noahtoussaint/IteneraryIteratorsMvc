using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IteneraryIteratorsMvc.Migrations
{
    /// <inheritdoc />
    public partial class ChangedissueswithImagesurl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/Image/Vasamusset.jpg");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/Image/Skansen.jpg");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/Image/Bonnier.jpg");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "/Image/Liseberg.jpg");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "/Image/Slottskogen.jpg");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "/Image/Maritiman.jpg");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "/Image/Linnetradgarden.jpg");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "/Image/Botaniska_Tradgarden.jpg");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "/Image/Uppsala_domkyrka.jpg");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "/Image/Kungsparken-Malmo.jpg");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "/Image/MalmoBikeTour.jpg");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "/Image/MalmoHusSlott.jpg");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "/Image/AuroraSkyStation-Kiruna.jpg");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "/Image/Silverfallet-Kiruna.jpg");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "/Image/LKABVisitorCenter-Kiruna.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "/Image/Bord27.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "Image/Vasamusset.jpg");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "Image/Skansen.jpg");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "Image/Bonnier.jpg");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "Image/Liseberg.jpg");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "Image/Slottskogen.jpg");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "Image/Maritiman.jpg");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "Image/Linnetradgarden.jpg");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "Image/Botaniska_Tradgarden.jpg");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "Image/Uppsala_domkyrka.jpg");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "Image/Kungsparken-Malmo.jpg");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "Image/MalmoBikeTour.jpg");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "Image/MalmoHusSlott.jpg");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "Image/AuroraSkyStation-Kiruna.jpg");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "Image/Silverfallet-Kiruna.jpg");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "Image/LKABVisitorCenter-Kiruna.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "Image/Bord27.jpg");
        }
    }
}
