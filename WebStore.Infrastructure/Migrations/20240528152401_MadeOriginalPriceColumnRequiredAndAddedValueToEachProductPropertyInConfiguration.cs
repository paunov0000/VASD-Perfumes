using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MadeOriginalPriceColumnRequiredAndAddedValueToEachProductPropertyInConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "OriginalPrice",
                table: "Products",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m,
                comment: "Original price of product",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2,
                oldNullable: true,
                oldComment: "Original price of product");

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
                columns: new[] { "CreatedOn", "OriginalPrice" },
                values: new object[] { new DateTime(2024, 5, 28, 15, 24, 0, 556, DateTimeKind.Utc).AddTicks(8103), 249.99m });

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
                columns: new[] { "CreatedOn", "OriginalPrice" },
                values: new object[] { new DateTime(2024, 5, 28, 15, 24, 0, 556, DateTimeKind.Utc).AddTicks(8088), 180.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                columns: new[] { "CreatedOn", "OriginalPrice" },
                values: new object[] { new DateTime(2024, 5, 28, 15, 24, 0, 556, DateTimeKind.Utc).AddTicks(8080), 101.00m });

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
                columns: new[] { "CreatedOn", "OriginalPrice" },
                values: new object[] { new DateTime(2024, 5, 28, 15, 24, 0, 556, DateTimeKind.Utc).AddTicks(8069), 110.82m });

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
                columns: new[] { "CreatedOn", "OriginalPrice" },
                values: new object[] { new DateTime(2024, 5, 28, 15, 24, 0, 556, DateTimeKind.Utc).AddTicks(8010), 120.34m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "OriginalPrice",
                table: "Products",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: true,
                comment: "Original price of product",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2,
                oldComment: "Original price of product");

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
                column: "CreatedOn",
                value: new DateTime(2024, 5, 28, 14, 23, 19, 299, DateTimeKind.Utc).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 28, 14, 23, 19, 299, DateTimeKind.Utc).AddTicks(9577));

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
                column: "CreatedOn",
                value: new DateTime(2024, 5, 28, 14, 23, 19, 299, DateTimeKind.Utc).AddTicks(9558));

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
                column: "CreatedOn",
                value: new DateTime(2024, 5, 28, 14, 23, 19, 299, DateTimeKind.Utc).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 28, 14, 23, 19, 299, DateTimeKind.Utc).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                columns: new[] { "CreatedOn", "OriginalPrice" },
                values: new object[] { new DateTime(2024, 5, 28, 14, 23, 19, 299, DateTimeKind.Utc).AddTicks(9521), null });
        }
    }
}
