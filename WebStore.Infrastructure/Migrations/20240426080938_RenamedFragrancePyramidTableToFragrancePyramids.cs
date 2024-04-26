using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RenamedFragrancePyramidTableToFragrancePyramids : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FragrancePyramid_Products_ProductId",
                table: "FragrancePyramid");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FragrancePyramid",
                table: "FragrancePyramid");

            migrationBuilder.RenameTable(
                name: "FragrancePyramid",
                newName: "FragrancePyramids");

            migrationBuilder.RenameIndex(
                name: "IX_FragrancePyramid_ProductId",
                table: "FragrancePyramids",
                newName: "IX_FragrancePyramids_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FragrancePyramids",
                table: "FragrancePyramids",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("753efde4-efa1-4f88-abc9-8f091cf8b670"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7d2879e4-227d-4923-b2e5-07d2decde261", "AQAAAAIAAYagAAAAEGnY0+vFldUQT8jPqWeYTaHldmzIc039hRLmRxkyFxWvcnKeItMIg32zT2uDeSKooA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "80cb926b-1196-4050-a668-ffb805554478", "AQAAAAIAAYagAAAAEBxtQACq4lp+Ss6i7TvtNudbC4PouEyikxMVnB8YEsJrc87Pjx1CwHRVebUloCgr6w==" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 4, 26, 8, 9, 38, 122, DateTimeKind.Utc).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 26, 8, 9, 37, 975, DateTimeKind.Utc).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 26, 8, 9, 37, 975, DateTimeKind.Utc).AddTicks(2539));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 26, 8, 9, 37, 975, DateTimeKind.Utc).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 26, 8, 9, 37, 975, DateTimeKind.Utc).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 26, 8, 9, 37, 975, DateTimeKind.Utc).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 26, 8, 9, 37, 975, DateTimeKind.Utc).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 26, 8, 9, 37, 975, DateTimeKind.Utc).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 26, 8, 9, 37, 975, DateTimeKind.Utc).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 26, 8, 9, 37, 975, DateTimeKind.Utc).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 26, 8, 9, 37, 975, DateTimeKind.Utc).AddTicks(2496));

            migrationBuilder.AddForeignKey(
                name: "FK_FragrancePyramids_Products_ProductId",
                table: "FragrancePyramids",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FragrancePyramids_Products_ProductId",
                table: "FragrancePyramids");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FragrancePyramids",
                table: "FragrancePyramids");

            migrationBuilder.RenameTable(
                name: "FragrancePyramids",
                newName: "FragrancePyramid");

            migrationBuilder.RenameIndex(
                name: "IX_FragrancePyramids_ProductId",
                table: "FragrancePyramid",
                newName: "IX_FragrancePyramid_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FragrancePyramid",
                table: "FragrancePyramid",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("753efde4-efa1-4f88-abc9-8f091cf8b670"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ae5ef9c1-9ed9-43f7-9bf7-f461d6801bd4", "AQAAAAIAAYagAAAAEGv2b+IW3gnGUzlwbMr4cz6o3ZI+hZrbjHsijLPlHxbmebPp2FNhJZEedo8zY62naQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "78e9cbb4-5c88-405c-abed-0f3416427f0c", "AQAAAAIAAYagAAAAEHWIyFNSaOgm8PO6NClRcwkGN4CK0jytHycj4qai0B7CZQk2iKOPpd306/czeCcM+g==" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 4, 26, 8, 5, 36, 573, DateTimeKind.Utc).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 26, 8, 5, 36, 438, DateTimeKind.Utc).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 26, 8, 5, 36, 438, DateTimeKind.Utc).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 26, 8, 5, 36, 438, DateTimeKind.Utc).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 26, 8, 5, 36, 438, DateTimeKind.Utc).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 26, 8, 5, 36, 438, DateTimeKind.Utc).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 26, 8, 5, 36, 438, DateTimeKind.Utc).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 26, 8, 5, 36, 438, DateTimeKind.Utc).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 26, 8, 5, 36, 438, DateTimeKind.Utc).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 26, 8, 5, 36, 438, DateTimeKind.Utc).AddTicks(2952));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 26, 8, 5, 36, 438, DateTimeKind.Utc).AddTicks(2944));

            migrationBuilder.AddForeignKey(
                name: "FK_FragrancePyramid_Products_ProductId",
                table: "FragrancePyramid",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
