using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _11.IdentityUygulama.Migrations
{
    public partial class v101_ADDROLES : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "62ca7216-7802-40ae-ba00-8ad77e247d00", "21ae53df-4664-4663-8a7d-b42c04241ac5", "Yönetici", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "785caf3c-1d01-4b2a-9cf8-a779a9c8fab2", "5612e4a5-0052-43e1-94f0-1ccf81911976", "Normal Kullanıcı", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e2627260-f8bc-4ea3-ae05-5b9e9237ef6a", "8a5d48dd-65d6-4b80-b443-31fcd07c00b1", "Editör", "EDITOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62ca7216-7802-40ae-ba00-8ad77e247d00");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "785caf3c-1d01-4b2a-9cf8-a779a9c8fab2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2627260-f8bc-4ea3-ae05-5b9e9237ef6a");
        }
    }
}
