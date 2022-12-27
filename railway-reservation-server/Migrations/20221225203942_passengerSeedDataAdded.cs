using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace railwayReservation.Migrations
{
    public partial class passengerSeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "passengerId", "bookedUser", "destination", "passengerAge", "passengerGender", "passengerName", "pnrNo", "reservationStatus", "seatClassId", "seatNumber", "startingPoint", "ticketId" },
                values: new object[,]
                {
                    { 1, 2, "Vancouer", 21, "Female", "Kenny", 8762671890L, "Pending", 2, "232", "Ontario", 1 },
                    { 2, 2, "Ontario", 67, "Male", "Robert", 9172817269L, "Completed", 4, "988", "Calgary", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "ticketId",
                keyValue: 1,
                columns: new[] { "bookedDate", "journeyDate" },
                values: new object[] { new DateTime(2022, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 26, 2, 9, 40, 543, DateTimeKind.Local).AddTicks(171) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "ticketId",
                keyValue: 2,
                column: "bookedDate",
                value: new DateTime(2022, 12, 26, 0, 0, 0, 0, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "passengerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "passengerId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "ticketId",
                keyValue: 1,
                columns: new[] { "bookedDate", "journeyDate" },
                values: new object[] { new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 25, 23, 48, 45, 743, DateTimeKind.Local).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "ticketId",
                keyValue: 2,
                column: "bookedDate",
                value: new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
