using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedCreatedOnFieldOnApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Date of creating the user");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 29, 16, 23, 51, 708, DateTimeKind.Utc).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 29, 16, 23, 51, 708, DateTimeKind.Utc).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 29, 16, 23, 51, 708, DateTimeKind.Utc).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 29, 16, 23, 51, 708, DateTimeKind.Utc).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 29, 16, 23, 51, 708, DateTimeKind.Utc).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 29, 16, 23, 51, 708, DateTimeKind.Utc).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 29, 16, 23, 51, 708, DateTimeKind.Utc).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 29, 16, 23, 51, 708, DateTimeKind.Utc).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 29, 16, 23, 51, 708, DateTimeKind.Utc).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 29, 16, 23, 51, 708, DateTimeKind.Utc).AddTicks(6183));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 19, 44, 12, 597, DateTimeKind.Utc).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 19, 44, 12, 597, DateTimeKind.Utc).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 19, 44, 12, 597, DateTimeKind.Utc).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 19, 44, 12, 597, DateTimeKind.Utc).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 19, 44, 12, 597, DateTimeKind.Utc).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 19, 44, 12, 597, DateTimeKind.Utc).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 19, 44, 12, 597, DateTimeKind.Utc).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 19, 44, 12, 597, DateTimeKind.Utc).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 19, 44, 12, 597, DateTimeKind.Utc).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 19, 44, 12, 597, DateTimeKind.Utc).AddTicks(595));
        }
    }
}
