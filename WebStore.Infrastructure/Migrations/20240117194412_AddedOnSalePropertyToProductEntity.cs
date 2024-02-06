using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedOnSalePropertyToProductEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "OnSale",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                columns: new[] { "AddedOn", "OnSale" },
                values: new object[] { new DateTime(2024, 1, 17, 19, 44, 12, 597, DateTimeKind.Utc).AddTicks(692), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                columns: new[] { "AddedOn", "OnSale" },
                values: new object[] { new DateTime(2024, 1, 17, 19, 44, 12, 597, DateTimeKind.Utc).AddTicks(689), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                columns: new[] { "AddedOn", "OnSale" },
                values: new object[] { new DateTime(2024, 1, 17, 19, 44, 12, 597, DateTimeKind.Utc).AddTicks(686), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                columns: new[] { "AddedOn", "OnSale" },
                values: new object[] { new DateTime(2024, 1, 17, 19, 44, 12, 597, DateTimeKind.Utc).AddTicks(684), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                columns: new[] { "AddedOn", "OnSale" },
                values: new object[] { new DateTime(2024, 1, 17, 19, 44, 12, 597, DateTimeKind.Utc).AddTicks(681), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                columns: new[] { "AddedOn", "OnSale" },
                values: new object[] { new DateTime(2024, 1, 17, 19, 44, 12, 597, DateTimeKind.Utc).AddTicks(612), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "AddedOn", "OnSale" },
                values: new object[] { new DateTime(2024, 1, 17, 19, 44, 12, 597, DateTimeKind.Utc).AddTicks(609), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                columns: new[] { "AddedOn", "OnSale" },
                values: new object[] { new DateTime(2024, 1, 17, 19, 44, 12, 597, DateTimeKind.Utc).AddTicks(607), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                columns: new[] { "AddedOn", "OnSale" },
                values: new object[] { new DateTime(2024, 1, 17, 19, 44, 12, 597, DateTimeKind.Utc).AddTicks(604), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                columns: new[] { "AddedOn", "OnSale" },
                values: new object[] { new DateTime(2024, 1, 17, 19, 44, 12, 597, DateTimeKind.Utc).AddTicks(595), false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OnSale",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 19, 36, 44, 822, DateTimeKind.Utc).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 19, 36, 44, 822, DateTimeKind.Utc).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 19, 36, 44, 822, DateTimeKind.Utc).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 19, 36, 44, 822, DateTimeKind.Utc).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 19, 36, 44, 822, DateTimeKind.Utc).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 19, 36, 44, 822, DateTimeKind.Utc).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 19, 36, 44, 822, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 19, 36, 44, 822, DateTimeKind.Utc).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 19, 36, 44, 822, DateTimeKind.Utc).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 19, 36, 44, 822, DateTimeKind.Utc).AddTicks(8232));
        }
    }
}
