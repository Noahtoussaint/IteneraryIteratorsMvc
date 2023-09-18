using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IteneraryIteratorsMvc.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedcontexttoattUserActivitiesandUserRestaurants : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserActivity_Activities_ActivityId",
                table: "UserActivity");

            migrationBuilder.DropForeignKey(
                name: "FK_UserActivity_AspNetUsers_UserId",
                table: "UserActivity");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRestaurant_AspNetUsers_UserId",
                table: "UserRestaurant");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRestaurant_Restaurants_RestaurantId",
                table: "UserRestaurant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRestaurant",
                table: "UserRestaurant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserActivity",
                table: "UserActivity");

            migrationBuilder.RenameTable(
                name: "UserRestaurant",
                newName: "UserRestaurants");

            migrationBuilder.RenameTable(
                name: "UserActivity",
                newName: "UserActivities");

            migrationBuilder.RenameIndex(
                name: "IX_UserRestaurant_UserId",
                table: "UserRestaurants",
                newName: "IX_UserRestaurants_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRestaurant_RestaurantId",
                table: "UserRestaurants",
                newName: "IX_UserRestaurants_RestaurantId");

            migrationBuilder.RenameIndex(
                name: "IX_UserActivity_UserId",
                table: "UserActivities",
                newName: "IX_UserActivities_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserActivity_ActivityId",
                table: "UserActivities",
                newName: "IX_UserActivities_ActivityId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserRestaurants",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserActivities",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRestaurants",
                table: "UserRestaurants",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserActivities",
                table: "UserActivities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserActivities_Activities_ActivityId",
                table: "UserActivities",
                column: "ActivityId",
                principalTable: "Activities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserActivities_AspNetUsers_UserId",
                table: "UserActivities",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRestaurants_AspNetUsers_UserId",
                table: "UserRestaurants",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRestaurants_Restaurants_RestaurantId",
                table: "UserRestaurants",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserActivities_Activities_ActivityId",
                table: "UserActivities");

            migrationBuilder.DropForeignKey(
                name: "FK_UserActivities_AspNetUsers_UserId",
                table: "UserActivities");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRestaurants_AspNetUsers_UserId",
                table: "UserRestaurants");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRestaurants_Restaurants_RestaurantId",
                table: "UserRestaurants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRestaurants",
                table: "UserRestaurants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserActivities",
                table: "UserActivities");

            migrationBuilder.RenameTable(
                name: "UserRestaurants",
                newName: "UserRestaurant");

            migrationBuilder.RenameTable(
                name: "UserActivities",
                newName: "UserActivity");

            migrationBuilder.RenameIndex(
                name: "IX_UserRestaurants_UserId",
                table: "UserRestaurant",
                newName: "IX_UserRestaurant_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRestaurants_RestaurantId",
                table: "UserRestaurant",
                newName: "IX_UserRestaurant_RestaurantId");

            migrationBuilder.RenameIndex(
                name: "IX_UserActivities_UserId",
                table: "UserActivity",
                newName: "IX_UserActivity_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserActivities_ActivityId",
                table: "UserActivity",
                newName: "IX_UserActivity_ActivityId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserRestaurant",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserActivity",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRestaurant",
                table: "UserRestaurant",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserActivity",
                table: "UserActivity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserActivity_Activities_ActivityId",
                table: "UserActivity",
                column: "ActivityId",
                principalTable: "Activities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserActivity_AspNetUsers_UserId",
                table: "UserActivity",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRestaurant_AspNetUsers_UserId",
                table: "UserRestaurant",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRestaurant_Restaurants_RestaurantId",
                table: "UserRestaurant",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
