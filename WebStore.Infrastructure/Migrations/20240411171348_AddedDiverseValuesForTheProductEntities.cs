using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedDiverseValuesForTheProductEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("753efde4-efa1-4f88-abc9-8f091cf8b670"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a596c0c6-5172-494b-a4f7-50c880dc0055", "AQAAAAIAAYagAAAAECctfrT9Hi+OBE08zYJ1ExXAJwQUKt9Yq+sbegGATTzNjERogGfkAhM22ZtIFtXMWQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f124abe5-cfd6-4280-8ed0-74c6f73b8c1f", "AQAAAAIAAYagAAAAEGm4lAJrh8UXDmb3xfndjuOz/ZN+8gNARHmxRDGrVempTCqHlCX7Q4l9STU1znEUjQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                columns: new[] { "CreatedOn", "Quantity" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 13, 47, 461, DateTimeKind.Utc).AddTicks(9001), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 17, 13, 47, 461, DateTimeKind.Utc).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 17, 13, 47, 461, DateTimeKind.Utc).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 17, 13, 47, 461, DateTimeKind.Utc).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 17, 13, 47, 461, DateTimeKind.Utc).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                columns: new[] { "CreatedOn", "Quantity" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 13, 47, 461, DateTimeKind.Utc).AddTicks(8979), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 17, 13, 47, 461, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 17, 13, 47, 461, DateTimeKind.Utc).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 17, 13, 47, 461, DateTimeKind.Utc).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 17, 13, 47, 461, DateTimeKind.Utc).AddTicks(8957));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreatedOn", "Quantity" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 7, 50, 560, DateTimeKind.Utc).AddTicks(2616), 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 17, 7, 50, 560, DateTimeKind.Utc).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 17, 7, 50, 560, DateTimeKind.Utc).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 17, 7, 50, 560, DateTimeKind.Utc).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 17, 7, 50, 560, DateTimeKind.Utc).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                columns: new[] { "CreatedOn", "Quantity" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 7, 50, 560, DateTimeKind.Utc).AddTicks(2588), 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 17, 7, 50, 560, DateTimeKind.Utc).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 17, 7, 50, 560, DateTimeKind.Utc).AddTicks(2539));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 17, 7, 50, 560, DateTimeKind.Utc).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 11, 17, 7, 50, 560, DateTimeKind.Utc).AddTicks(2522));
        }
    }
}
