using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedProductsTableWithOriginalPriceColumnAndExtendedProductConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "OriginalPrice",
                table: "Products",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: true,
                comment: "Original price of product");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("753efde4-efa1-4f88-abc9-8f091cf8b670"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ceba8dd4-3412-482c-b204-b44909c24b24", "AQAAAAIAAYagAAAAEN5uVptzfHNsT3dqxowWqMOohNduv0lD3aBzdxqm2JmHwmuQMTSK/RP0gQ8Xw8HOLw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "20efea43-6d26-4dd4-81d7-d4f2a07198e6", "AQAAAAIAAYagAAAAECbtOiCPmGy3Pl7F0MmDLR34SBGPaJhiKsgY9qukAo4Isr7xhe+iP2/DPVXDlHUizQ==" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 5, 28, 14, 23, 19, 429, DateTimeKind.Utc).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                columns: new[] { "CreatedOn", "OriginalPrice" },
                values: new object[] { new DateTime(2024, 5, 28, 14, 23, 19, 299, DateTimeKind.Utc).AddTicks(9591), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                columns: new[] { "CreatedOn", "OriginalPrice" },
                values: new object[] { new DateTime(2024, 5, 28, 14, 23, 19, 299, DateTimeKind.Utc).AddTicks(9584), 333.33m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                columns: new[] { "CreatedOn", "OriginalPrice" },
                values: new object[] { new DateTime(2024, 5, 28, 14, 23, 19, 299, DateTimeKind.Utc).AddTicks(9577), 121.21m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                columns: new[] { "CreatedOn", "OriginalPrice" },
                values: new object[] { new DateTime(2024, 5, 28, 14, 23, 19, 299, DateTimeKind.Utc).AddTicks(9570), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                columns: new[] { "CreatedOn", "OriginalPrice" },
                values: new object[] { new DateTime(2024, 5, 28, 14, 23, 19, 299, DateTimeKind.Utc).AddTicks(9565), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                columns: new[] { "CreatedOn", "OriginalPrice" },
                values: new object[] { new DateTime(2024, 5, 28, 14, 23, 19, 299, DateTimeKind.Utc).AddTicks(9558), 251.49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "CreatedOn", "OriginalPrice" },
                values: new object[] { new DateTime(2024, 5, 28, 14, 23, 19, 299, DateTimeKind.Utc).AddTicks(9551), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                columns: new[] { "CreatedOn", "OriginalPrice" },
                values: new object[] { new DateTime(2024, 5, 28, 14, 23, 19, 299, DateTimeKind.Utc).AddTicks(9542), 179.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                columns: new[] { "CreatedOn", "OriginalPrice" },
                values: new object[] { new DateTime(2024, 5, 28, 14, 23, 19, 299, DateTimeKind.Utc).AddTicks(9536), 120.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                columns: new[] { "CreatedOn", "OriginalPrice" },
                values: new object[] { new DateTime(2024, 5, 28, 14, 23, 19, 299, DateTimeKind.Utc).AddTicks(9521), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OriginalPrice",
                table: "Products");

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
                column: "CreatedOn",
                value: new DateTime(2024, 5, 21, 21, 34, 37, 779, DateTimeKind.Utc).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 21, 21, 34, 37, 779, DateTimeKind.Utc).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 21, 21, 34, 37, 779, DateTimeKind.Utc).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 21, 21, 34, 37, 779, DateTimeKind.Utc).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 21, 21, 34, 37, 779, DateTimeKind.Utc).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 21, 21, 34, 37, 779, DateTimeKind.Utc).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 21, 21, 34, 37, 779, DateTimeKind.Utc).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 21, 21, 34, 37, 779, DateTimeKind.Utc).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 21, 21, 34, 37, 779, DateTimeKind.Utc).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 21, 21, 34, 37, 779, DateTimeKind.Utc).AddTicks(5701));
        }
    }
}
