using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IteneraryIteratorsMvc.Migrations
{
    /// <inheritdoc />
    public partial class Addeddescriptionstoactivitiesandrestaurants : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Vasamuseet houses a historic vessel, the Vasa warship, offering an immersive experience into maritime history and Swedish naval heritage.");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "A cultural oasis, Skansen introduces visitors to the charm of Sweden's past with its open-air museum and zoo, allowing guests to explore history and wildlife.");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "An artistic haven, Bonniers konsthall showcases contemporary art exhibitions, providing a space for art enthusiasts to immerse themselves in diverse creative expressions.");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: " Liseberg is a thrilling amusement park offering a blend of exhilarating rides, captivating performances, and family-friendly entertainment for all ages.");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Nature enthusiasts find solace at Slottsskogen, a vast urban park where tranquility meets wildlife, offering serene walks and an opportunity to connect with nature.");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Maritiman beckons maritime enthusiasts with its collection of ships and boats, offering an interactive journey through seafaring history and maritime traditions.");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Linnéträdgården is a botanical oasis celebrating the legacy of Carl Linnaeus, featuring a variety of plants and settings that transport visitors to a bygone era.");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Botaniska Trädgården is a botanical paradise, offering an immersive experience through diverse plant species, greenhouses, and serene landscapes.");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Uppsala Domkyrka, the Uppsala Cathedral, stands as a majestic religious site, inviting visitors to explore its stunning architecture and historical significance.\r\n");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Kungsparken offers a tranquil urban escape, combining scenic beauty with historic sculptures and a serene lake, making it a perfect spot for relaxation.");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "A cycling adventure through Malmö, the Private Bike Tour offers an exploration of the city's landmarks and hidden gems, guided by local expertise.");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "Malmöhus slott, Malmö Castle, encapsulates history within its walls, inviting visitors to delve into centuries of culture and heritage through exhibitions and architecture.");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: " Located in Kiruna, Aurora Sky Station offers a chance to witness the mesmerizing Northern Lights, providing a celestial experience amidst the Arctic wilderness.");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "Silverfallet is a captivating waterfall in Kiruna, offering a picturesque natural setting where guests can revel in the serene beauty of cascading waters.");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "LKAB's Visitor Centre provides insights into Kiruna's mining heritage, offering a glimpse into the region's mining history and its impact on the community.");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1000,
                column: "Description",
                value: "A serene dining spot offering a diverse culinary experience, Mahalo entices with its elegant ambiance and delectable menu, inviting patrons to savor a mix of flavors.");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1100,
                column: "Description",
                value: "A culinary masterpiece, Vollmers offers an exceptional dining experience, crafting dishes that epitomize artistry and innovation, inviting guests to embark on a culinary exploration.");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1200,
                column: "Description",
                value: "With an atmosphere of elegance, Aster redefines modern dining with its creative menu that marries traditional elements with avant-garde culinary techniques.");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1300,
                column: "Description",
                value: "A hidden gem, Lyran Matbar captures the essence of its surroundings, serving dishes that reflect the region's bounty and cultural heritage in every bite.");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1400,
                column: "Description",
                value: "Known for its flavorsome offerings, Annis Grill beckons with its rich and succulent dishes, providing a culinary journey that celebrates the art of grilling.");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1500,
                column: "Description",
                value: "Set against a stunning backdrop, Enoks i Láddjujávri combines breathtaking views with delectable fare, giving guests an opportunity to relish nature's beauty alongside their meal.");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1600,
                column: "Description",
                value: "Embracing its rustic charm, Nikkaluokta Sarri immerses diners in traditional flavors, offering a taste of authentic cuisine that pays homage to local heritage.");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2000,
                column: "Description",
                value: "An enchanting eatery, Linglong promises a gastronomic journey through its array of dishes, serving up a fusion of traditional and contemporary tastes that captivate the senses.");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3000,
                column: "Description",
                value: "Nestled in the heart of the city, Tranan beckons diners with its cozy atmosphere and an array of dishes that reflect the essence of the local culinary scene.");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4000,
                column: "Description",
                value: "A culinary haven, Daawat tempts with its aromatic creations inspired by authentic flavors, offering a taste of the rich culinary heritage of the region.");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5000,
                column: "Description",
                value: " With a warm and welcoming ambiance, Panos Panos Tavern celebrates the art of Mediterranean cuisine, inviting guests to indulge in dishes that evoke the sun-soaked shores.");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 6000,
                column: "Description",
                value: "A culinary destination, Bord 27 invites patrons to relish an array of delightful dishes curated with passion, representing a symphony of tastes and textures.");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 7000,
                column: "Description",
                value: " A charming spot, Aaltos Italian Grill & Garden delights with its blend of traditional and innovative Italian fare, providing an inviting setting for a memorable dining experience.");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 8000,
                column: "Description",
                value: "Nestled by the waterfront, Hambergs Fisk celebrates the bounties of the sea, offering a seafood-centric menu that showcases the freshness and flavors of the ocean.");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 9000,
                column: "Description",
                value: "A modern and sophisticated eatery, Miss Voon presents a fusion of Asian flavors with a contemporary twist, promising a culinary journey that excites the palate.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1000,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1100,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1200,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1300,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1400,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1500,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1600,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2000,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3000,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4000,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5000,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 6000,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 7000,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 8000,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 9000,
                column: "Description",
                value: "");
        }
    }
}
