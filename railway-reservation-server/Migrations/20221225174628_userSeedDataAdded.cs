using Microsoft.EntityFrameworkCore.Migrations;

namespace railwayReservation.Migrations
{
    public partial class userSeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "firstName", "lastName", "userAadhar", "userAddress", "userAge", "userCity", "userEmail", "userGender", "userMobile", "userName", "userPassword", "userPin", "userState" },
                values: new object[] { 1, "superuser", "", 839292029087L, "", 25, "Toronto", "superuser@yahoo.com", "Male", 9876178281L, "superuser", "superuser", 7382820L, "Ontario" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "firstName", "lastName", "userAadhar", "userAddress", "userAge", "userCity", "userEmail", "userGender", "userMobile", "userName", "userPassword", "userPin", "userState" },
                values: new object[] { 2, "John", "Blake", 839126729087L, "", 65, "Calgary", "john@yahoo.com", "Male", 1267178281L, "john", "john", 256718983L, "British Columbia" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "userId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "userId",
                keyValue: 2);
        }
    }
}
