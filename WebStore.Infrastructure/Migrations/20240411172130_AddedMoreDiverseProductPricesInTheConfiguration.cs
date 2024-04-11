using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedMoreDiverseProductPricesInTheConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("753efde4-efa1-4f88-abc9-8f091cf8b670"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7a05f611-8f3b-4430-8403-e5d9cf1e3971", "AQAAAAIAAYagAAAAEO+GdNtnXMw+payBKMuQXZj5NjnfdkHxwdKXMcAU8vJ/+ewgJFPrJRkvqB5Eb0dqmg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cba85b66-c515-41f8-8f6b-ced24f010e32", "AQAAAAIAAYagAAAAEOPKQ1YFGyJk8N8gdcCIPbDZ9Y43oRpDmr5N71r7T/Wc5Tw3SYYM4nnXeSOgy+C0+Q==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                columns: new[] { "CreatedOn", "Price" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 21, 29, 743, DateTimeKind.Utc).AddTicks(2285), 249.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 17, 21, 29, 743, DateTimeKind.Utc).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 17, 21, 29, 743, DateTimeKind.Utc).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 17, 21, 29, 743, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                columns: new[] { "CreatedOn", "Price" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 21, 29, 743, DateTimeKind.Utc).AddTicks(2227), 101.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                columns: new[] { "CreatedOn", "Price" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 21, 29, 743, DateTimeKind.Utc).AddTicks(2222), 142.61m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "CreatedOn", "Price" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 21, 29, 743, DateTimeKind.Utc).AddTicks(2218), 110.82m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                columns: new[] { "CreatedOn", "Price" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 21, 29, 743, DateTimeKind.Utc).AddTicks(2212), 149.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 17, 21, 29, 743, DateTimeKind.Utc).AddTicks(2207));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                columns: new[] { "CreatedOn", "Price" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 21, 29, 743, DateTimeKind.Utc).AddTicks(2174), 120.34m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("753efde4-efa1-4f88-abc9-8f091cf8b670"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "63f3cf12-ebf1-4e43-b8b7-c2701bb6131f", "AQAAAAIAAYagAAAAEI87ITh6z4BlTV7+l109QCOowpN1AyKIOFqpZLd4b4Q2f0+dZg9bcyKqzGiius0OcQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "44c1a603-5976-4640-b8f1-d305ff0de64e", "AQAAAAIAAYagAAAAELlUEnaDbH5K2YFkqlX6lUfjrCtOozhLdofam7VAqMcdGAT2oTtTASc3i9XA9E6QPg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                columns: new[] { "CreatedOn", "Price" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 17, 11, 6, DateTimeKind.Utc).AddTicks(1959), 250.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 17, 17, 11, 6, DateTimeKind.Utc).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 17, 17, 11, 6, DateTimeKind.Utc).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 17, 17, 11, 6, DateTimeKind.Utc).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                columns: new[] { "CreatedOn", "Price" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 17, 11, 6, DateTimeKind.Utc).AddTicks(1941), 100.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                columns: new[] { "CreatedOn", "Price" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 17, 11, 6, DateTimeKind.Utc).AddTicks(1912), 140.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "CreatedOn", "Price" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 17, 11, 6, DateTimeKind.Utc).AddTicks(1908), 110.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                columns: new[] { "CreatedOn", "Price" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 17, 11, 6, DateTimeKind.Utc).AddTicks(1904), 150.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 17, 17, 11, 6, DateTimeKind.Utc).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                columns: new[] { "CreatedOn", "Price" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 17, 11, 6, DateTimeKind.Utc).AddTicks(1892), 120.00m });
        }
    }
}
