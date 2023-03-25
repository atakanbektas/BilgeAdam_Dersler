using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WFA_MostPopularCities.Migrations
{
    /// <inheritdoc />
    public partial class Migs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId");
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "Name" },
                values: new object[,]
                {
                    { 1, "Adana" },
                    { 6, "Ankara" },
                    { 61, "Trabzon" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CityId", "Name" },
                values: new object[,]
                {
                    { 1, 6, "Keçi" },
                    { 2, 1, "Şırdan" },
                    { 3, 1, "Aykut Bey" },
                    { 4, 61, "Tereyağ" },
                    { 5, 61, "Ekmek" }
                });

            migrationBuilder.CreateIndex(
                name: "CityName",
                table: "Cities",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CityId",
                table: "Products",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "ProductName",
                table: "Products",
                column: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
