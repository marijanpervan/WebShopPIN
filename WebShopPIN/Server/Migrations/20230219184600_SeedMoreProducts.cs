using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopPIN.Server.Migrations
{
    public partial class SeedMoreProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 7, 3, "The Patek Philippe Nautilus is an iconic luxury sports watch that has become a symbol of style and status among watch enthusiasts. Designed by the legendary watch designer Gérald Genta in the 1970s, the Nautilus has a distinctive shape that resembles a porthole on a ship, with a rounded octagonal bezel and integrated bracelet.", "https://static.patek.com/images/articles/face_white/350/5740_1G_001_1.jpg", 34000m, "Patek Philippe Nautilus" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 8, 3, "The Calatrava is the quintessential dress watch, with a timeless, classic design that has remained largely unchanged since its introduction in 1932. The watch features a round case, simple but elegant dial with a small seconds sub-dial, and thin, tapered hour markers. The Calatrava is available in a range of materials, from stainless steel to precious metals such as gold and platinum, and with a variety of dial colors and textures. The watch is hand-wound and has a relatively slim profile, making it an ideal choice for dressier occasions.", "https://www.swissluxury.com/product_images/5196G_001.jpg", 60000m, "Patek Philippe Calatrava" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 9, 3, "The Aquanaut is a sportier and more contemporary alternative to the Nautilus, featuring a distinctive rounded octagonal case and an integrated rubber strap. The watch has a bold and modern design, with a range of dial colors, including black, blue, and brown, and luminescent hands and hour markers for enhanced legibility in low-light conditions. The Aquanaut is water-resistant to 120 meters and is equipped with a self-winding movement with a power reserve of up to 45 hours.", "https://www.jewelsintime.com/wp-content/uploads/2022/12/jit_221222-071407_1853228860.jpg", 96000m, "Patek Philippe Aquanaut" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { 4, "Jaeger - LeCoultre", "jaeger" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { 5, "TAG Heuer", "tagheuer" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { 6, "Hublot", "hublot" });
        }
    }
}
