using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace railwayReservation.Migrations
{
    public partial class removedbookeduserfromtickets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Users_userId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_userId",
                table: "Tickets");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "ticketId",
                keyValue: 1,
                columns: new[] { "bookedDate", "journeyDate" },
                values: new object[] { new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 2, 5, 18, 50, 52, 796, DateTimeKind.Local).AddTicks(3102) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "ticketId",
                keyValue: 2,
                column: "bookedDate",
                value: new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_userId",
                table: "Tickets",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Users_userId",
                table: "Tickets",
                column: "userId",
                principalTable: "Users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
