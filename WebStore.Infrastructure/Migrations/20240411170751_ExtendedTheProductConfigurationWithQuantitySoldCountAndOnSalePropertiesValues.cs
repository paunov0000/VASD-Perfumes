using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedTheProductConfigurationWithQuantitySoldCountAndOnSalePropertiesValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("753efde4-efa1-4f88-abc9-8f091cf8b670"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e9a66fe1-85dd-4429-a1a7-6b9efc6ba624", "AQAAAAIAAYagAAAAEAhWUcvi9f+Q6Qa83+0E/mfQIB2NqHf31P2i5riZprmpzfMB8a+clWQxjtADcXFssA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bf1bc50a-9844-4c09-a729-c87eba2892ce", "AQAAAAIAAYagAAAAEDo9yAgcvZC/Bm9/WfZKW6IWmc7TfTkqcEjY20XwBEW7xvaMMhLaT6hhOd2vuorwAw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                columns: new[] { "CreatedOn", "Quantity", "SoldCount" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 7, 50, 560, DateTimeKind.Utc).AddTicks(2616), 12, 86 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                columns: new[] { "CreatedOn", "OnSale", "Quantity", "SoldCount" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 7, 50, 560, DateTimeKind.Utc).AddTicks(2610), true, 52, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                columns: new[] { "CreatedOn", "OnSale", "Quantity", "SoldCount" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 7, 50, 560, DateTimeKind.Utc).AddTicks(2605), true, 95, 32 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                columns: new[] { "CreatedOn", "Quantity", "SoldCount" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 7, 50, 560, DateTimeKind.Utc).AddTicks(2600), 17, 133 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                columns: new[] { "CreatedOn", "Quantity", "SoldCount" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 7, 50, 560, DateTimeKind.Utc).AddTicks(2594), 4, 34 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                columns: new[] { "CreatedOn", "OnSale", "Quantity", "SoldCount" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 7, 50, 560, DateTimeKind.Utc).AddTicks(2588), true, 1, 93 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "CreatedOn", "Quantity", "SoldCount" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 7, 50, 560, DateTimeKind.Utc).AddTicks(2545), 23, 84 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                columns: new[] { "CreatedOn", "OnSale", "Quantity", "SoldCount" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 7, 50, 560, DateTimeKind.Utc).AddTicks(2539), true, 193, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                columns: new[] { "CreatedOn", "OnSale", "Quantity", "SoldCount" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 7, 50, 560, DateTimeKind.Utc).AddTicks(2532), true, 12, 51 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                columns: new[] { "CreatedOn", "Quantity", "SoldCount" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 7, 50, 560, DateTimeKind.Utc).AddTicks(2522), 9, 37 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("753efde4-efa1-4f88-abc9-8f091cf8b670"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "464bdd50-6003-43a1-8a9e-393584af7b27", "AQAAAAIAAYagAAAAEF/yX2EjSrwDWdi/7pBACaI89lTky+Fxf8U/laGOF8qMazN+JdASK+oYptzVQ/0R9Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "32c60983-e797-4766-bb9c-0bd46e727e25", "AQAAAAIAAYagAAAAEBLFG266q/BrEU6fdkm1RXQPdK0lu1o2KhuX5c8bZUjbuz18gJtK/uNcB/0KHwRh9g==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                columns: new[] { "CreatedOn", "Quantity", "SoldCount" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 34, 2, 874, DateTimeKind.Utc).AddTicks(9633), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                columns: new[] { "CreatedOn", "OnSale", "Quantity", "SoldCount" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 34, 2, 874, DateTimeKind.Utc).AddTicks(9629), false, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                columns: new[] { "CreatedOn", "OnSale", "Quantity", "SoldCount" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 34, 2, 874, DateTimeKind.Utc).AddTicks(9626), false, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                columns: new[] { "CreatedOn", "Quantity", "SoldCount" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 34, 2, 874, DateTimeKind.Utc).AddTicks(9623), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                columns: new[] { "CreatedOn", "Quantity", "SoldCount" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 34, 2, 874, DateTimeKind.Utc).AddTicks(9620), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                columns: new[] { "CreatedOn", "OnSale", "Quantity", "SoldCount" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 34, 2, 874, DateTimeKind.Utc).AddTicks(9616), false, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "CreatedOn", "Quantity", "SoldCount" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 34, 2, 874, DateTimeKind.Utc).AddTicks(9612), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                columns: new[] { "CreatedOn", "OnSale", "Quantity", "SoldCount" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 34, 2, 874, DateTimeKind.Utc).AddTicks(9582), false, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                columns: new[] { "CreatedOn", "OnSale", "Quantity", "SoldCount" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 34, 2, 874, DateTimeKind.Utc).AddTicks(9574), false, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                columns: new[] { "CreatedOn", "Quantity", "SoldCount" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 34, 2, 874, DateTimeKind.Utc).AddTicks(9567), 0, 0 });
        }
    }
}
