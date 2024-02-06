using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedSoldCountPropertyToProductEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SoldCount",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                columns: new[] { "AddedOn", "SoldCount" },
                values: new object[] { new DateTime(2024, 1, 17, 19, 36, 44, 822, DateTimeKind.Utc).AddTicks(8266), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                columns: new[] { "AddedOn", "SoldCount" },
                values: new object[] { new DateTime(2024, 1, 17, 19, 36, 44, 822, DateTimeKind.Utc).AddTicks(8263), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                columns: new[] { "AddedOn", "SoldCount" },
                values: new object[] { new DateTime(2024, 1, 17, 19, 36, 44, 822, DateTimeKind.Utc).AddTicks(8261), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                columns: new[] { "AddedOn", "SoldCount" },
                values: new object[] { new DateTime(2024, 1, 17, 19, 36, 44, 822, DateTimeKind.Utc).AddTicks(8259), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                columns: new[] { "AddedOn", "SoldCount" },
                values: new object[] { new DateTime(2024, 1, 17, 19, 36, 44, 822, DateTimeKind.Utc).AddTicks(8253), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                columns: new[] { "AddedOn", "SoldCount" },
                values: new object[] { new DateTime(2024, 1, 17, 19, 36, 44, 822, DateTimeKind.Utc).AddTicks(8248), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "AddedOn", "SoldCount" },
                values: new object[] { new DateTime(2024, 1, 17, 19, 36, 44, 822, DateTimeKind.Utc).AddTicks(8246), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                columns: new[] { "AddedOn", "SoldCount" },
                values: new object[] { new DateTime(2024, 1, 17, 19, 36, 44, 822, DateTimeKind.Utc).AddTicks(8244), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                columns: new[] { "AddedOn", "SoldCount" },
                values: new object[] { new DateTime(2024, 1, 17, 19, 36, 44, 822, DateTimeKind.Utc).AddTicks(8241), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                columns: new[] { "AddedOn", "SoldCount" },
                values: new object[] { new DateTime(2024, 1, 17, 19, 36, 44, 822, DateTimeKind.Utc).AddTicks(8232), 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoldCount",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 18, 42, 54, 173, DateTimeKind.Utc).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 18, 42, 54, 173, DateTimeKind.Utc).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 18, 42, 54, 173, DateTimeKind.Utc).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 18, 42, 54, 173, DateTimeKind.Utc).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 18, 42, 54, 173, DateTimeKind.Utc).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 18, 42, 54, 173, DateTimeKind.Utc).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 18, 42, 54, 173, DateTimeKind.Utc).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 18, 42, 54, 173, DateTimeKind.Utc).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 18, 42, 54, 173, DateTimeKind.Utc).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 18, 42, 54, 173, DateTimeKind.Utc).AddTicks(5025));
        }
    }
}
