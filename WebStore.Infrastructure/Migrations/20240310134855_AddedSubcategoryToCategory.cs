using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedSubcategoryToCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subcategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Primary key of the product subcategory"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Name of the product subcategory"),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Foreign key to the Category entity")
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
                values: new object[] { "e0497402-fd3a-4ee4-8b50-88ff70b4332f", "AQAAAAIAAYagAAAAEIHwa7PnKkbHoaArlmAOLb8r2SV7dqmwdXG+sFI6ZqRJX3CS6p19WxeW0hnYJeppLw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "28f3b6de-a072-44e1-a278-e8281af6617e", "AQAAAAIAAYagAAAAEHtvqKSA9bENB/HHVmGeWSXvSG9y8lIjcVEF58afN8nUfeJCWhz/CoUKs71HqOrViQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 13, 48, 54, 944, DateTimeKind.Utc).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 13, 48, 54, 944, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 13, 48, 54, 944, DateTimeKind.Utc).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 13, 48, 54, 944, DateTimeKind.Utc).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 13, 48, 54, 944, DateTimeKind.Utc).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 13, 48, 54, 944, DateTimeKind.Utc).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 13, 48, 54, 944, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 13, 48, 54, 944, DateTimeKind.Utc).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 13, 48, 54, 944, DateTimeKind.Utc).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 13, 48, 54, 944, DateTimeKind.Utc).AddTicks(6606));

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("45c73d43-2499-422e-a5b5-5f0086331e51"), new Guid("53146915-6199-44eb-aedb-e9902299be6c"), "Unisex" },
                    { new Guid("5f1efcf7-0a16-4079-ae7f-aebbd4f5ca3b"), new Guid("53146915-6199-44eb-aedb-e9902299be6c"), "Man" },
                    { new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2"), new Guid("53146915-6199-44eb-aedb-e9902299be6c"), "Woman" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subcategories_CategoryId",
                table: "Subcategories",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subcategories");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("753efde4-efa1-4f88-abc9-8f091cf8b670"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6884e0c8-2f18-4d1f-969c-a85e2efcca9f", "AQAAAAIAAYagAAAAEJnjZBVbH7eai9pJfv6RzEJqIals6tfVvpf4uy/igb8/ctmys76JoiuzwtEzmHjyoA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "90c4a3d1-0b4c-4dda-97fc-3ed3f4a917f5", "AQAAAAIAAYagAAAAEKzAOUqDvKzoRnlqbxY43XyEBOaNIDHsTq17+ZmFAEcKWON9ozO6VgR5lfdstW5iaw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 8, 11, 40, 51, 822, DateTimeKind.Utc).AddTicks(9718));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 8, 11, 40, 51, 822, DateTimeKind.Utc).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 8, 11, 40, 51, 822, DateTimeKind.Utc).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 8, 11, 40, 51, 822, DateTimeKind.Utc).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 8, 11, 40, 51, 822, DateTimeKind.Utc).AddTicks(9705));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 8, 11, 40, 51, 822, DateTimeKind.Utc).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 8, 11, 40, 51, 822, DateTimeKind.Utc).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 8, 11, 40, 51, 822, DateTimeKind.Utc).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 8, 11, 40, 51, 822, DateTimeKind.Utc).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 8, 11, 40, 51, 822, DateTimeKind.Utc).AddTicks(9683));
        }
    }
}
