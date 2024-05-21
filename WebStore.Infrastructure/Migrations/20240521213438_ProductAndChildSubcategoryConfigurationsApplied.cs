using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ProductAndChildSubcategoryConfigurationsApplied : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("753efde4-efa1-4f88-abc9-8f091cf8b670"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5f1176b7-073c-41a9-99b1-f5a9d8d4c417", "AQAAAAIAAYagAAAAEDEJPabuhXYx1SsayBqsC0bzI3bQUeJCZOXftCtt6oRuWTgc3/T63a9LUEHCPDbgmg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "54107df6-8771-438a-b1c2-ed0f7b8a0c13", "AQAAAAIAAYagAAAAEIHA0NTi9llzmF/tTaypd6yCHfyKNLNuPgckGsWfpepaqzo7cY+HpP5NqX5RjytVCg==" });

            migrationBuilder.InsertData(
                table: "ChildSubcategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0eff9eb3-f46f-408b-bb68-561e136aef76"), "EDP" },
                    { new Guid("142ed5a1-52dc-4b2c-86a8-4694b479540e"), "Parfum" },
                    { new Guid("3716553d-4f92-4e15-a411-0ff574e459cc"), "EDT" },
                    { new Guid("442951ae-8062-4b69-a2d2-e9ee52ab16d1"), "EDC" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 5, 21, 21, 34, 37, 913, DateTimeKind.Utc).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                columns: new[] { "ChildSubcategoryId", "CreatedOn" },
                values: new object[] { new Guid("0eff9eb3-f46f-408b-bb68-561e136aef76"), new DateTime(2024, 5, 21, 21, 34, 37, 779, DateTimeKind.Utc).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                columns: new[] { "ChildSubcategoryId", "CreatedOn" },
                values: new object[] { new Guid("0eff9eb3-f46f-408b-bb68-561e136aef76"), new DateTime(2024, 5, 21, 21, 34, 37, 779, DateTimeKind.Utc).AddTicks(5751) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                columns: new[] { "ChildSubcategoryId", "CreatedOn" },
                values: new object[] { new Guid("3716553d-4f92-4e15-a411-0ff574e459cc"), new DateTime(2024, 5, 21, 21, 34, 37, 779, DateTimeKind.Utc).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                columns: new[] { "ChildSubcategoryId", "CreatedOn" },
                values: new object[] { new Guid("0eff9eb3-f46f-408b-bb68-561e136aef76"), new DateTime(2024, 5, 21, 21, 34, 37, 779, DateTimeKind.Utc).AddTicks(5739) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                columns: new[] { "ChildSubcategoryId", "CreatedOn" },
                values: new object[] { new Guid("0eff9eb3-f46f-408b-bb68-561e136aef76"), new DateTime(2024, 5, 21, 21, 34, 37, 779, DateTimeKind.Utc).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                columns: new[] { "ChildSubcategoryId", "CreatedOn" },
                values: new object[] { new Guid("0eff9eb3-f46f-408b-bb68-561e136aef76"), new DateTime(2024, 5, 21, 21, 34, 37, 779, DateTimeKind.Utc).AddTicks(5728) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ChildSubcategoryId", "CreatedOn" },
                values: new object[] { new Guid("0eff9eb3-f46f-408b-bb68-561e136aef76"), new DateTime(2024, 5, 21, 21, 34, 37, 779, DateTimeKind.Utc).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                columns: new[] { "ChildSubcategoryId", "CreatedOn" },
                values: new object[] { new Guid("0eff9eb3-f46f-408b-bb68-561e136aef76"), new DateTime(2024, 5, 21, 21, 34, 37, 779, DateTimeKind.Utc).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                columns: new[] { "ChildSubcategoryId", "CreatedOn" },
                values: new object[] { new Guid("3716553d-4f92-4e15-a411-0ff574e459cc"), new DateTime(2024, 5, 21, 21, 34, 37, 779, DateTimeKind.Utc).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                columns: new[] { "ChildSubcategoryId", "CreatedOn" },
                values: new object[] { new Guid("0eff9eb3-f46f-408b-bb68-561e136aef76"), new DateTime(2024, 5, 21, 21, 34, 37, 779, DateTimeKind.Utc).AddTicks(5701) });

            migrationBuilder.InsertData(
                table: "ChildSubcategoryParentSubcategory",
                columns: new[] { "ChildSubcategoriesId", "ParentSubcategoriesId" },
                values: new object[,]
                {
                    { new Guid("0eff9eb3-f46f-408b-bb68-561e136aef76"), new Guid("45c73d43-2499-422e-a5b5-5f0086331e51") },
                    { new Guid("0eff9eb3-f46f-408b-bb68-561e136aef76"), new Guid("5f1efcf7-0a16-4079-ae7f-aebbd4f5ca3b") },
                    { new Guid("0eff9eb3-f46f-408b-bb68-561e136aef76"), new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2") },
                    { new Guid("142ed5a1-52dc-4b2c-86a8-4694b479540e"), new Guid("45c73d43-2499-422e-a5b5-5f0086331e51") },
                    { new Guid("142ed5a1-52dc-4b2c-86a8-4694b479540e"), new Guid("5f1efcf7-0a16-4079-ae7f-aebbd4f5ca3b") },
                    { new Guid("142ed5a1-52dc-4b2c-86a8-4694b479540e"), new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2") },
                    { new Guid("3716553d-4f92-4e15-a411-0ff574e459cc"), new Guid("45c73d43-2499-422e-a5b5-5f0086331e51") },
                    { new Guid("3716553d-4f92-4e15-a411-0ff574e459cc"), new Guid("5f1efcf7-0a16-4079-ae7f-aebbd4f5ca3b") },
                    { new Guid("3716553d-4f92-4e15-a411-0ff574e459cc"), new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2") },
                    { new Guid("442951ae-8062-4b69-a2d2-e9ee52ab16d1"), new Guid("45c73d43-2499-422e-a5b5-5f0086331e51") },
                    { new Guid("442951ae-8062-4b69-a2d2-e9ee52ab16d1"), new Guid("5f1efcf7-0a16-4079-ae7f-aebbd4f5ca3b") },
                    { new Guid("442951ae-8062-4b69-a2d2-e9ee52ab16d1"), new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ChildSubcategoryParentSubcategory",
                keyColumns: new[] { "ChildSubcategoriesId", "ParentSubcategoriesId" },
                keyValues: new object[] { new Guid("0eff9eb3-f46f-408b-bb68-561e136aef76"), new Guid("45c73d43-2499-422e-a5b5-5f0086331e51") });

            migrationBuilder.DeleteData(
                table: "ChildSubcategoryParentSubcategory",
                keyColumns: new[] { "ChildSubcategoriesId", "ParentSubcategoriesId" },
                keyValues: new object[] { new Guid("0eff9eb3-f46f-408b-bb68-561e136aef76"), new Guid("5f1efcf7-0a16-4079-ae7f-aebbd4f5ca3b") });

            migrationBuilder.DeleteData(
                table: "ChildSubcategoryParentSubcategory",
                keyColumns: new[] { "ChildSubcategoriesId", "ParentSubcategoriesId" },
                keyValues: new object[] { new Guid("0eff9eb3-f46f-408b-bb68-561e136aef76"), new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2") });

            migrationBuilder.DeleteData(
                table: "ChildSubcategoryParentSubcategory",
                keyColumns: new[] { "ChildSubcategoriesId", "ParentSubcategoriesId" },
                keyValues: new object[] { new Guid("142ed5a1-52dc-4b2c-86a8-4694b479540e"), new Guid("45c73d43-2499-422e-a5b5-5f0086331e51") });

            migrationBuilder.DeleteData(
                table: "ChildSubcategoryParentSubcategory",
                keyColumns: new[] { "ChildSubcategoriesId", "ParentSubcategoriesId" },
                keyValues: new object[] { new Guid("142ed5a1-52dc-4b2c-86a8-4694b479540e"), new Guid("5f1efcf7-0a16-4079-ae7f-aebbd4f5ca3b") });

            migrationBuilder.DeleteData(
                table: "ChildSubcategoryParentSubcategory",
                keyColumns: new[] { "ChildSubcategoriesId", "ParentSubcategoriesId" },
                keyValues: new object[] { new Guid("142ed5a1-52dc-4b2c-86a8-4694b479540e"), new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2") });

            migrationBuilder.DeleteData(
                table: "ChildSubcategoryParentSubcategory",
                keyColumns: new[] { "ChildSubcategoriesId", "ParentSubcategoriesId" },
                keyValues: new object[] { new Guid("3716553d-4f92-4e15-a411-0ff574e459cc"), new Guid("45c73d43-2499-422e-a5b5-5f0086331e51") });

            migrationBuilder.DeleteData(
                table: "ChildSubcategoryParentSubcategory",
                keyColumns: new[] { "ChildSubcategoriesId", "ParentSubcategoriesId" },
                keyValues: new object[] { new Guid("3716553d-4f92-4e15-a411-0ff574e459cc"), new Guid("5f1efcf7-0a16-4079-ae7f-aebbd4f5ca3b") });

            migrationBuilder.DeleteData(
                table: "ChildSubcategoryParentSubcategory",
                keyColumns: new[] { "ChildSubcategoriesId", "ParentSubcategoriesId" },
                keyValues: new object[] { new Guid("3716553d-4f92-4e15-a411-0ff574e459cc"), new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2") });

            migrationBuilder.DeleteData(
                table: "ChildSubcategoryParentSubcategory",
                keyColumns: new[] { "ChildSubcategoriesId", "ParentSubcategoriesId" },
                keyValues: new object[] { new Guid("442951ae-8062-4b69-a2d2-e9ee52ab16d1"), new Guid("45c73d43-2499-422e-a5b5-5f0086331e51") });

            migrationBuilder.DeleteData(
                table: "ChildSubcategoryParentSubcategory",
                keyColumns: new[] { "ChildSubcategoriesId", "ParentSubcategoriesId" },
                keyValues: new object[] { new Guid("442951ae-8062-4b69-a2d2-e9ee52ab16d1"), new Guid("5f1efcf7-0a16-4079-ae7f-aebbd4f5ca3b") });

            migrationBuilder.DeleteData(
                table: "ChildSubcategoryParentSubcategory",
                keyColumns: new[] { "ChildSubcategoriesId", "ParentSubcategoriesId" },
                keyValues: new object[] { new Guid("442951ae-8062-4b69-a2d2-e9ee52ab16d1"), new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2") });

            migrationBuilder.DeleteData(
                table: "ChildSubcategories",
                keyColumn: "Id",
                keyValue: new Guid("0eff9eb3-f46f-408b-bb68-561e136aef76"));

            migrationBuilder.DeleteData(
                table: "ChildSubcategories",
                keyColumn: "Id",
                keyValue: new Guid("142ed5a1-52dc-4b2c-86a8-4694b479540e"));

            migrationBuilder.DeleteData(
                table: "ChildSubcategories",
                keyColumn: "Id",
                keyValue: new Guid("3716553d-4f92-4e15-a411-0ff574e459cc"));

            migrationBuilder.DeleteData(
                table: "ChildSubcategories",
                keyColumn: "Id",
                keyValue: new Guid("442951ae-8062-4b69-a2d2-e9ee52ab16d1"));

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
                columns: new[] { "ChildSubcategoryId", "CreatedOn" },
                values: new object[] { null, new DateTime(2024, 5, 21, 20, 43, 54, 439, DateTimeKind.Utc).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                columns: new[] { "ChildSubcategoryId", "CreatedOn" },
                values: new object[] { null, new DateTime(2024, 5, 21, 20, 43, 54, 439, DateTimeKind.Utc).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                columns: new[] { "ChildSubcategoryId", "CreatedOn" },
                values: new object[] { null, new DateTime(2024, 5, 21, 20, 43, 54, 439, DateTimeKind.Utc).AddTicks(3621) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                columns: new[] { "ChildSubcategoryId", "CreatedOn" },
                values: new object[] { null, new DateTime(2024, 5, 21, 20, 43, 54, 439, DateTimeKind.Utc).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                columns: new[] { "ChildSubcategoryId", "CreatedOn" },
                values: new object[] { null, new DateTime(2024, 5, 21, 20, 43, 54, 439, DateTimeKind.Utc).AddTicks(3609) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                columns: new[] { "ChildSubcategoryId", "CreatedOn" },
                values: new object[] { null, new DateTime(2024, 5, 21, 20, 43, 54, 439, DateTimeKind.Utc).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ChildSubcategoryId", "CreatedOn" },
                values: new object[] { null, new DateTime(2024, 5, 21, 20, 43, 54, 439, DateTimeKind.Utc).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                columns: new[] { "ChildSubcategoryId", "CreatedOn" },
                values: new object[] { null, new DateTime(2024, 5, 21, 20, 43, 54, 439, DateTimeKind.Utc).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                columns: new[] { "ChildSubcategoryId", "CreatedOn" },
                values: new object[] { null, new DateTime(2024, 5, 21, 20, 43, 54, 439, DateTimeKind.Utc).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                columns: new[] { "ChildSubcategoryId", "CreatedOn" },
                values: new object[] { null, new DateTime(2024, 5, 21, 20, 43, 54, 439, DateTimeKind.Utc).AddTicks(3582) });
        }
    }
}
