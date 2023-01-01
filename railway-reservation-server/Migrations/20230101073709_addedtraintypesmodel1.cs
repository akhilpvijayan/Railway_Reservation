using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace railwayReservation.Migrations
{
    public partial class addedtraintypesmodel1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Traintypes",
                columns: table => new
                {
                    trainTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    trainType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traintypes", x => x.trainTypeId);
                });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "ticketId",
                keyValue: 1,
                column: "journeyDate",
                value: new DateTime(2023, 1, 1, 13, 7, 8, 209, DateTimeKind.Local).AddTicks(1391));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Traintypes");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "ticketId",
                keyValue: 1,
                column: "journeyDate",
                value: new DateTime(2023, 1, 1, 13, 4, 32, 874, DateTimeKind.Local).AddTicks(5085));
        }
    }
}
