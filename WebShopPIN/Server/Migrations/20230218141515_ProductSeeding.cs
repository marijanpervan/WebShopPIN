using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopPIN.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "The Rolex Oyster Perpetual Date GMT Master is part of the Rolex Professional Watch Collection. Designed in collaboration with the now defunct Pan American Airways of the United States for use by their pilots and navigators, it was launched in 1954.", "https://sep.yimg.com/ay/movadobaby/rolex-oyster-perpetual-gmt-master-ii-116710-120.jpg", 49.000m, "Rolex GMT Master II" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Rolex introduced the “Cosmograph Daytona” in 1963, ten years after introducing their first Oyster-case chronograph model. The watch featured the Cosmograph name on the dial, and Rolex chose to connect it with auto racing due to the tachymeter printed on the bezel. This was a distinct departure from previous Rolex chronographs, which located any such markings under the crystal, and became the signature feature of the Cosmograph model.", "https://www.uhren-wiki.com/images/Rolex_Oyster_Perpetual_Cosmograph_Daytona.jpg", 36.000m, "Rolex Daytona Cosmograph" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "The Rolex Oyster Perpetual Submariner is a line of sports watches designed for diving and manufactured by Rolex, resistant to water and corrosion. The first Submariner was introduced to the public in 1954 at the Basel Watch Fair. It was the first watch to be waterproof up to 100m. The Rolex Submariner is considered 'a classic among wristwatches' manufactured by one of the most widely recognized luxury brands in the world. Due to its huge popularity, there are many homage watches by well-established watchmakers, as well as illegal counterfeits. The Rolex Submariner is part of Rolex's Oyster Perpetual line.", "https://upload.wikimedia.org/wikipedia/commons/c/cd/Rolex-Submariner.jpg", 22.000m, "Rolex Submariner" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
