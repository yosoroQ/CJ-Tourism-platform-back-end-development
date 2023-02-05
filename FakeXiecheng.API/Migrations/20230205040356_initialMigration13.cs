using Microsoft.EntityFrameworkCore.Migrations;

namespace _03NET___CJ_ASP_Travel3.Migrations
{
    public partial class initialMigration13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "308660dc-ae51-480f-824d-7dca6714c3e2",
                column: "ConcurrencyStamp",
                value: "595e2e30-01fa-4eac-8fbf-cefedc26af90");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90184155-dee0-40c9-bb1e-b5ed07afc04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d139a5d8-45bb-4dee-80b4-7d3987ff96f5", "AQAAAAEAACcQAAAAEE2XPAK2ebOe1kAjG0JdFpCNpbp7lWpaWhD3PzGFUOz4rXqGcmwkMumhPJ3UTP7ZYQ==", "b8a757cf-7f61-46bc-b9a6-a1b3d5789fd2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "308660dc-ae51-480f-824d-7dca6714c3e2",
                column: "ConcurrencyStamp",
                value: "e7275cfb-5541-4371-8722-7954011c4edf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90184155-dee0-40c9-bb1e-b5ed07afc04e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f70d196-989a-42aa-ac0b-fd6b78fff7d5", "AQAAAAEAACcQAAAAENW5bJaM4apYZBmOqcSOWVrQ1FGwKnmxVxh3OfyrpDXAUiT76MFH2iaokzsTVurn7w==", "d49a2020-cd07-4812-b397-4545bbbe8ca5" });
        }
    }
}
