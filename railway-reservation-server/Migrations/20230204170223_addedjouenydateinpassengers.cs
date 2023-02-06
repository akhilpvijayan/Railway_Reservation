using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace railwayReservation.Migrations
{
    public partial class addedjouenydateinpassengers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "journeyDate",
                table: "Passengers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "ticketId",
                keyValue: 1,
                columns: new[] { "bookedDate", "journeyDate" },
                values: new object[] { new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 2, 4, 22, 32, 22, 850, DateTimeKind.Local).AddTicks(9422) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "ticketId",
                keyValue: 2,
                column: "bookedDate",
                value: new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "journeyDate",
                table: "Passengers");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "ticketId",
                keyValue: 1,
                columns: new[] { "bookedDate", "journeyDate" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 1, 15, 4, 38, 98, DateTimeKind.Local).AddTicks(4791) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "ticketId",
                keyValue: 2,
                column: "bookedDate",
                value: new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
