using Microsoft.EntityFrameworkCore.Migrations;

namespace railwayReservation.Migrations
{
    public partial class Added_Migrations2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stations_Trains_trainNo",
                table: "Stations");

            migrationBuilder.RenameColumn(
                name: "trainNo",
                table: "Stations",
                newName: "trainId");

            migrationBuilder.RenameIndex(
                name: "IX_Stations_trainNo",
                table: "Stations",
                newName: "IX_Stations_trainId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stations_Trains_trainId",
                table: "Stations",
                column: "trainId",
                principalTable: "Trains",
                principalColumn: "trainId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stations_Trains_trainId",
                table: "Stations");

            migrationBuilder.RenameColumn(
                name: "trainId",
                table: "Stations",
                newName: "trainNo");

            migrationBuilder.RenameIndex(
                name: "IX_Stations_trainId",
                table: "Stations",
                newName: "IX_Stations_trainNo");

            migrationBuilder.AddForeignKey(
                name: "FK_Stations_Trains_trainNo",
                table: "Stations",
                column: "trainNo",
                principalTable: "Trains",
                principalColumn: "trainId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
