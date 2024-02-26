using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "First name of the ApplicationUser"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Last name of the ApplicationUser"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of creating the ApplicationUser"),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                },
                comment: "Holds info for the Application User entity");

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Primary key of the product category"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Name of the product category"),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, comment: "Description of the product category")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                },
                comment: "Holds info for the Product Category entity");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Primary key of the customer"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Address of the Customer entity"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "City of the Customer entity"),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "State of the Customer entity"),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Zip of the Customer entity"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Foreign key to the ApplicationUser entity")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Holds info for the Customer entity");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Primary key of the product"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Name of the product"),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, comment: "Description of the product"),
                    Manufacturer = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Manufacturer of the product"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Price of the product"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Image URL of the product"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the product creation"),
                    SoldCount = table.Column<int>(type: "int", nullable: false, comment: "Quantity of products sold"),
                    OnSale = table.Column<bool>(type: "bit", nullable: false, comment: "A flag which sets the product state whether its on sale or not"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "A flag which sets the product state as whether its visible or not"),
                    ProductCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Foreign key of the product category")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Holds info for the Product entity");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key of the order")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the order"),
                    Status = table.Column<int>(type: "int", nullable: false, comment: "Status of the order"),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Foreign key of the Customer")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Holds info for the Order entity");

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Primary key of the review"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Title of the review"),
                    Comment = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "Comment of the review"),
                    Rating = table.Column<int>(type: "int", nullable: false, comment: "Rating for the reviewed product"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the review"),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of updating the review"),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Foreign key of the product"),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Foreign key of the Customer")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Holds info for the Review entity");

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    OrdersId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => new { x.OrdersId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_OrderProduct_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "Id", "CreatedOn", "Description", "ImageUrl", "IsDeleted", "Manufacturer", "Name", "OnSale", "Price", "ProductCategoryId", "SoldCount" },
                values: new object[,]
                {
                    { new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"), new DateTime(2024, 2, 26, 19, 7, 44, 412, DateTimeKind.Utc).AddTicks(7309), "Fresh and fruity scent with notes of pineapple and blackcurrant", "https://creedboutique.com/cdn/shop/files/aventus-100ml-bottle_3413e5f4-3eee-40b3-8451-2546a370ec5b.jpg?v=1700498936&width=1500", false, "Creed", "Aventus by Creed", false, 250.00m, new Guid("53146915-6199-44eb-aedb-e9902299be6f"), 0 },
                    { new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"), new DateTime(2024, 2, 26, 19, 7, 44, 412, DateTimeKind.Utc).AddTicks(7306), "Citrusy and woody fragrance with notes of grapefruit and cedar", "https://www.sephora.com/productimages/sku/s915447-main-zoom.jpg?imwidth=612", false, "Hermès", "Terre d'Hermès by Hermès", false, 120.00m, new Guid("53146915-6199-44eb-aedb-e9902299be6f"), 0 },
                    { new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"), new DateTime(2024, 2, 26, 19, 7, 44, 412, DateTimeKind.Utc).AddTicks(7304), "Fresh and aquatic scent with notes of citrus and rosemary", "https://www.sephora.com/productimages/sku/s397299-main-zoom.jpg?imwidth=612", false, "Giorgio Armani", "Acqua di Gio by Giorgio Armani", false, 85.00m, new Guid("53146915-6199-44eb-aedb-e9902299be6e"), 0 },
                    { new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"), new DateTime(2024, 2, 26, 19, 7, 44, 412, DateTimeKind.Utc).AddTicks(7302), "Luxurious blend of black truffle, vanilla, and orchid", "https://www.sephora.com/productimages/sku/s1007731-main-zoom.jpg?imwidth=612", false, "Tom Ford", "Black Orchid by Tom Ford", false, 180.00m, new Guid("53146915-6199-44eb-aedb-e9902299be6e"), 0 },
                    { new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"), new DateTime(2024, 2, 26, 19, 7, 44, 412, DateTimeKind.Utc).AddTicks(7299), "Rich and spicy oriental fragrance with exotic undertones", "https://www.yslbeautyus.com/dw/image/v2/AANG_PRD/on/demandware.static/-/Sites-ysl-master-catalog/default/dwfd20b6ef/Fragrance/Fragrance/Opium_Eau_De_Toilette_Spray/3365440556386_Opium-Eau-De-Tpilette-Spray_01.jpg?sw=698&sh=698&sm=cut&sfrm=jpg&q=85", false, "Yves Saint Laurent", "Opium by Yves Saint Laurent", false, 100.00m, new Guid("53146915-6199-44eb-aedb-e9902299be6e"), 0 },
                    { new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"), new DateTime(2024, 2, 26, 19, 7, 44, 412, DateTimeKind.Utc).AddTicks(7294), "Timeless oriental scent with vanilla, iris, and amber notes", "https://douglas.bg/media/catalog/product/cache/dd4850ad4231b6306bceadf38a0bbeed/1/_/1_4439.jpg", false, "Guerlain", "Shalimar by Guerlain", false, 140.00m, new Guid("53146915-6199-44eb-aedb-e9902299be6d"), 0 },
                    { new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"), new DateTime(2024, 2, 26, 19, 7, 44, 412, DateTimeKind.Utc).AddTicks(7292), "Intensely floral with notes of jasmine, rose, and orchid", "https://www.sephora.com/productimages/sku/s1377159-main-zoom.jpg?imwidth=612", false, "Viktor&Rolf", "Viktor&Rolf Flowerbomb", false, 110.00m, new Guid("53146915-6199-44eb-aedb-e9902299be6c"), 0 },
                    { new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"), new DateTime(2024, 2, 26, 19, 7, 44, 412, DateTimeKind.Utc).AddTicks(7290), "Modern and vibrant floral bouquet featuring tuberose and jasmine", "https://www.sephora.com/productimages/sku/s1964832-main-zoom.jpg?imwidth=612", false, "Gucci", "Gucci Bloom", false, 150.00m, new Guid("53146915-6199-44eb-aedb-e9902299be6c"), 0 },
                    { new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"), new DateTime(2024, 2, 26, 19, 7, 44, 412, DateTimeKind.Utc).AddTicks(7287), "Youthful and fresh floral scent with notes of jasmine and violet", "https://www.sephora.com/productimages/sku/s1029958-main-zoom.jpg?imwidth=612", false, "Marc Jacobs", "Marc Jacobs Daisy", false, 80.00m, new Guid("53146915-6199-44eb-aedb-e9902299be6c"), 0 },
                    { new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"), new DateTime(2024, 2, 26, 19, 7, 44, 412, DateTimeKind.Utc).AddTicks(7278), "Iconic blend of rose and jasmine, a classic from luxury brand Chanel", "https://www.sephora.com/productimages/sku/s465690-main-zoom.jpg?imwidth=612", false, "Chanel", "Chanel No. 5", false, 120.00m, new Guid("53146915-6199-44eb-aedb-e9902299be6c"), 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserId",
                table: "Customers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductsId",
                table: "OrderProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CustomerId",
                table: "Reviews",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
