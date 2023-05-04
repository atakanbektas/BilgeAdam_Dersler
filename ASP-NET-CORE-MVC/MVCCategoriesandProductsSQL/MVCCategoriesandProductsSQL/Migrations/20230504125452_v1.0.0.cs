using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCCategoriesandProductsSQL.Migrations
{
    public partial class v100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsInStock = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Photopath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Phone" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Computer" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Television" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "IsInStock", "Name", "Photopath", "Price" },
                values: new object[,]
                {
                    { 1, 2, true, "Hp", "//img/phone.png", 30000m },
                    { 2, 2, true, "MacBook", "//img/phone.png", 50000m },
                    { 3, 1, true, "Apple", "//img/tv.png", 20000m },
                    { 4, 1, true, "Xiaomi", "//img/phone.png", 12000m },
                    { 5, 3, true, "Samsung", "//img/phone.png", 27500m },
                    { 6, 3, true, "Vestel", "//img/tv.png", 32700m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
