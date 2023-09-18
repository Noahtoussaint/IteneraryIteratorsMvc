using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IteneraryIteratorsMvc.Migrations
{
    /// <inheritdoc />
    public partial class addedbooking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "BookingTime",
                table: "UserRestaurants",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Bookingdate",
                table: "UserRestaurants",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "BookingTime",
                table: "UserActivities",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Bookingdate",
                table: "UserActivities",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookingTime",
                table: "UserRestaurants");

            migrationBuilder.DropColumn(
                name: "Bookingdate",
                table: "UserRestaurants");

            migrationBuilder.DropColumn(
                name: "BookingTime",
                table: "UserActivities");

            migrationBuilder.DropColumn(
                name: "Bookingdate",
                table: "UserActivities");
        }
    }
}
