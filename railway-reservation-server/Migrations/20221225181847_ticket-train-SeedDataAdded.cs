using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace railwayReservation.Migrations
{
    public partial class tickettrainSeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Trains",
                columns: new[] { "trainId", "ACSeats", "destination", "generalSeats", "semiSleeperSeats", "sleeperSeats", "source", "trainName" },
                values: new object[,]
                {
                    { 1, 25, "Vancouer", 50, 48, 40, "Seattle", "The Ambassador" },
                    { 2, 15, "Gaspe", 52, 18, 10, "Montreal", "Chaleur" },
                    { 3, 15, "Yarmouth", 52, 18, 10, "Halifax", "Flying Bluenose" },
                    { 4, 15, "Boston", 52, 18, 10, "Halifax", "The Gull" },
                    { 5, 15, "Quebec City", 52, 18, 10, "Montreal", "Montreal" },
                    { 6, 15, "Portland", 52, 18, 10, "Vancouer", "Owl" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "ticketId", "bookedDate", "journeyDate", "ticketFare", "ticketNumber", "ticketStatus", "trainId", "userId" },
                values: new object[] { 1, new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 25, 23, 48, 45, 743, DateTimeKind.Local).AddTicks(6265), 580, "A6755HI9899", "Confirmed", 3, 2 });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "ticketId", "bookedDate", "journeyDate", "ticketFare", "ticketNumber", "ticketStatus", "trainId", "userId" },
                values: new object[] { 2, new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 180, "A67OLPM9899", "Confirmed", 5, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "ticketId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "ticketId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "trainId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "trainId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "trainId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "trainId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "trainId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "trainId",
                keyValue: 5);
        }
    }
}
