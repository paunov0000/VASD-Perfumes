using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedImgUrlPropertyToBrandEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("753efde4-efa1-4f88-abc9-8f091cf8b670"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1fc2b0a0-8427-4e6c-bc45-454464bde1b3", "AQAAAAIAAYagAAAAENS2ltVdhpljCU3ETwrUs7NI40P9oruxLVnOB/9SiZk2HVUNJ+eYlZ2RwsLPOvQVVg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d4f0ccdd-e229-40c7-a792-bee1ae3c7f08", "AQAAAAIAAYagAAAAEB2IRyDdZqRT3vmQEKDysfNVN14ZjfXk25jfHVIEzcmzvWeTH8AyHOZ9BknKeaSeZQ==" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("28f3d7f5-3469-4036-b919-ec683688314b"),
                column: "ImageUrl",
                value: "https://1000logos.net/wp-content/uploads/2021/06/Tom-Ford-logo.png");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("361f69c3-cdfb-4156-a88a-1620db540c6c"),
                column: "ImageUrl",
                value: "https://logos-world.net/wp-content/uploads/2020/04/Chanel-Logo.png");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("57d95637-ffa7-4109-9d26-03bae7e0e6e1"),
                column: "ImageUrl",
                value: "https://logowik.com/content/uploads/images/529_ysl.jpg");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("586011c7-d606-4e73-a7e8-fca768656c03"),
                column: "ImageUrl",
                value: "https://asset.brandfetch.io/idVWaf5oDD/idG5I2RSGp.jpeg?updated=1667940456056");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("6c86c626-bef8-4627-a314-de021502e335"),
                column: "ImageUrl",
                value: "https://logos-world.net/wp-content/uploads/2023/09/Gucci-Logo.png");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("99f87405-5144-46e6-ad55-724d05928736"),
                column: "ImageUrl",
                value: "https://tukuz.com/wp-content/uploads/2020/05/viktor-rolf-logo-vector.png");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("c3a935d2-8a70-40f4-aa02-7dc52d4688ed"),
                column: "ImageUrl",
                value: "https://logos-world.net/wp-content/uploads/2023/09/Marc-Jacobs-Logo.png");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("dc4a85cb-8f2d-452b-8027-c3409538c244"),
                column: "ImageUrl",
                value: "https://assets.turbologo.com/blog/en/2021/07/07061330/hermes-symbol-logo-1.png");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("dc6ccd03-c8c8-47a8-b9fe-83e878b158f8"),
                column: "ImageUrl",
                value: "https://logos-world.net/wp-content/uploads/2020/11/Giorgio-Armani-Logo.png");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("f33371d7-fa64-42f0-89bd-7f707e285279"),
                column: "ImageUrl",
                value: "https://aromacraze.com/images/thumbs/0025936_creed_420.jpeg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 6, 15, 19, 2, 870, DateTimeKind.Utc).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 6, 15, 19, 2, 870, DateTimeKind.Utc).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 6, 15, 19, 2, 870, DateTimeKind.Utc).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 6, 15, 19, 2, 870, DateTimeKind.Utc).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 6, 15, 19, 2, 870, DateTimeKind.Utc).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 6, 15, 19, 2, 870, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 6, 15, 19, 2, 870, DateTimeKind.Utc).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 6, 15, 19, 2, 870, DateTimeKind.Utc).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 6, 15, 19, 2, 870, DateTimeKind.Utc).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 6, 15, 19, 2, 870, DateTimeKind.Utc).AddTicks(7501));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Brands");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("753efde4-efa1-4f88-abc9-8f091cf8b670"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "563e199b-b28d-433f-a269-ed910e03cf6b", "AQAAAAIAAYagAAAAEARUdan7WlQbsA+fq0fYE9+RqvfpBx+FFMkN3BC46uLyQxTD5tU7nL0YHnBFW+JRUQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "77135a98-dc70-47c7-ae8d-5a2273dc48fd", "AQAAAAIAAYagAAAAEPJneOHoLQvFZaCmH8vJPgjeaJ9QDR8ANQuKYrAj10oojGIE/3YFzNtfQ2/7osLPJg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 11, 16, 27, 55, 79, DateTimeKind.Utc).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 11, 16, 27, 55, 79, DateTimeKind.Utc).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 11, 16, 27, 55, 79, DateTimeKind.Utc).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 11, 16, 27, 55, 79, DateTimeKind.Utc).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 11, 16, 27, 55, 79, DateTimeKind.Utc).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 11, 16, 27, 55, 79, DateTimeKind.Utc).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 11, 16, 27, 55, 79, DateTimeKind.Utc).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 11, 16, 27, 55, 79, DateTimeKind.Utc).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 11, 16, 27, 55, 79, DateTimeKind.Utc).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 11, 16, 27, 55, 79, DateTimeKind.Utc).AddTicks(1745));
        }
    }
}
