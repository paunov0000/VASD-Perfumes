using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MadeSubcategoryInProductNullableSoMigrationPasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SubcategoryId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true,
                comment: "Foreign key of the Subcategory");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("753efde4-efa1-4f88-abc9-8f091cf8b670"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f0af6d36-4f7f-4cc9-8489-228fa1d10b68", "AQAAAAIAAYagAAAAEKLoGKo88zog3ER2Db7YpAzmZTnFRfUqqwLT+jnwvhmRVPeo77kWfBlQ63UUU/kd5g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fbf00056-93b5-4471-ad6a-55ab45ced5af", "AQAAAAIAAYagAAAAEOX8rZSQqxB7ruq4KetRovFqruljYN1Yx7r81aJ5txxZYgbGfbhbfjlz/zONRs7CEw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                columns: new[] { "CreatedOn", "SubcategoryId" },
                values: new object[] { new DateTime(2024, 3, 11, 15, 53, 9, 874, DateTimeKind.Utc).AddTicks(6637), new Guid("45c73d43-2499-422e-a5b5-5f0086331e51") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                columns: new[] { "CreatedOn", "SubcategoryId" },
                values: new object[] { new DateTime(2024, 3, 11, 15, 53, 9, 874, DateTimeKind.Utc).AddTicks(6633), new Guid("5f1efcf7-0a16-4079-ae7f-aebbd4f5ca3b") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                columns: new[] { "CreatedOn", "SubcategoryId" },
                values: new object[] { new DateTime(2024, 3, 11, 15, 53, 9, 874, DateTimeKind.Utc).AddTicks(6630), new Guid("5f1efcf7-0a16-4079-ae7f-aebbd4f5ca3b") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                columns: new[] { "CreatedOn", "SubcategoryId" },
                values: new object[] { new DateTime(2024, 3, 11, 15, 53, 9, 874, DateTimeKind.Utc).AddTicks(6626), new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                columns: new[] { "CreatedOn", "SubcategoryId" },
                values: new object[] { new DateTime(2024, 3, 11, 15, 53, 9, 874, DateTimeKind.Utc).AddTicks(6622), new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                columns: new[] { "CreatedOn", "SubcategoryId" },
                values: new object[] { new DateTime(2024, 3, 11, 15, 53, 9, 874, DateTimeKind.Utc).AddTicks(6617), new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "CreatedOn", "SubcategoryId" },
                values: new object[] { new DateTime(2024, 3, 11, 15, 53, 9, 874, DateTimeKind.Utc).AddTicks(6613), new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                columns: new[] { "CreatedOn", "SubcategoryId" },
                values: new object[] { new DateTime(2024, 3, 11, 15, 53, 9, 874, DateTimeKind.Utc).AddTicks(6610), new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                columns: new[] { "CreatedOn", "SubcategoryId" },
                values: new object[] { new DateTime(2024, 3, 11, 15, 53, 9, 874, DateTimeKind.Utc).AddTicks(6602), new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                columns: new[] { "CreatedOn", "SubcategoryId" },
                values: new object[] { new DateTime(2024, 3, 11, 15, 53, 9, 874, DateTimeKind.Utc).AddTicks(6594), new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2") });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("5f1efcf7-0a16-4079-ae7f-aebbd4f5ca3b"),
                column: "Name",
                value: "Men");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2"),
                column: "Name",
                value: "Women");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubcategoryId",
                table: "Products",
                column: "SubcategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Subcategories_SubcategoryId",
                table: "Products",
                column: "SubcategoryId",
                principalTable: "Subcategories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Subcategories_SubcategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SubcategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SubcategoryId",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("753efde4-efa1-4f88-abc9-8f091cf8b670"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4a3efa90-71a0-47c9-8336-9632df618470", "AQAAAAIAAYagAAAAEBAg4mAe1TL73U9JGt8Z1AhBdd2XBdbteq+Znbl0vf4LDaGcPeh4hpomFxrxDzHCBQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e5661aa3-6646-40cd-bbb3-090d23c435c5", "AQAAAAIAAYagAAAAEAW2+YOcEt0fSaL96B77Y9hYl7H49s/VZ3eOUW8KwKtyFP+afLvPpw0yZlb9vyoFZA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 14, 20, 30, 506, DateTimeKind.Utc).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 14, 20, 30, 506, DateTimeKind.Utc).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 14, 20, 30, 506, DateTimeKind.Utc).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 14, 20, 30, 506, DateTimeKind.Utc).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 14, 20, 30, 506, DateTimeKind.Utc).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 14, 20, 30, 506, DateTimeKind.Utc).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 14, 20, 30, 506, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 14, 20, 30, 506, DateTimeKind.Utc).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 14, 20, 30, 506, DateTimeKind.Utc).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 14, 20, 30, 506, DateTimeKind.Utc).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("5f1efcf7-0a16-4079-ae7f-aebbd4f5ca3b"),
                column: "Name",
                value: "Man");

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("98c91d15-4a4c-4fc4-b226-f9835e1560d2"),
                column: "Name",
                value: "Woman");
        }
    }
}
