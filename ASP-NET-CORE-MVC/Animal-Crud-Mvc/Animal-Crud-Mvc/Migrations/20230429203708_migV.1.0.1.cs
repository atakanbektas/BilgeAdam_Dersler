using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Animal_Crud_Mvc.Migrations
{
    public partial class migV101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hayvanlar",
                keyColumn: "Id",
                keyValue: 1,
                column: "ResimYolu",
                value: "aslan.png");

            migrationBuilder.UpdateData(
                table: "Hayvanlar",
                keyColumn: "Id",
                keyValue: 2,
                column: "ResimYolu",
                value: "cita.png");

            migrationBuilder.UpdateData(
                table: "Hayvanlar",
                keyColumn: "Id",
                keyValue: 3,
                column: "ResimYolu",
                value: "kedi.png");

            migrationBuilder.UpdateData(
                table: "Hayvanlar",
                keyColumn: "Id",
                keyValue: 4,
                column: "ResimYolu",
                value: "kopek.png");

            migrationBuilder.UpdateData(
                table: "Hayvanlar",
                keyColumn: "Id",
                keyValue: 5,
                column: "ResimYolu",
                value: "kopek-baligi.png");

            migrationBuilder.UpdateData(
                table: "Hayvanlar",
                keyColumn: "Id",
                keyValue: 6,
                column: "ResimYolu",
                value: "mavi-yengec.png");

            migrationBuilder.UpdateData(
                table: "Hayvanlar",
                keyColumn: "Id",
                keyValue: 7,
                column: "ResimYolu",
                value: "maymun.png");

            migrationBuilder.UpdateData(
                table: "Hayvanlar",
                keyColumn: "Id",
                keyValue: 8,
                column: "ResimYolu",
                value: "tavsan.png");

            migrationBuilder.UpdateData(
                table: "Hayvanlar",
                keyColumn: "Id",
                keyValue: 9,
                column: "ResimYolu",
                value: "zurafa.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hayvanlar",
                keyColumn: "Id",
                keyValue: 1,
                column: "ResimYolu",
                value: "~/pictures/aslan.png");

            migrationBuilder.UpdateData(
                table: "Hayvanlar",
                keyColumn: "Id",
                keyValue: 2,
                column: "ResimYolu",
                value: "~/pictures/cita.png");

            migrationBuilder.UpdateData(
                table: "Hayvanlar",
                keyColumn: "Id",
                keyValue: 3,
                column: "ResimYolu",
                value: "~/pictures/kedi.png");

            migrationBuilder.UpdateData(
                table: "Hayvanlar",
                keyColumn: "Id",
                keyValue: 4,
                column: "ResimYolu",
                value: "~/pictures/kopek.png");

            migrationBuilder.UpdateData(
                table: "Hayvanlar",
                keyColumn: "Id",
                keyValue: 5,
                column: "ResimYolu",
                value: "~/pictures/kopek-baligi.png");

            migrationBuilder.UpdateData(
                table: "Hayvanlar",
                keyColumn: "Id",
                keyValue: 6,
                column: "ResimYolu",
                value: "~/pictures/mavi-yengec.png");

            migrationBuilder.UpdateData(
                table: "Hayvanlar",
                keyColumn: "Id",
                keyValue: 7,
                column: "ResimYolu",
                value: "~/pictures/maymun.png");

            migrationBuilder.UpdateData(
                table: "Hayvanlar",
                keyColumn: "Id",
                keyValue: 8,
                column: "ResimYolu",
                value: "~/pictures/tavsan.png");

            migrationBuilder.UpdateData(
                table: "Hayvanlar",
                keyColumn: "Id",
                keyValue: 9,
                column: "ResimYolu",
                value: "~/pictures/zurafa.png");
        }
    }
}
