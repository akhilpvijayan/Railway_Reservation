using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace railwayReservation.Migrations
{
    public partial class updatedTrainSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "ticketId",
                keyValue: 1,
                column: "journeyDate",
                value: new DateTime(2023, 1, 1, 13, 15, 34, 98, DateTimeKind.Local).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "Trains",
                keyColumn: "trainId",
                keyValue: 1,
                column: "trainType",
                value: "2");

            migrationBuilder.UpdateData(
                table: "Trains",
                keyColumn: "trainId",
                keyValue: 2,
                column: "trainType",
                value: "4");

            migrationBuilder.UpdateData(
                table: "Trains",
                keyColumn: "trainId",
                keyValue: 3,
                column: "trainType",
                value: "5");

            migrationBuilder.UpdateData(
                table: "Trains",
                keyColumn: "trainId",
                keyValue: 4,
                column: "trainType",
                value: "6");

            migrationBuilder.UpdateData(
                table: "Trains",
                keyColumn: "trainId",
                keyValue: 5,
                column: "trainType",
                value: "3");

            migrationBuilder.UpdateData(
                table: "Trains",
                keyColumn: "trainId",
                keyValue: 6,
                column: "trainType",
                value: "1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "ticketId",
                keyValue: 1,
                column: "journeyDate",
                value: new DateTime(2023, 1, 1, 13, 12, 55, 598, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "Trains",
                keyColumn: "trainId",
                keyValue: 1,
                column: "trainType",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trains",
                keyColumn: "trainId",
                keyValue: 2,
                column: "trainType",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trains",
                keyColumn: "trainId",
                keyValue: 3,
                column: "trainType",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trains",
                keyColumn: "trainId",
                keyValue: 4,
                column: "trainType",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trains",
                keyColumn: "trainId",
                keyValue: 5,
                column: "trainType",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trains",
                keyColumn: "trainId",
                keyValue: 6,
                column: "trainType",
                value: null);
        }
    }
}
