using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedDateOfBirthToApplicationUserAddedProductCustomerManyToManyRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                comment: "Date of birth of the ApplicationUser");

            migrationBuilder.CreateTable(
                name: "CustomerProduct",
                columns: table => new
                {
                    CustomersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerProduct", x => new { x.CustomersId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CustomerProduct_Customers_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("753efde4-efa1-4f88-abc9-8f091cf8b670"),
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { null, "74ffae5e-6f35-4447-a8f7-75f91e7eabd3", "AQAAAAIAAYagAAAAEBxvWbcMLWE1fyxnWWKI4wpmRnAqsF5kMwC18HdngcD/1FycccE8HTBYWwe1v7SUVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { null, "d9947113-0ca9-4025-b134-d9c8a4e10da9", "AQAAAAIAAYagAAAAEAjqey14HWWFAUDzxJByYXpGScy5NqGPEQuHvzje4Z9if8DCZK3h/QQQ6DLtgM8wgw==" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 11, 24, 12, 38, 36, 492, DateTimeKind.Utc).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 12, 38, 36, 359, DateTimeKind.Utc).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 12, 38, 36, 359, DateTimeKind.Utc).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 12, 38, 36, 359, DateTimeKind.Utc).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 12, 38, 36, 359, DateTimeKind.Utc).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 12, 38, 36, 359, DateTimeKind.Utc).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 12, 38, 36, 359, DateTimeKind.Utc).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 12, 38, 36, 359, DateTimeKind.Utc).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 12, 38, 36, 359, DateTimeKind.Utc).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 12, 38, 36, 359, DateTimeKind.Utc).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 12, 38, 36, 359, DateTimeKind.Utc).AddTicks(823));

            migrationBuilder.CreateIndex(
                name: "IX_CustomerProduct_ProductsId",
                table: "CustomerProduct",
                column: "ProductsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerProduct");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("753efde4-efa1-4f88-abc9-8f091cf8b670"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a8a0f7e0-7f02-4277-9e92-9ae032195342", "AQAAAAIAAYagAAAAELVSWHpB3um/x/VOkRbDnBEbWZwovf1ESXlRwdgDvzQ4TdiUNg484TCHAtPwTnd2Ww==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0c2e61f3-bb41-460f-b619-6831519312c2", "AQAAAAIAAYagAAAAEONV/yNnx/icxA+zFaQQuZrdWARrl//BIvbppQcw6FGkAKv+B5FJDq1v274vVlMxmA==" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 5, 28, 15, 24, 0, 682, DateTimeKind.Utc).AddTicks(1701));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 28, 15, 24, 0, 556, DateTimeKind.Utc).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 28, 15, 24, 0, 556, DateTimeKind.Utc).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 28, 15, 24, 0, 556, DateTimeKind.Utc).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 28, 15, 24, 0, 556, DateTimeKind.Utc).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 28, 15, 24, 0, 556, DateTimeKind.Utc).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 28, 15, 24, 0, 556, DateTimeKind.Utc).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 28, 15, 24, 0, 556, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 28, 15, 24, 0, 556, DateTimeKind.Utc).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 28, 15, 24, 0, 556, DateTimeKind.Utc).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 28, 15, 24, 0, 556, DateTimeKind.Utc).AddTicks(8010));
        }
    }
}
