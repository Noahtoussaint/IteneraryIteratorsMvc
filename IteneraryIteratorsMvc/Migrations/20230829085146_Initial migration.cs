using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IteneraryIteratorsMvc.Migrations
{
    /// <inheritdoc />
    public partial class Initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activities_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Restaurants_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Stockholm" },
                    { 2, "Göteborg" },
                    { 3, "Uppsala" },
                    { 4, "Malmö" },
                    { 5, "Kiruna" }
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "CityId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 1, "", "Vasamuseet" },
                    { 2, 1, "", "Skansen" },
                    { 3, 1, "", "Bonniers konsthall" },
                    { 4, 2, "", "Liseberg" },
                    { 5, 2, "", "Slottsskogen" },
                    { 6, 2, "", "Maritiman" },
                    { 7, 3, "", "Linnéträdgården" },
                    { 8, 3, "", "Botaniska Trädgården" },
                    { 9, 3, "", "Uppsala Domkyrka" },
                    { 10, 4, "", "Kungsparken" },
                    { 11, 4, "", "Malmö Private Bike Tour" },
                    { 12, 4, "", "Malmöhus slott" },
                    { 13, 5, "", "Aurora Sky Station" },
                    { 14, 5, "", "Silverfallet" },
                    { 15, 5, "", "LKAB:s Visitor Centre" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "CityId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 1, "", "Mahalo" },
                    { 2, 1, "", "Linglong" },
                    { 3, 1, "", "Tranan" },
                    { 4, 2, "", "Daawat" },
                    { 5, 2, "", "Panos Panos Tavern" },
                    { 6, 2, "", "Bord 27" },
                    { 7, 3, "", "Aaltos Italian Grill & Garden" },
                    { 8, 3, "", "Hambergs Fisk" },
                    { 9, 3, "", "Miss Voon" },
                    { 10, 4, "", "Vollmers" },
                    { 11, 4, "", "Aster" },
                    { 12, 4, "", "Lyran Matbar" },
                    { 13, 5, "", "Annis Grill" },
                    { 14, 5, "", "Enoks i Láddjujávri" },
                    { 15, 5, "", "Nikkaluokta Sarri" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_CityId",
                table: "Activities",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_CityId",
                table: "Restaurants",
                column: "CityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
