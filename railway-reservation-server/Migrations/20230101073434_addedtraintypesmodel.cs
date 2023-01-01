using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace railwayReservation.Migrations
{
    public partial class addedtraintypesmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "trainType",
                table: "Trains",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "ticketId",
                keyValue: 1,
                columns: new[] { "bookedDate", "journeyDate" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 1, 13, 4, 32, 874, DateTimeKind.Local).AddTicks(5085) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "ticketId",
                keyValue: 2,
                column: "bookedDate",
                value: new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "trainType",
                table: "Trains");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "ticketId",
                keyValue: 1,
                columns: new[] { "bookedDate", "journeyDate" },
                values: new object[] { new DateTime(2022, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 26, 20, 33, 11, 433, DateTimeKind.Local).AddTicks(6541) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "ticketId",
                keyValue: 2,
                column: "bookedDate",
                value: new DateTime(2022, 12, 26, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
