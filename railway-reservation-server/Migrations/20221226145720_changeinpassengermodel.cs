using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace railwayReservation.Migrations
{
    public partial class changeinpassengermodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passengers_Seats_seatClassId",
                table: "Passengers");

            migrationBuilder.DropForeignKey(
                name: "FK_Passengers_Tickets_ticketId",
                table: "Passengers");

            migrationBuilder.DropIndex(
                name: "IX_Passengers_seatClassId",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "seatClassId",
                table: "Passengers");

            migrationBuilder.RenameColumn(
                name: "ticketId",
                table: "Passengers",
                newName: "ticketNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Passengers_ticketId",
                table: "Passengers",
                newName: "IX_Passengers_ticketNumber");

            migrationBuilder.AlterColumn<string>(
                name: "bookedUser",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "seatClass",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "passengerId",
                keyValue: 1,
                columns: new[] { "bookedUser", "seatClass" },
                values: new object[] { "2", "2" });

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "passengerId",
                keyValue: 2,
                columns: new[] { "bookedUser", "seatClass" },
                values: new object[] { "2", "4" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "ticketId",
                keyValue: 1,
                column: "journeyDate",
                value: new DateTime(2022, 12, 26, 20, 27, 19, 136, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.AddForeignKey(
                name: "FK_Passengers_Tickets_ticketNumber",
                table: "Passengers",
                column: "ticketNumber",
                principalTable: "Tickets",
                principalColumn: "ticketId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passengers_Tickets_ticketNumber",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "seatClass",
                table: "Passengers");

            migrationBuilder.RenameColumn(
                name: "ticketNumber",
                table: "Passengers",
                newName: "ticketId");

            migrationBuilder.RenameIndex(
                name: "IX_Passengers_ticketNumber",
                table: "Passengers",
                newName: "IX_Passengers_ticketId");

            migrationBuilder.AlterColumn<int>(
                name: "bookedUser",
                table: "Passengers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "seatClassId",
                table: "Passengers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "passengerId",
                keyValue: 1,
                columns: new[] { "bookedUser", "seatClassId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "passengerId",
                keyValue: 2,
                columns: new[] { "bookedUser", "seatClassId" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "ticketId",
                keyValue: 1,
                column: "journeyDate",
                value: new DateTime(2022, 12, 26, 2, 9, 40, 543, DateTimeKind.Local).AddTicks(171));

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_seatClassId",
                table: "Passengers",
                column: "seatClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Passengers_Seats_seatClassId",
                table: "Passengers",
                column: "seatClassId",
                principalTable: "Seats",
                principalColumn: "seatTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Passengers_Tickets_ticketId",
                table: "Passengers",
                column: "ticketId",
                principalTable: "Tickets",
                principalColumn: "ticketId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
