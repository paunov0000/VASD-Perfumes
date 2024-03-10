using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MinorTweaksToReviewEntityAndRenamedAndAddedCommentsToOtherEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "StatusName",
                table: "OrderStatuses");

            migrationBuilder.AlterTable(
                name: "OrderStatuses",
                comment: "Holds info for the Status of the Order");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Date of creating the review");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "Reviews",
                type: "datetime2",
                nullable: true,
                comment: "Date of updating the review");

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Foreign key of the Category",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Foreign key of the category");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "OrderStatuses",
                type: "int",
                nullable: false,
                comment: "Primary key of the Order Status",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "OrderStatuses",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                comment: "Name of the Order Status");

            migrationBuilder.AlterColumn<int>(
                name: "OrderStatusId",
                table: "Orders",
                type: "int",
                nullable: false,
                comment: "Foreign key of the OrderStatus",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Zip",
                table: "Customers",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true,
                comment: "Zip of the Customer entity",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Zip of the Customer entity");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                comment: "State of the Customer entity",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "State of the Customer entity");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                comment: "City of the Customer entity",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "City of the Customer entity");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                comment: "Address of the Customer entity",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Address of the Customer entity");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("753efde4-efa1-4f88-abc9-8f091cf8b670"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4a3efa90-71a0-47c9-8336-9632df618470", "AQAAAAIAAYagAAAAEBAg4mAe1TL73U9JGt8Z1AhBdd2XBdbteq+Znbl0vf4LDaGcPeh4hpomFxrxDzHCBQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e5661aa3-6646-40cd-bbb3-090d23c435c5", "AQAAAAIAAYagAAAAEAW2+YOcEt0fSaL96B77Y9hYl7H49s/VZ3eOUW8KwKtyFP+afLvPpw0yZlb9vyoFZA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 14, 20, 30, 506, DateTimeKind.Utc).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 14, 20, 30, 506, DateTimeKind.Utc).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 14, 20, 30, 506, DateTimeKind.Utc).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 14, 20, 30, 506, DateTimeKind.Utc).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 14, 20, 30, 506, DateTimeKind.Utc).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 14, 20, 30, 506, DateTimeKind.Utc).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 14, 20, 30, 506, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 14, 20, 30, 506, DateTimeKind.Utc).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 14, 20, 30, 506, DateTimeKind.Utc).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 14, 20, 30, 506, DateTimeKind.Utc).AddTicks(7056));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "OrderStatuses");

            migrationBuilder.AlterTable(
                name: "OrderStatuses",
                oldComment: "Holds info for the Status of the Order");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Date of the review");

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Date of updating the review");

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Foreign key of the category",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Foreign key of the Category");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "OrderStatuses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Primary key of the Order Status")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "StatusName",
                table: "OrderStatuses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "OrderStatusId",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Foreign key of the OrderStatus");

            migrationBuilder.AlterColumn<string>(
                name: "Zip",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Zip of the Customer entity",
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4,
                oldNullable: true,
                oldComment: "Zip of the Customer entity");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                comment: "State of the Customer entity",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldComment: "State of the Customer entity");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                comment: "City of the Customer entity",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true,
                oldComment: "City of the Customer entity");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Address of the Customer entity",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true,
                oldComment: "Address of the Customer entity");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("753efde4-efa1-4f88-abc9-8f091cf8b670"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e0497402-fd3a-4ee4-8b50-88ff70b4332f", "AQAAAAIAAYagAAAAEIHwa7PnKkbHoaArlmAOLb8r2SV7dqmwdXG+sFI6ZqRJX3CS6p19WxeW0hnYJeppLw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "28f3b6de-a072-44e1-a278-e8281af6617e", "AQAAAAIAAYagAAAAEHtvqKSA9bENB/HHVmGeWSXvSG9y8lIjcVEF58afN8nUfeJCWhz/CoUKs71HqOrViQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 13, 48, 54, 944, DateTimeKind.Utc).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 13, 48, 54, 944, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 13, 48, 54, 944, DateTimeKind.Utc).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 13, 48, 54, 944, DateTimeKind.Utc).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 13, 48, 54, 944, DateTimeKind.Utc).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 13, 48, 54, 944, DateTimeKind.Utc).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 13, 48, 54, 944, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 13, 48, 54, 944, DateTimeKind.Utc).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 13, 48, 54, 944, DateTimeKind.Utc).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                column: "CreatedOn",
                value: new DateTime(2024, 3, 10, 13, 48, 54, 944, DateTimeKind.Utc).AddTicks(6606));
        }
    }
}
