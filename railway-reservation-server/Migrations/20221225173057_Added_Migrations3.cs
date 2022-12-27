using Microsoft.EntityFrameworkCore.Migrations;

namespace railwayReservation.Migrations
{
    public partial class Added_Migrations3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "seatTypeId", "fare", "seatType" },
                values: new object[,]
                {
                    { 1, 85, "AC" },
                    { 2, 55, "Sleeper" },
                    { 3, 45, "SemiSleeper" },
                    { 4, 25, "General" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatTypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatTypeId",
                keyValue: 4);
        }
    }
}
