using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace railwayReservation.Migrations
{
    public partial class Added_Migrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    seatTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    seatType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fare = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.seatTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Trains",
                columns: table => new
                {
                    trainId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    trainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    destination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    generalSeats = table.Column<int>(type: "int", nullable: false),
                    ACSeats = table.Column<int>(type: "int", nullable: false),
                    semiSleeperSeats = table.Column<int>(type: "int", nullable: false),
                    sleeperSeats = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trains", x => x.trainId);
                });

            migrationBuilder.CreateTable(
                name: "Stations",
                columns: table => new
                {
                    stationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    stationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trainNo = table.Column<int>(type: "int", nullable: false),
                    arrivalTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    depatureTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stations", x => x.stationId);
                    table.ForeignKey(
                        name: "FK_Stations_Trains_trainNo",
                        column: x => x.trainNo,
                        principalTable: "Trains",
                        principalColumn: "trainId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    ticketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ticketNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ticketStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userId = table.Column<int>(type: "int", nullable: false),
                    bookedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    journeyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ticketFare = table.Column<int>(type: "int", nullable: false),
                    trainId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.ticketId);
                    table.ForeignKey(
                        name: "FK_Tickets_Trains_trainId",
                        column: x => x.trainId,
                        principalTable: "Trains",
                        principalColumn: "trainId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Passengers",
                columns: table => new
                {
                    passengerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    passengerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pnrNo = table.Column<long>(type: "bigint", nullable: false),
                    passengerAge = table.Column<int>(type: "int", nullable: false),
                    passengerGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bookedUser = table.Column<int>(type: "int", nullable: false),
                    reservationStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seatNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ticketId = table.Column<int>(type: "int", nullable: false),
                    startingPoint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    destination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seatClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.passengerId);
                    table.ForeignKey(
                        name: "FK_Passengers_Seats_seatClassId",
                        column: x => x.seatClassId,
                        principalTable: "Seats",
                        principalColumn: "seatTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Passengers_Tickets_ticketId",
                        column: x => x.ticketId,
                        principalTable: "Tickets",
                        principalColumn: "ticketId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_seatClassId",
                table: "Passengers",
                column: "seatClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_ticketId",
                table: "Passengers",
                column: "ticketId");

            migrationBuilder.CreateIndex(
                name: "IX_Stations_trainNo",
                table: "Stations",
                column: "trainNo");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_trainId",
                table: "Tickets",
                column: "trainId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_userId",
                table: "Tickets",
                column: "userId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Passengers");

            migrationBuilder.DropTable(
                name: "Stations");

            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Trains");
        }
    }
}
