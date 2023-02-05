using Microsoft.EntityFrameworkCore.Migrations;

namespace _03NET___CJ_ASP_Travel3.Migrations
{
    public partial class initialMigration11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8f70d196-989a-42aa-ac0b-fd6b78fff7d5", "admin@qq.com", "ADMIN@QQ.COM", "ADMIN@QQ.COM", "AQAAAAEAACcQAAAAENW5bJaM4apYZBmOqcSOWVrQ1FGwKnmxVxh3OfyrpDXAUiT76MFH2iaokzsTVurn7w==", "d49a2020-cd07-4812-b397-4545bbbe8ca5", "admin@qq.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "308660dc-ae51-480f-824d-7dca6714c3e2",
                column: "ConcurrencyStamp",
                value: "ef2f5808-6220-4c4e-88f6-14ff454c727d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90184155-dee0-40c9-bb1e-b5ed07afc04e",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "cb81f259-7f43-47ca-a808-3b71bbbd2b47", "admin@fakexicheng.com", "ADMIN@FAKEXICHENG.COM", "ADMIN@FAKEXICHENG.COM", "AQAAAAEAACcQAAAAECbuKznIpqjEMaEZ9MwYm834hug+9w/bcIO+NuVSJT4rQoTW0t/HdwxXIATfAa2Xhg==", "56d7590a-1473-4f4b-9cbb-35e9162f3590", "admin@fakexicheng.com" });
        }
    }
}
