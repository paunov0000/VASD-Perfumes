using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedImageUrlToProductEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("53146915-6199-44eb-aedb-e9902299be6c"), "Floral scents are the most popular and widely used perfume family. Floral perfumes are feminine, romantic, and ultra-feminine.", "Floral" },
                    { new Guid("53146915-6199-44eb-aedb-e9902299be6d"), "Oriental perfumes are warm, sensual, and exotic. They are often described as spicy, sweet, and even opulent.", "Oriental" },
                    { new Guid("53146915-6199-44eb-aedb-e9902299be6e"), "Fresh perfumes are often referred to as citrus or green. They are light, airy, and clean.", "Fresh" },
                    { new Guid("53146915-6199-44eb-aedb-e9902299be6f"), "Woody perfumes are warm, earthy, and sensual. They are often described as musky, aromatic, and spicy.", "Woody" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Manufacturer", "Name", "OrderId", "Price", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"), "Fresh and fruity scent with notes of pineapple and blackcurrant", "https://creedboutique.com/cdn/shop/files/aventus-100ml-bottle_3413e5f4-3eee-40b3-8451-2546a370ec5b.jpg?v=1700498936&width=1500", "Creed", "Aventus by Creed", null, 250.00m, new Guid("53146915-6199-44eb-aedb-e9902299be6f") },
                    { new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"), "Citrusy and woody fragrance with notes of grapefruit and cedar", "https://www.sephora.com/productimages/sku/s915447-main-zoom.jpg?imwidth=612", "Hermès", "Terre d'Hermès by Hermès", null, 120.00m, new Guid("53146915-6199-44eb-aedb-e9902299be6f") },
                    { new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"), "Fresh and aquatic scent with notes of citrus and rosemary", "https://www.sephora.com/productimages/sku/s397299-main-zoom.jpg?imwidth=612", "Giorgio Armani", "Acqua di Gio by Giorgio Armani", null, 85.00m, new Guid("53146915-6199-44eb-aedb-e9902299be6e") },
                    { new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"), "Luxurious blend of black truffle, vanilla, and orchid", "https://www.sephora.com/productimages/sku/s1007731-main-zoom.jpg?imwidth=612", "Tom Ford", "Black Orchid by Tom Ford", null, 180.00m, new Guid("53146915-6199-44eb-aedb-e9902299be6e") },
                    { new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"), "Rich and spicy oriental fragrance with exotic undertones", "https://www.yslbeautyus.com/dw/image/v2/AANG_PRD/on/demandware.static/-/Sites-ysl-master-catalog/default/dwfd20b6ef/Fragrance/Fragrance/Opium_Eau_De_Toilette_Spray/3365440556386_Opium-Eau-De-Tpilette-Spray_01.jpg?sw=698&sh=698&sm=cut&sfrm=jpg&q=85", "Yves Saint Laurent", "Opium by Yves Saint Laurent", null, 100.00m, new Guid("53146915-6199-44eb-aedb-e9902299be6e") },
                    { new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"), "Timeless oriental scent with vanilla, iris, and amber notes", "https://douglas.bg/media/catalog/product/cache/dd4850ad4231b6306bceadf38a0bbeed/1/_/1_4439.jpg", "Guerlain", "Shalimar by Guerlain", null, 140.00m, new Guid("53146915-6199-44eb-aedb-e9902299be6d") },
                    { new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"), "Intensely floral with notes of jasmine, rose, and orchid", "https://www.sephora.com/productimages/sku/s1377159-main-zoom.jpg?imwidth=612", "Viktor&Rolf", "Viktor&Rolf Flowerbomb", null, 110.00m, new Guid("53146915-6199-44eb-aedb-e9902299be6c") },
                    { new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"), "Modern and vibrant floral bouquet featuring tuberose and jasmine", "https://www.sephora.com/productimages/sku/s1964832-main-zoom.jpg?imwidth=612", "Gucci", "Gucci Bloom", null, 150.00m, new Guid("53146915-6199-44eb-aedb-e9902299be6c") },
                    { new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"), "Youthful and fresh floral scent with notes of jasmine and violet", "https://www.sephora.com/productimages/sku/s1029958-main-zoom.jpg?imwidth=612", "Marc Jacobs", "Marc Jacobs Daisy", null, 80.00m, new Guid("53146915-6199-44eb-aedb-e9902299be6c") },
                    { new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"), "Iconic blend of rose and jasmine, a classic from luxury brand Chanel", "https://www.sephora.com/productimages/sku/s465690-main-zoom.jpg?imwidth=612", "Chanel", "Chanel No. 5", null, 120.00m, new Guid("53146915-6199-44eb-aedb-e9902299be6c") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("53146915-6199-44eb-aedb-e9902299be6c"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("53146915-6199-44eb-aedb-e9902299be6d"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("53146915-6199-44eb-aedb-e9902299be6e"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("53146915-6199-44eb-aedb-e9902299be6f"));

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Products");
        }
    }
}
