using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RenamedProductCategoriesTableAndAddedBrandTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductCategoryId",
                table: "Products");

            migrationBuilder.AddColumn<Guid>(
                name: "BrandId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true,
                comment: "Foreign key of the brand");

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true,
                comment: "Foreign key of the category");

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The unique identifier for the brand."),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                },
                comment: "Holds info for the Brand entity");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Primary key of the product category"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Name of the product category")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                },
                comment: "Holds info for the Product Category entity");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("753efde4-efa1-4f88-abc9-8f091cf8b670"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e14981fd-221c-48b8-9ea8-dd857d95e766", "AQAAAAIAAYagAAAAEBlJ9p19AaZTOPO/0Q+pL2OQ4do20z8/DUKsvkfmXLo9PPtnsZmfg/Ce4e3EmJptBQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1f0890a3-91db-49bf-975c-bdfb1bda5178", "AQAAAAIAAYagAAAAEEwPOTaEN7fpZN8U/u+qUDT0ePLAb7FDWrWDohODyFe3LPTcjnCgtwb3wFoxqD6jMA==" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("28f3d7f5-3469-4036-b919-ec683688314b"), "Tom Ford" },
                    { new Guid("361f69c3-cdfb-4156-a88a-1620db540c6c"), "Chanel" },
                    { new Guid("57d95637-ffa7-4109-9d26-03bae7e0e6e1"), "Yves Saint Laurent" },
                    { new Guid("586011c7-d606-4e73-a7e8-fca768656c03"), "Guerlain" },
                    { new Guid("6c86c626-bef8-4627-a314-de021502e335"), "Gucci" },
                    { new Guid("99f87405-5144-46e6-ad55-724d05928736"), "Viktor&Rolf" },
                    { new Guid("c3a935d2-8a70-40f4-aa02-7dc52d4688ed"), "Marc Jacobs" },
                    { new Guid("dc4a85cb-8f2d-452b-8027-c3409538c244"), "Hermès" },
                    { new Guid("dc6ccd03-c8c8-47a8-b9fe-83e878b158f8"), "Armani" },
                    { new Guid("f33371d7-fa64-42f0-89bd-7f707e285279"), "Creed" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("53146915-6199-44eb-aedb-e9902299be6c"), "Fragrances" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                columns: new[] { "BrandId", "CategoryId", "CreatedOn", "Name" },
                values: new object[] { new Guid("f33371d7-fa64-42f0-89bd-7f707e285279"), new Guid("53146915-6199-44eb-aedb-e9902299be6c"), new DateTime(2024, 3, 7, 23, 31, 38, 307, DateTimeKind.Utc).AddTicks(6893), "Aventus" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                columns: new[] { "BrandId", "CategoryId", "CreatedOn", "Name" },
                values: new object[] { new Guid("dc4a85cb-8f2d-452b-8027-c3409538c244"), new Guid("53146915-6199-44eb-aedb-e9902299be6c"), new DateTime(2024, 3, 7, 23, 31, 38, 307, DateTimeKind.Utc).AddTicks(6890), "Terre d'Hermès" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                columns: new[] { "BrandId", "CategoryId", "CreatedOn", "Name" },
                values: new object[] { new Guid("dc6ccd03-c8c8-47a8-b9fe-83e878b158f8"), new Guid("53146915-6199-44eb-aedb-e9902299be6c"), new DateTime(2024, 3, 7, 23, 31, 38, 307, DateTimeKind.Utc).AddTicks(6887), "Acqua di Gio" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                columns: new[] { "BrandId", "CategoryId", "CreatedOn", "Name" },
                values: new object[] { new Guid("28f3d7f5-3469-4036-b919-ec683688314b"), new Guid("53146915-6199-44eb-aedb-e9902299be6c"), new DateTime(2024, 3, 7, 23, 31, 38, 307, DateTimeKind.Utc).AddTicks(6884), "Black Orchid" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                columns: new[] { "BrandId", "CategoryId", "CreatedOn", "Name" },
                values: new object[] { new Guid("57d95637-ffa7-4109-9d26-03bae7e0e6e1"), new Guid("53146915-6199-44eb-aedb-e9902299be6c"), new DateTime(2024, 3, 7, 23, 31, 38, 307, DateTimeKind.Utc).AddTicks(6881), "Opium" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                columns: new[] { "BrandId", "CategoryId", "CreatedOn", "Name" },
                values: new object[] { new Guid("586011c7-d606-4e73-a7e8-fca768656c03"), new Guid("53146915-6199-44eb-aedb-e9902299be6c"), new DateTime(2024, 3, 7, 23, 31, 38, 307, DateTimeKind.Utc).AddTicks(6877), "Shalimar" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "BrandId", "CategoryId", "CreatedOn", "Name" },
                values: new object[] { new Guid("99f87405-5144-46e6-ad55-724d05928736"), new Guid("53146915-6199-44eb-aedb-e9902299be6c"), new DateTime(2024, 3, 7, 23, 31, 38, 307, DateTimeKind.Utc).AddTicks(6874), "Flowerbomb" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                columns: new[] { "BrandId", "CategoryId", "CreatedOn", "Name" },
                values: new object[] { new Guid("6c86c626-bef8-4627-a314-de021502e335"), new Guid("53146915-6199-44eb-aedb-e9902299be6c"), new DateTime(2024, 3, 7, 23, 31, 38, 307, DateTimeKind.Utc).AddTicks(6870), "Bloom" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                columns: new[] { "BrandId", "CategoryId", "CreatedOn", "Name" },
                values: new object[] { new Guid("c3a935d2-8a70-40f4-aa02-7dc52d4688ed"), new Guid("53146915-6199-44eb-aedb-e9902299be6c"), new DateTime(2024, 3, 7, 23, 31, 38, 307, DateTimeKind.Utc).AddTicks(6866), "Daisy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                columns: new[] { "BrandId", "CategoryId", "CreatedOn", "Name" },
                values: new object[] { new Guid("361f69c3-cdfb-4156-a88a-1620db540c6c"), new Guid("53146915-6199-44eb-aedb-e9902299be6c"), new DateTime(2024, 3, 7, 23, 31, 38, 307, DateTimeKind.Utc).AddTicks(6857), "No. 5" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Products_BrandId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                comment: "Manufacturer of the product");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductCategoryId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                comment: "Foreign key of the product category");

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Primary key of the product category"),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, comment: "Description of the product category"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Name of the product category")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                },
                comment: "Holds info for the Product Category entity");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("753efde4-efa1-4f88-abc9-8f091cf8b670"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4695e062-5309-472d-b842-af7ad8c4efc0", "AQAAAAIAAYagAAAAEB3bUAz5cG0wzpxbb1TPwr0qzWEthxdYcyUnlU4Dip7SFPIjk0XpszFiM4EU7BkcmQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1d6420e9-7e95-4228-83ba-4a5aef25e371", "AQAAAAIAAYagAAAAEFgFu1e9J0+OQfPo/lmEuaRdtnyQHMO4lZ6zyDTzGtbinARVeirLzFm8nyzqnKAcsQ==" });

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                columns: new[] { "CreatedOn", "Manufacturer", "Name", "ProductCategoryId" },
                values: new object[] { new DateTime(2024, 3, 5, 21, 3, 42, 537, DateTimeKind.Utc).AddTicks(7765), "Creed", "Aventus by Creed", new Guid("53146915-6199-44eb-aedb-e9902299be6f") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                columns: new[] { "CreatedOn", "Manufacturer", "Name", "ProductCategoryId" },
                values: new object[] { new DateTime(2024, 3, 5, 21, 3, 42, 537, DateTimeKind.Utc).AddTicks(7762), "Hermès", "Terre d'Hermès by Hermès", new Guid("53146915-6199-44eb-aedb-e9902299be6f") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                columns: new[] { "CreatedOn", "Manufacturer", "Name", "ProductCategoryId" },
                values: new object[] { new DateTime(2024, 3, 5, 21, 3, 42, 537, DateTimeKind.Utc).AddTicks(7760), "Giorgio Armani", "Acqua di Gio by Giorgio Armani", new Guid("53146915-6199-44eb-aedb-e9902299be6e") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                columns: new[] { "CreatedOn", "Manufacturer", "Name", "ProductCategoryId" },
                values: new object[] { new DateTime(2024, 3, 5, 21, 3, 42, 537, DateTimeKind.Utc).AddTicks(7757), "Tom Ford", "Black Orchid by Tom Ford", new Guid("53146915-6199-44eb-aedb-e9902299be6e") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                columns: new[] { "CreatedOn", "Manufacturer", "Name", "ProductCategoryId" },
                values: new object[] { new DateTime(2024, 3, 5, 21, 3, 42, 537, DateTimeKind.Utc).AddTicks(7754), "Yves Saint Laurent", "Opium by Yves Saint Laurent", new Guid("53146915-6199-44eb-aedb-e9902299be6e") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                columns: new[] { "CreatedOn", "Manufacturer", "Name", "ProductCategoryId" },
                values: new object[] { new DateTime(2024, 3, 5, 21, 3, 42, 537, DateTimeKind.Utc).AddTicks(7748), "Guerlain", "Shalimar by Guerlain", new Guid("53146915-6199-44eb-aedb-e9902299be6d") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "CreatedOn", "Manufacturer", "Name", "ProductCategoryId" },
                values: new object[] { new DateTime(2024, 3, 5, 21, 3, 42, 537, DateTimeKind.Utc).AddTicks(7746), "Viktor&Rolf", "Viktor&Rolf Flowerbomb", new Guid("53146915-6199-44eb-aedb-e9902299be6c") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                columns: new[] { "CreatedOn", "Manufacturer", "Name", "ProductCategoryId" },
                values: new object[] { new DateTime(2024, 3, 5, 21, 3, 42, 537, DateTimeKind.Utc).AddTicks(7743), "Gucci", "Gucci Bloom", new Guid("53146915-6199-44eb-aedb-e9902299be6c") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                columns: new[] { "CreatedOn", "Manufacturer", "Name", "ProductCategoryId" },
                values: new object[] { new DateTime(2024, 3, 5, 21, 3, 42, 537, DateTimeKind.Utc).AddTicks(7740), "Marc Jacobs", "Marc Jacobs Daisy", new Guid("53146915-6199-44eb-aedb-e9902299be6c") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                columns: new[] { "CreatedOn", "Manufacturer", "Name", "ProductCategoryId" },
                values: new object[] { new DateTime(2024, 3, 5, 21, 3, 42, 537, DateTimeKind.Utc).AddTicks(7732), "Chanel", "Chanel No. 5", new Guid("53146915-6199-44eb-aedb-e9902299be6c") });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
