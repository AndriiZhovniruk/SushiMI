using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sushimi.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedToTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "Id", "Category", "Name", "Price", "Weight" },
                values: new object[,]
                {
                    { 1, "Sushi", "California", 410, 300 },
                    { 2, "Sushi", "California with Tuna", 520, 290 },
                    { 3, "Sushi", "Enigma", 350, 300 },
                    { 4, "Sushi", "Sakura", 480, 290 },
                    { 5, "Sushi", "Felix with Crab", 380, 305 },
                    { 6, "Sushi", "Itachi", 390, 320 },
                    { 7, "Sushi", "Red Dragon", 530, 325 },
                    { 8, "Sushi", "Fiadelfia", 400, 320 },
                    { 9, "Sets", "set 1", 1035, 600 },
                    { 10, "Sets", "set 2", 1540, 895 },
                    { 11, "Sets", "set 3", 1265, 950 },
                    { 12, "Sets", "set 4", 3300, 2100 },
                    { 13, "Sets", "set 5", 2280, 1600 },
                    { 14, "Sets", "set 6", 1320, 650 },
                    { 15, "Hot", "Beef udon noodles", 169, 260 },
                    { 16, "Hot", "Funchoza with seafood", 245, 250 },
                    { 17, "Hot", "Unagi chicken with rice", 155, 280 },
                    { 18, "Hot", "Udon noodles with prawns", 245, 370 },
                    { 19, "Snaks", "Inari", 140, 65 },
                    { 20, "Snaks", "Sashimi", 480, 155 },
                    { 21, "Snaks", "Tatar", 360, 150 },
                    { 22, "Snaks", "Chuka", 230, 185 },
                    { 23, "Drinks", "Coca-Cola", 35, 5 },
                    { 24, "Drinks", "Fanta", 35, 5 },
                    { 25, "Drinks", "Sprite", 35, 5 },
                    { 26, "Drinks", "Dr-Pepper", 40, 5 },
                    { 27, "Drinks", "Morshinkska", 35, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 27);
        }
    }
}
