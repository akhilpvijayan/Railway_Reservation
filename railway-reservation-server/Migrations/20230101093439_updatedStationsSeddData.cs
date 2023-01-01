using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace railwayReservation.Migrations
{
    public partial class updatedStationsSeddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stations_Trains_trainId",
                table: "Stations");

            migrationBuilder.DropIndex(
                name: "IX_Stations_trainId",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "arrivalTime",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "depatureTime",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "trainId",
                table: "Stations");

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "stationId", "stationName" },
                values: new object[,]
                {
                    { 1, "Vancouer" },
                    { 2, "Alberta" },
                    { 3, "Calgary" },
                    { 4, "British Columbia" },
                    { 5, "Florida" },
                    { 6, "Chicago" },
                    { 7, "New Jersey" },
                    { 8, "Ontario" },
                    { 9, "Seattle" }
                });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "ticketId",
                keyValue: 1,
                column: "journeyDate",
                value: new DateTime(2023, 1, 1, 15, 4, 38, 98, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "Trains",
                keyColumn: "trainId",
                keyValue: 1,
                columns: new[] { "destination", "source" },
                values: new object[] { "2", "1" });

            migrationBuilder.UpdateData(
                table: "Trains",
                keyColumn: "trainId",
                keyValue: 2,
                columns: new[] { "destination", "source" },
                values: new object[] { "3", "2" });

            migrationBuilder.UpdateData(
                table: "Trains",
                keyColumn: "trainId",
                keyValue: 3,
                columns: new[] { "destination", "source" },
                values: new object[] { "4", "3" });

            migrationBuilder.UpdateData(
                table: "Trains",
                keyColumn: "trainId",
                keyValue: 4,
                columns: new[] { "destination", "source" },
                values: new object[] { "4", "1" });

            migrationBuilder.UpdateData(
                table: "Trains",
                keyColumn: "trainId",
                keyValue: 5,
                columns: new[] { "destination", "source" },
                values: new object[] { "6", "2" });

            migrationBuilder.UpdateData(
                table: "Trains",
                keyColumn: "trainId",
                keyValue: 6,
                columns: new[] { "destination", "source" },
                values: new object[] { "1", "5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "stationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "stationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "stationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "stationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "stationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "stationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "stationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "stationId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "stationId",
                keyValue: 9);

            migrationBuilder.AddColumn<DateTime>(
                name: "arrivalTime",
                table: "Stations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "depatureTime",
                table: "Stations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "trainId",
                table: "Stations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "destination", "source" },
                values: new object[] { "Vancouer", "Seattle" });

            migrationBuilder.UpdateData(
                table: "Trains",
                keyColumn: "trainId",
                keyValue: 2,
                columns: new[] { "destination", "source" },
                values: new object[] { "Gaspe", "Montreal" });

            migrationBuilder.UpdateData(
                table: "Trains",
                keyColumn: "trainId",
                keyValue: 3,
                columns: new[] { "destination", "source" },
                values: new object[] { "Yarmouth", "Halifax" });

            migrationBuilder.UpdateData(
                table: "Trains",
                keyColumn: "trainId",
                keyValue: 4,
                columns: new[] { "destination", "source" },
                values: new object[] { "Boston", "Halifax" });

            migrationBuilder.UpdateData(
                table: "Trains",
                keyColumn: "trainId",
                keyValue: 5,
                columns: new[] { "destination", "source" },
                values: new object[] { "Quebec City", "Montreal" });

            migrationBuilder.UpdateData(
                table: "Trains",
                keyColumn: "trainId",
                keyValue: 6,
                columns: new[] { "destination", "source" },
                values: new object[] { "Portland", "Vancouer" });

            migrationBuilder.CreateIndex(
                name: "IX_Stations_trainId",
                table: "Stations",
                column: "trainId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stations_Trains_trainId",
                table: "Stations",
                column: "trainId",
                principalTable: "Trains",
                principalColumn: "trainId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
