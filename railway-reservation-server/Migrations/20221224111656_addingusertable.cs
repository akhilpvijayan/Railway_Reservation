using Microsoft.EntityFrameworkCore.Migrations;

namespace railwayReservation.Migrations
{
    public partial class addingusertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userAge = table.Column<int>(type: "int", nullable: false),
                    userEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userAadhar = table.Column<long>(type: "bigint", nullable: false),
                    userMobile = table.Column<long>(type: "bigint", nullable: false),
                    userCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userPin = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
