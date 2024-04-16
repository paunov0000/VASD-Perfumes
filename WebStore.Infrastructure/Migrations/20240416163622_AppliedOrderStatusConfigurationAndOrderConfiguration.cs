using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AppliedOrderStatusConfigurationAndOrderConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("753efde4-efa1-4f88-abc9-8f091cf8b670"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "25fade81-4305-447e-90eb-9712d8942f5b", "AQAAAAIAAYagAAAAENxtK2ro9ckCP+q94yIzkbSHfZ0FoIEVKX90C1JpCXDuIK9yxPF9k84KPaWhnfgmcQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "02d5b09b-167d-4f69-b03a-33210ffa9de4", "AQAAAAIAAYagAAAAEIJt/By+60NNmqEwmLBO9Idum9WN+oZkz9733qAa/hoVNtk+ldnOLy13ke8XD8M0ZQ==" });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Pending" },
                    { 2, "Awaiting Payment" },
                    { 3, "Awaiting Fulfillment" },
                    { 4, "Awaiting Shipment" },
                    { 5, "Awaiting Pickup" },
                    { 6, "Partially Shipped" },
                    { 7, "Completed" },
                    { 8, "Shipped" },
                    { 9, "Canceled" },
                    { 10, "Declined" },
                    { 11, "Refunded" },
                    { 12, "Disputed" },
                    { 13, "Manual Verification Required" },
                    { 14, "Partially Refunded" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 16, 16, 36, 21, 336, DateTimeKind.Utc).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 16, 16, 36, 21, 336, DateTimeKind.Utc).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 16, 16, 36, 21, 336, DateTimeKind.Utc).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 16, 16, 36, 21, 336, DateTimeKind.Utc).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 16, 16, 36, 21, 336, DateTimeKind.Utc).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 16, 16, 36, 21, 336, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 16, 16, 36, 21, 336, DateTimeKind.Utc).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 16, 16, 36, 21, 336, DateTimeKind.Utc).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 16, 16, 36, 21, 336, DateTimeKind.Utc).AddTicks(9215));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 16, 16, 36, 21, 336, DateTimeKind.Utc).AddTicks(9201));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "OrderDate", "OrderStatusId" },
                values: new object[] { 1, new Guid("2d963508-bd53-4713-a82e-189a8dcc42b9"), new DateTime(2024, 4, 16, 16, 36, 21, 486, DateTimeKind.Utc).AddTicks(2878), 3 });

            migrationBuilder.InsertData(
                table: "OrderProduct",
                columns: new[] { "OrdersId", "ProductsId" },
                values: new object[,]
                {
                    { 1, new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66") },
                    { 1, new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69") },
                    { 1, new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderProduct",
                keyColumns: new[] { "OrdersId", "ProductsId" },
                keyValues: new object[] { 1, new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66") });

            migrationBuilder.DeleteData(
                table: "OrderProduct",
                keyColumns: new[] { "OrdersId", "ProductsId" },
                keyValues: new object[] { 1, new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69") });

            migrationBuilder.DeleteData(
                table: "OrderProduct",
                keyColumns: new[] { "OrdersId", "ProductsId" },
                keyValues: new object[] { 1, new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f") });

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("753efde4-efa1-4f88-abc9-8f091cf8b670"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "51c0a087-dded-4640-a33b-05820cd108e6", "AQAAAAIAAYagAAAAEDzkQlIorpWELPqKZlaTJdA0MJlqB6TqnIVvVIvs3LbJ3srbu4rXQxskq7BMbV2hDQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f434824f-c66c-4446-a35a-dad4532bda6c", "AQAAAAIAAYagAAAAEFjhAdzAprxTvsV9ZV0hglVmKILj8C8gct2wTNWvIscEiQq2DDmrUPxmdPAZQCuS7g==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 13, 19, 21, 30, 437, DateTimeKind.Utc).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 13, 19, 21, 30, 437, DateTimeKind.Utc).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 13, 19, 21, 30, 437, DateTimeKind.Utc).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 13, 19, 21, 30, 437, DateTimeKind.Utc).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 13, 19, 21, 30, 437, DateTimeKind.Utc).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 13, 19, 21, 30, 437, DateTimeKind.Utc).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 13, 19, 21, 30, 437, DateTimeKind.Utc).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 13, 19, 21, 30, 437, DateTimeKind.Utc).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 13, 19, 21, 30, 437, DateTimeKind.Utc).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 13, 19, 21, 30, 437, DateTimeKind.Utc).AddTicks(7472));
        }
    }
}
