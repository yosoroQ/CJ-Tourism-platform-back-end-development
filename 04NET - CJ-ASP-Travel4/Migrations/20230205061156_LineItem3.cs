using Microsoft.EntityFrameworkCore.Migrations;

namespace _04NET___CJ_ASP_Travel4.Migrations
{
    public partial class LineItem3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "308660dc-ae51-480f-824d-7dca6714c3e2",
                column: "ConcurrencyStamp",
                value: "ecee283d-8100-4f84-973b-8687d238afc7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90184155-dee0-40c9-bb1e-b5ed07afc04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22e24d54-eb3b-43ce-bfb7-3cca72a9d5ed", "AQAAAAEAACcQAAAAEBO9ILBkYs2dNtB7rH79uDzRwNqs1eSxsZkUfcbkVVmjgT8GKNsBTVCY6gDmeLmRLg==", "2bcc9ff2-85f2-427d-a6ca-5722c5375486" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "308660dc-ae51-480f-824d-7dca6714c3e2",
                column: "ConcurrencyStamp",
                value: "d0a7642b-031e-4e1e-9b15-8dfb94e5ac68");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90184155-dee0-40c9-bb1e-b5ed07afc04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eaf6c0cf-b0b8-4968-8283-25a89b9ebddc", "AQAAAAEAACcQAAAAEMH3bik/Wl8WAWcQadumdLn1cBp8rrlaUgdpIq0bjvAe0kVmKhOwCc68ZbKn8mncfw==", "520ab09b-749b-4a93-b58b-2b00974c5ddb" });
        }
    }
}
