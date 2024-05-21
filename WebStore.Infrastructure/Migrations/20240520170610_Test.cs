using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Subcategories_SubcategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Subcategories");

            migrationBuilder.DropIndex(
                name: "IX_Products_SubcategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SubcategoryId",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "BaseNotes",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ChildSubcategoryId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MiddleNotes",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ParentSubcategoryId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true,
                comment: "Foreign key of the ParentSubcategory");

            migrationBuilder.AddColumn<string>(
                name: "TopNotes",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ChildSubcategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChildSubcategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChildSubcategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ParentSubcategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Primary key of the product subcategory"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Name of the product subcategory"),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Foreign key to the Category entity"),
                    ChildSubcategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentSubcategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParentSubcategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParentSubcategories_ChildSubcategories_ChildSubcategoryId",
                        column: x => x.ChildSubcategoryId,
                        principalTable: "ChildSubcategories",
                        principalColumn: "Id");
                },
                comment: "Holds info for the Product Subcategory entity");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("753efde4-efa1-4f88-abc9-8f091cf8b670"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3b074d01-4269-4691-b2e6-81f4ff6f2e79", "AQAAAAIAAYagAAAAENln4PwqW1DbrLOspg7VnQSCkFA19kxDtfDHHJXaq/ejHC+ldKNo15sKOKrENroYdw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c1051480-d32b-4899-bab1-2ede0467a7db", "AQAAAAIAAYagAAAAEJZJwBuHbgCwyi//qir5gOBs5IXhWjKKZ671L9dri5QpxpBeM8rE3fuRHfFL9/fn9Q==" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 5, 20, 17, 6, 9, 960, DateTimeKind.Utc).AddTicks(8000));

            migrationBuilder.InsertData(
                table: "ParentSubcategories",
                columns: new[] { "Id", "CategoryId", "ChildSubcategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("45c73d43-2499-422e-a5b5-5f0086331e51"), new Guid("53146915-6199-44eb-aedb-e9902299be6c"), null, "Unisex" },
                    { new Guid("5f1efcf7-0a16-4079-ae7f-aebbd4f5ca3b"), new Guid("53146915-6199-44eb-aedb-e9902299be6c"), null, "Men" },
                    { new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2"), new Guid("53146915-6199-44eb-aedb-e9902299be6c"), null, "Women" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                columns: new[] { "BaseNotes", "ChildSubcategoryId", "CreatedOn", "MiddleNotes", "ParentSubcategoryId", "TopNotes" },
                values: new object[] { null, null, new DateTime(2024, 5, 20, 17, 6, 9, 834, DateTimeKind.Utc).AddTicks(3340), null, new Guid("45c73d43-2499-422e-a5b5-5f0086331e51"), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                columns: new[] { "BaseNotes", "ChildSubcategoryId", "CreatedOn", "MiddleNotes", "ParentSubcategoryId", "TopNotes" },
                values: new object[] { null, null, new DateTime(2024, 5, 20, 17, 6, 9, 834, DateTimeKind.Utc).AddTicks(3334), null, new Guid("5f1efcf7-0a16-4079-ae7f-aebbd4f5ca3b"), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                columns: new[] { "BaseNotes", "ChildSubcategoryId", "CreatedOn", "MiddleNotes", "ParentSubcategoryId", "TopNotes" },
                values: new object[] { null, null, new DateTime(2024, 5, 20, 17, 6, 9, 834, DateTimeKind.Utc).AddTicks(3330), null, new Guid("5f1efcf7-0a16-4079-ae7f-aebbd4f5ca3b"), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                columns: new[] { "BaseNotes", "ChildSubcategoryId", "CreatedOn", "MiddleNotes", "ParentSubcategoryId", "TopNotes" },
                values: new object[] { "Mexican Chocolate, Patchouli, Vanille, Incense, Amber, Sandalwood, Vetiver, White Musk", null, new DateTime(2024, 5, 20, 17, 6, 9, 834, DateTimeKind.Utc).AddTicks(3326), "Orchid, Spices, Gardenia, Fruity Notes, Ylang-Ylang, Jasmine, Lostus", new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2"), "Truffle, Gardenia, Black Currant, Ylang-Ylang, Jasmine, Bergamot, Mandarin Orange, Amalfi Lemon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                columns: new[] { "BaseNotes", "ChildSubcategoryId", "CreatedOn", "MiddleNotes", "ParentSubcategoryId", "TopNotes" },
                values: new object[] { "Opoponax, Amber, Patchouli, Vanille", null, new DateTime(2024, 5, 20, 17, 6, 9, 834, DateTimeKind.Utc).AddTicks(3320), "Myrhh, Jasmine", new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2"), "Mandarin Orange, Bergamot, Lily-of-the-Valley" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                columns: new[] { "BaseNotes", "ChildSubcategoryId", "CreatedOn", "MiddleNotes", "ParentSubcategoryId", "TopNotes" },
                values: new object[] { null, null, new DateTime(2024, 5, 20, 17, 6, 9, 834, DateTimeKind.Utc).AddTicks(3314), null, new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2"), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "BaseNotes", "ChildSubcategoryId", "CreatedOn", "MiddleNotes", "ParentSubcategoryId", "TopNotes" },
                values: new object[] { null, null, new DateTime(2024, 5, 20, 17, 6, 9, 834, DateTimeKind.Utc).AddTicks(3310), null, new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2"), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                columns: new[] { "BaseNotes", "ChildSubcategoryId", "CreatedOn", "MiddleNotes", "ParentSubcategoryId", "TopNotes" },
                values: new object[] { "Orris Root, Honeysuckle", null, new DateTime(2024, 5, 20, 17, 6, 9, 834, DateTimeKind.Utc).AddTicks(3304), "Tuberose", new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2"), "Jasmine" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                columns: new[] { "BaseNotes", "ChildSubcategoryId", "CreatedOn", "MiddleNotes", "ParentSubcategoryId", "TopNotes" },
                values: new object[] { null, null, new DateTime(2024, 5, 20, 17, 6, 9, 834, DateTimeKind.Utc).AddTicks(3298), null, new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2"), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                columns: new[] { "BaseNotes", "ChildSubcategoryId", "CreatedOn", "MiddleNotes", "ParentSubcategoryId", "TopNotes" },
                values: new object[] { null, null, new DateTime(2024, 5, 20, 17, 6, 9, 834, DateTimeKind.Utc).AddTicks(3287), null, new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2"), null });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ParentSubcategoryId",
                table: "Products",
                column: "ParentSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ChildSubcategories_ProductId",
                table: "ChildSubcategories",
                column: "ProductId",
                unique: true,
                filter: "[ProductId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ParentSubcategories_CategoryId",
                table: "ParentSubcategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentSubcategories_ChildSubcategoryId",
                table: "ParentSubcategories",
                column: "ChildSubcategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ParentSubcategories_ParentSubcategoryId",
                table: "Products",
                column: "ParentSubcategoryId",
                principalTable: "ParentSubcategories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ParentSubcategories_ParentSubcategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ParentSubcategories");

            migrationBuilder.DropTable(
                name: "ChildSubcategories");

            migrationBuilder.DropIndex(
                name: "IX_Products_ParentSubcategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BaseNotes",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ChildSubcategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MiddleNotes",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ParentSubcategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TopNotes",
                table: "Products");

            migrationBuilder.AddColumn<Guid>(
                name: "SubcategoryId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                comment: "Foreign key of the Subcategory");

            migrationBuilder.CreateTable(
                name: "Subcategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Primary key of the product subcategory"),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Foreign key to the Category entity"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Name of the product subcategory")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subcategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subcategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Holds info for the Product Subcategory entity");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("753efde4-efa1-4f88-abc9-8f091cf8b670"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "735b4afb-ebfd-41bc-9ec2-35fa96836dfa", "AQAAAAIAAYagAAAAEJL1amf6Qd7C0z/GNB+EGiWTWI4VFnWJUL7buIdPAFPwQlGa+uxl167lGJmgNvP+oQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2a550f29-169a-42fb-a625-52d9376753c0", "AQAAAAIAAYagAAAAEN5MbjdYrBPJaAI3hzgkbHTpIR84qGGcUft6om2s2I8fK3lKfHGpmMJ0fEXIT5jdTQ==" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 4, 17, 9, 41, 49, 783, DateTimeKind.Utc).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                columns: new[] { "CreatedOn", "SubcategoryId" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 41, 49, 637, DateTimeKind.Utc).AddTicks(9731), new Guid("45c73d43-2499-422e-a5b5-5f0086331e51") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                columns: new[] { "CreatedOn", "SubcategoryId" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 41, 49, 637, DateTimeKind.Utc).AddTicks(9725), new Guid("5f1efcf7-0a16-4079-ae7f-aebbd4f5ca3b") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                columns: new[] { "CreatedOn", "SubcategoryId" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 41, 49, 637, DateTimeKind.Utc).AddTicks(9720), new Guid("5f1efcf7-0a16-4079-ae7f-aebbd4f5ca3b") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                columns: new[] { "CreatedOn", "SubcategoryId" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 41, 49, 637, DateTimeKind.Utc).AddTicks(9716), new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                columns: new[] { "CreatedOn", "SubcategoryId" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 41, 49, 637, DateTimeKind.Utc).AddTicks(9712), new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                columns: new[] { "CreatedOn", "SubcategoryId" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 41, 49, 637, DateTimeKind.Utc).AddTicks(9661), new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "CreatedOn", "SubcategoryId" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 41, 49, 637, DateTimeKind.Utc).AddTicks(9657), new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                columns: new[] { "CreatedOn", "SubcategoryId" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 41, 49, 637, DateTimeKind.Utc).AddTicks(9652), new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                columns: new[] { "CreatedOn", "SubcategoryId" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 41, 49, 637, DateTimeKind.Utc).AddTicks(9648), new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                columns: new[] { "CreatedOn", "SubcategoryId" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 41, 49, 637, DateTimeKind.Utc).AddTicks(9639), new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2") });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("45c73d43-2499-422e-a5b5-5f0086331e51"), new Guid("53146915-6199-44eb-aedb-e9902299be6c"), "Unisex" },
                    { new Guid("5f1efcf7-0a16-4079-ae7f-aebbd4f5ca3b"), new Guid("53146915-6199-44eb-aedb-e9902299be6c"), "Men" },
                    { new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2"), new Guid("53146915-6199-44eb-aedb-e9902299be6c"), "Women" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubcategoryId",
                table: "Products",
                column: "SubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Subcategories_CategoryId",
                table: "Subcategories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Subcategories_SubcategoryId",
                table: "Products",
                column: "SubcategoryId",
                principalTable: "Subcategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
