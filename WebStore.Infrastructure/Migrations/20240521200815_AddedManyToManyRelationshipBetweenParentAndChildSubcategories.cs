using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedManyToManyRelationshipBetweenParentAndChildSubcategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParentSubcategories_ChildSubcategories_ChildSubcategoryId",
                table: "ParentSubcategories");

            migrationBuilder.DropIndex(
                name: "IX_ParentSubcategories_ChildSubcategoryId",
                table: "ParentSubcategories");

            migrationBuilder.DropColumn(
                name: "ChildSubcategoryId",
                table: "ParentSubcategories");

            migrationBuilder.CreateTable(
                name: "ChildSubcategoryParentSubcategory",
                columns: table => new
                {
                    ChildSubcategoriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentSubcategoriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChildSubcategoryParentSubcategory", x => new { x.ChildSubcategoriesId, x.ParentSubcategoriesId });
                    table.ForeignKey(
                        name: "FK_ChildSubcategoryParentSubcategory_ChildSubcategories_ChildSubcategoriesId",
                        column: x => x.ChildSubcategoriesId,
                        principalTable: "ChildSubcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChildSubcategoryParentSubcategory_ParentSubcategories_ParentSubcategoriesId",
                        column: x => x.ParentSubcategoriesId,
                        principalTable: "ParentSubcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_ChildSubcategoryParentSubcategory_ParentSubcategoriesId",
                table: "ChildSubcategoryParentSubcategory",
                column: "ParentSubcategoriesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChildSubcategoryParentSubcategory");

            migrationBuilder.AddColumn<Guid>(
                name: "ChildSubcategoryId",
                table: "ParentSubcategories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("753efde4-efa1-4f88-abc9-8f091cf8b670"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dd9b1dce-76e7-411d-8ec7-144a30550dc5", "AQAAAAIAAYagAAAAELjGnr9jP7CKDaKwHTRvzVJKNE6C/dc6Et9o/QgD8Y86YdQzZGIyftsuX3QMoUHe4A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9351fcf6-f080-4196-93d2-a745aa1ab1c2", "AQAAAAIAAYagAAAAEKgGLM7s2/k7E23BqJQFHukx9VMEc30Msg0WUJU1hNliNvFg+9m1kvw8Rv1huzsgiQ==" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 5, 20, 17, 16, 57, 89, DateTimeKind.Utc).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "ParentSubcategories",
                keyColumn: "Id",
                keyValue: new Guid("45c73d43-2499-422e-a5b5-5f0086331e51"),
                column: "ChildSubcategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ParentSubcategories",
                keyColumn: "Id",
                keyValue: new Guid("5f1efcf7-0a16-4079-ae7f-aebbd4f5ca3b"),
                column: "ChildSubcategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ParentSubcategories",
                keyColumn: "Id",
                keyValue: new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2"),
                column: "ChildSubcategoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 20, 17, 16, 56, 962, DateTimeKind.Utc).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 20, 17, 16, 56, 962, DateTimeKind.Utc).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 20, 17, 16, 56, 962, DateTimeKind.Utc).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 20, 17, 16, 56, 962, DateTimeKind.Utc).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 20, 17, 16, 56, 962, DateTimeKind.Utc).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 20, 17, 16, 56, 962, DateTimeKind.Utc).AddTicks(3013));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 20, 17, 16, 56, 962, DateTimeKind.Utc).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 20, 17, 16, 56, 962, DateTimeKind.Utc).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 20, 17, 16, 56, 962, DateTimeKind.Utc).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 20, 17, 16, 56, 962, DateTimeKind.Utc).AddTicks(2987));

            migrationBuilder.CreateIndex(
                name: "IX_ParentSubcategories_ChildSubcategoryId",
                table: "ParentSubcategories",
                column: "ChildSubcategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ParentSubcategories_ChildSubcategories_ChildSubcategoryId",
                table: "ParentSubcategories",
                column: "ChildSubcategoryId",
                principalTable: "ChildSubcategories",
                principalColumn: "Id");
        }
    }
}
