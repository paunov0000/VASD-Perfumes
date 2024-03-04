using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RenamedIsDeletedFieldInProductToIsActive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Products");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "A flag which sets the product state as whether its visible or not");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9965b05c-dec6-4233-93c8-9347ee46b286", "AQAAAAIAAYagAAAAEAmXNavU0M48VU3cix44fMWIJIHQsTqNuYIjjA6u9ltj/Qbx5jIAVYOhG99/1zcV3w==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                columns: new[] { "CreatedOn", "IsActive" },
                values: new object[] { new DateTime(2024, 3, 4, 21, 59, 10, 927, DateTimeKind.Utc).AddTicks(2137), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                columns: new[] { "CreatedOn", "IsActive" },
                values: new object[] { new DateTime(2024, 3, 4, 21, 59, 10, 927, DateTimeKind.Utc).AddTicks(2133), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                columns: new[] { "CreatedOn", "IsActive" },
                values: new object[] { new DateTime(2024, 3, 4, 21, 59, 10, 927, DateTimeKind.Utc).AddTicks(2131), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                columns: new[] { "CreatedOn", "IsActive" },
                values: new object[] { new DateTime(2024, 3, 4, 21, 59, 10, 927, DateTimeKind.Utc).AddTicks(2129), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                columns: new[] { "CreatedOn", "IsActive" },
                values: new object[] { new DateTime(2024, 3, 4, 21, 59, 10, 927, DateTimeKind.Utc).AddTicks(2126), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                columns: new[] { "CreatedOn", "IsActive" },
                values: new object[] { new DateTime(2024, 3, 4, 21, 59, 10, 927, DateTimeKind.Utc).AddTicks(2123), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "CreatedOn", "IsActive" },
                values: new object[] { new DateTime(2024, 3, 4, 21, 59, 10, 927, DateTimeKind.Utc).AddTicks(2120), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                columns: new[] { "CreatedOn", "IsActive" },
                values: new object[] { new DateTime(2024, 3, 4, 21, 59, 10, 927, DateTimeKind.Utc).AddTicks(2117), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                columns: new[] { "CreatedOn", "IsActive" },
                values: new object[] { new DateTime(2024, 3, 4, 21, 59, 10, 927, DateTimeKind.Utc).AddTicks(2113), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                columns: new[] { "CreatedOn", "IsActive" },
                values: new object[] { new DateTime(2024, 3, 4, 21, 59, 10, 927, DateTimeKind.Utc).AddTicks(2107), true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Products");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "A flag which sets the product state as whether its visible or not");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "85e18e0d-5d12-494d-b97f-dd832998c72d", "AQAAAAIAAYagAAAAEKNBFG9w0pqVH1FzVdhUYkslAxfDCXI6Jmp8xKEglmhASE3K/HdFDkJmvIeph0a5lw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2024, 2, 26, 22, 13, 7, 726, DateTimeKind.Utc).AddTicks(8017), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2024, 2, 26, 22, 13, 7, 726, DateTimeKind.Utc).AddTicks(8014), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2024, 2, 26, 22, 13, 7, 726, DateTimeKind.Utc).AddTicks(8012), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2024, 2, 26, 22, 13, 7, 726, DateTimeKind.Utc).AddTicks(8009), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2024, 2, 26, 22, 13, 7, 726, DateTimeKind.Utc).AddTicks(8007), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2024, 2, 26, 22, 13, 7, 726, DateTimeKind.Utc).AddTicks(8003), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2024, 2, 26, 22, 13, 7, 726, DateTimeKind.Utc).AddTicks(7999), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2024, 2, 26, 22, 13, 7, 726, DateTimeKind.Utc).AddTicks(7995), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2024, 2, 26, 22, 13, 7, 726, DateTimeKind.Utc).AddTicks(7993), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                columns: new[] { "CreatedOn", "IsDeleted" },
                values: new object[] { new DateTime(2024, 2, 26, 22, 13, 7, 726, DateTimeKind.Utc).AddTicks(7985), false });
        }
    }
}
