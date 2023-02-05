using Microsoft.EntityFrameworkCore.Migrations;

namespace _04NET___CJ_ASP_Travel4.Migrations
{
    public partial class LineItem2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "308660dc-ae51-480f-824d-7dca6714c3e2",
                column: "ConcurrencyStamp",
                value: "643cb1ea-fc9f-4226-a013-e1eed58e4f23");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90184155-dee0-40c9-bb1e-b5ed07afc04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fcc6552-f870-4dce-96d6-4a2521131081", "AQAAAAEAACcQAAAAEBXqL0UD+2fcDLQvhFgdrec4nBqdd8nZNO3L+/i+4W7sg8l8KDgUp99g6TvYhvdfAw==", "34bbd505-7ab8-49cd-be17-5174b8111865" });
        }
    }
}
