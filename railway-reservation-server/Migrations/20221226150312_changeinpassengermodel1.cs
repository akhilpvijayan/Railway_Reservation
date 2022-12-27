using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace railwayReservation.Migrations
{
    public partial class changeinpassengermodel1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passengers_Tickets_ticketNumber",
                table: "Passengers");

            migrationBuilder.DropIndex(
                name: "IX_Passengers_ticketNumber",
                table: "Passengers");

            migrationBuilder.AlterColumn<string>(
                name: "ticketNumber",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "passengerId",
                keyValue: 1,
                column: "ticketNumber",
                value: "1");

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "passengerId",
                keyValue: 2,
                column: "ticketNumber",
                value: "2");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "ticketId",
                keyValue: 1,
                column: "journeyDate",
                value: new DateTime(2022, 12, 26, 20, 33, 11, 433, DateTimeKind.Local).AddTicks(6541));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ticketNumber",
                table: "Passengers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "passengerId",
                keyValue: 1,
                column: "ticketNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "passengerId",
                keyValue: 2,
                column: "ticketNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "ticketId",
                keyValue: 1,
                column: "journeyDate",
                value: new DateTime(2022, 12, 26, 20, 27, 19, 136, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_ticketNumber",
                table: "Passengers",
                column: "ticketNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Passengers_Tickets_ticketNumber",
                table: "Passengers",
                column: "ticketNumber",
                principalTable: "Tickets",
                principalColumn: "ticketId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
