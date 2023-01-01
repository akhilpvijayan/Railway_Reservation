using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace railwayReservation.Migrations
{
    public partial class addedtraintypesseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "ticketId",
                keyValue: 1,
                column: "journeyDate",
                value: new DateTime(2023, 1, 1, 13, 12, 55, 598, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.InsertData(
                table: "Traintypes",
                columns: new[] { "trainTypeId", "trainType" },
                values: new object[,]
                {
                    { 1, "Bullet Train" },
                    { 2, "Passenger Train" },
                    { 3, "Semi High Speed Train" },
                    { 4, "Express Train" },
                    { 5, "Luxury Train" },
                    { 6, "Super Fast Train" },
                    { 7, "Suburban Train" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Traintypes",
                keyColumn: "trainTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Traintypes",
                keyColumn: "trainTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Traintypes",
                keyColumn: "trainTypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Traintypes",
                keyColumn: "trainTypeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Traintypes",
                keyColumn: "trainTypeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Traintypes",
                keyColumn: "trainTypeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Traintypes",
                keyColumn: "trainTypeId",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "ticketId",
                keyValue: 1,
                column: "journeyDate",
                value: new DateTime(2023, 1, 1, 13, 7, 8, 209, DateTimeKind.Local).AddTicks(1391));
        }
    }
}
