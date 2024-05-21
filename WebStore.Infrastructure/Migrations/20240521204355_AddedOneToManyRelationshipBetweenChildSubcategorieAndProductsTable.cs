using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedOneToManyRelationshipBetweenChildSubcategorieAndProductsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChildSubcategories_Products_ProductId",
                table: "ChildSubcategories");

            migrationBuilder.DropIndex(
                name: "IX_ChildSubcategories_ProductId",
                table: "ChildSubcategories");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ChildSubcategories");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("753efde4-efa1-4f88-abc9-8f091cf8b670"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cf2a522a-bc35-487e-8ce8-254316c27ddc", "AQAAAAIAAYagAAAAEGJ8WA5+s5FmHRibkX8wP5YnYw2YYXqxUwEM+HavIrxoaOvbWkNciPzwtcvvgvkV4Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "49ad002b-0df0-47f1-b904-072ad5817fb2", "AQAAAAIAAYagAAAAEOx+B2RFaMBSIy3LxLNmj4+VpYwZgd8p65EkVRTEIlTHOazYVYCRl00wQC1VE7JypA==" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 5, 21, 20, 43, 54, 573, DateTimeKind.Utc).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 21, 20, 43, 54, 439, DateTimeKind.Utc).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 21, 20, 43, 54, 439, DateTimeKind.Utc).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 21, 20, 43, 54, 439, DateTimeKind.Utc).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 21, 20, 43, 54, 439, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 21, 20, 43, 54, 439, DateTimeKind.Utc).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 21, 20, 43, 54, 439, DateTimeKind.Utc).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 21, 20, 43, 54, 439, DateTimeKind.Utc).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 21, 20, 43, 54, 439, DateTimeKind.Utc).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 21, 20, 43, 54, 439, DateTimeKind.Utc).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 21, 20, 43, 54, 439, DateTimeKind.Utc).AddTicks(3582));

            migrationBuilder.CreateIndex(
                name: "IX_Products_ChildSubcategoryId",
                table: "Products",
                column: "ChildSubcategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ChildSubcategories_ChildSubcategoryId",
                table: "Products",
                column: "ChildSubcategoryId",
                principalTable: "ChildSubcategories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ChildSubcategories_ChildSubcategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ChildSubcategoryId",
                table: "Products");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "ChildSubcategories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("753efde4-efa1-4f88-abc9-8f091cf8b670"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aa55ceb7-0f52-487a-ad23-cd5a3fa85f0d", "AQAAAAIAAYagAAAAEPmA3ccOrdrSEXEIjnzx4SqxenvGbIndDdOrNeWYMg8BJr27ouyDmScYFnsQ24dUbQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b4c08709-d957-491f-8b05-281627268412", "AQAAAAIAAYagAAAAEJlllwxhBYu6ywWccAtyKM10/IdJmBcNdY86xMcOAu+cJj0I6RiJs7701orEe66SPw==" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 5, 21, 20, 8, 14, 877, DateTimeKind.Utc).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 21, 20, 8, 14, 743, DateTimeKind.Utc).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 21, 20, 8, 14, 743, DateTimeKind.Utc).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 21, 20, 8, 14, 743, DateTimeKind.Utc).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 21, 20, 8, 14, 743, DateTimeKind.Utc).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 21, 20, 8, 14, 743, DateTimeKind.Utc).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 21, 20, 8, 14, 743, DateTimeKind.Utc).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 21, 20, 8, 14, 743, DateTimeKind.Utc).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 21, 20, 8, 14, 743, DateTimeKind.Utc).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 21, 20, 8, 14, 743, DateTimeKind.Utc).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 21, 20, 8, 14, 743, DateTimeKind.Utc).AddTicks(4988));

            migrationBuilder.CreateIndex(
                name: "IX_ChildSubcategories_ProductId",
                table: "ChildSubcategories",
                column: "ProductId",
                unique: true,
                filter: "[ProductId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_ChildSubcategories_Products_ProductId",
                table: "ChildSubcategories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
