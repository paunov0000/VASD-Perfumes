using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemovedFragrancePyramidsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FragrancePyramids");

            migrationBuilder.AddColumn<string>(
                name: "BaseNotes",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MiddleNotes",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TopNotes",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("753efde4-efa1-4f88-abc9-8f091cf8b670"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "378a03da-78ff-46cc-8eef-ac9191e6a135", "AQAAAAIAAYagAAAAEA1XdINKTHKH65mtw4LsyjD9wS3Ai7hOlZ/9dhoJqta+LfDMAbmgj8zi03TVRWm34A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac252767-c377-413d-96fd-98d9888ddea7", "AQAAAAIAAYagAAAAEAsncSMbxL2EpD7zR+pa157EbDc5lvp/7X5e55CjKgEDwQZoD4DVEMGytuKbhRyGew==" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 4, 26, 18, 38, 52, 945, DateTimeKind.Utc).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                columns: new[] { "BaseNotes", "CreatedOn", "MiddleNotes", "TopNotes" },
                values: new object[] { null, new DateTime(2024, 4, 26, 18, 38, 52, 818, DateTimeKind.Utc).AddTicks(5584), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                columns: new[] { "BaseNotes", "CreatedOn", "MiddleNotes", "TopNotes" },
                values: new object[] { null, new DateTime(2024, 4, 26, 18, 38, 52, 818, DateTimeKind.Utc).AddTicks(5580), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                columns: new[] { "BaseNotes", "CreatedOn", "MiddleNotes", "TopNotes" },
                values: new object[] { null, new DateTime(2024, 4, 26, 18, 38, 52, 818, DateTimeKind.Utc).AddTicks(5576), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                columns: new[] { "BaseNotes", "CreatedOn", "MiddleNotes", "TopNotes" },
                values: new object[] { "Mexican Chocolate, Patchouli, Vanille, Incense, Amber, Sandalwood, Vetiver, White Musk", new DateTime(2024, 4, 26, 18, 38, 52, 818, DateTimeKind.Utc).AddTicks(5572), "Orchid, Spices, Gardenia, Fruity Notes, Ylang-Ylang, Jasmine, Lostus", "Truffle, Gardenia, Black Currant, Ylang-Ylang, Jasmine, Bergamot, Mandarin Orange, Amalfi Lemon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                columns: new[] { "BaseNotes", "CreatedOn", "MiddleNotes", "TopNotes" },
                values: new object[] { "Opoponax, Amber, Patchouli, Vanille", new DateTime(2024, 4, 26, 18, 38, 52, 818, DateTimeKind.Utc).AddTicks(5568), "Myrhh, Jasmine", "Mandarin Orange, Bergamot, Lily-of-the-Valley" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                columns: new[] { "BaseNotes", "CreatedOn", "MiddleNotes", "TopNotes" },
                values: new object[] { null, new DateTime(2024, 4, 26, 18, 38, 52, 818, DateTimeKind.Utc).AddTicks(5563), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "BaseNotes", "CreatedOn", "MiddleNotes", "TopNotes" },
                values: new object[] { null, new DateTime(2024, 4, 26, 18, 38, 52, 818, DateTimeKind.Utc).AddTicks(5559), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                columns: new[] { "BaseNotes", "CreatedOn", "MiddleNotes", "TopNotes" },
                values: new object[] { "Orris Root, Honeysuckle", new DateTime(2024, 4, 26, 18, 38, 52, 818, DateTimeKind.Utc).AddTicks(5554), "Tuberose", "Jasmine" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                columns: new[] { "BaseNotes", "CreatedOn", "MiddleNotes", "TopNotes" },
                values: new object[] { null, new DateTime(2024, 4, 26, 18, 38, 52, 818, DateTimeKind.Utc).AddTicks(5549), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                columns: new[] { "BaseNotes", "CreatedOn", "MiddleNotes", "TopNotes" },
                values: new object[] { null, new DateTime(2024, 4, 26, 18, 38, 52, 818, DateTimeKind.Utc).AddTicks(5541), null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BaseNotes",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MiddleNotes",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TopNotes",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "FragrancePyramids",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BaseNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TopNotes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FragrancePyramids", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FragrancePyramids_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("753efde4-efa1-4f88-abc9-8f091cf8b670"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6f74309b-cca4-46e2-95cb-5770284f253a", "AQAAAAIAAYagAAAAEMb3XRY/BcHMA48mibiciRG87jld9r4phSX6DDqq60Qib+edVy4lt0QjdkCppwKiKw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "958435d7-d9a4-45cf-8c7d-d04ca35574be", "AQAAAAIAAYagAAAAEHvPnnWp8PBw8v9omaqHcvM9ofvovZazJQut9DhI29cAoMz+dKiifwFFidbY64HM3w==" });

            migrationBuilder.InsertData(
                table: "FragrancePyramids",
                columns: new[] { "Id", "BaseNotes", "MiddleNotes", "ProductId", "TopNotes" },
                values: new object[,]
                {
                    { 1, "Mexican Chocolate, Patchouli, Vanille, Incense, Amber, Sandalwood, Vetiver, White Musk", "Orchid, Spices, Gardenia, Fruity Notes, Ylang-Ylang, Jasmine, Lostus", new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"), "Truffle, Gardenia, Black Currant, Ylang-Ylang, Jasmine, Bergamot, Mandarin Orange, Amalfi Lemon" },
                    { 2, "Orris Root, Honeysuckle", "Tuberose", new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"), "Jasmine" },
                    { 3, "Opoponax, Amber, Patchouli, Vanille", "Myrhh, Jasmine", new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"), "Mandarin Orange, Bergamot, Lily-of-the-Valley" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 4, 26, 8, 45, 18, 174, DateTimeKind.Utc).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b66"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 26, 8, 45, 18, 19, DateTimeKind.Utc).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b67"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 26, 8, 45, 18, 19, DateTimeKind.Utc).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b68"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 26, 8, 45, 18, 19, DateTimeKind.Utc).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b69"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 26, 8, 45, 18, 19, DateTimeKind.Utc).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6a"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 26, 8, 45, 18, 19, DateTimeKind.Utc).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6b"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 26, 8, 45, 18, 19, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 26, 8, 45, 18, 19, DateTimeKind.Utc).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6d"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 26, 8, 45, 18, 19, DateTimeKind.Utc).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6e"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 26, 8, 45, 18, 19, DateTimeKind.Utc).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6f"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 26, 8, 45, 18, 19, DateTimeKind.Utc).AddTicks(6552));

            migrationBuilder.CreateIndex(
                name: "IX_FragrancePyramids_ProductId",
                table: "FragrancePyramids",
                column: "ProductId",
                unique: true);
        }
    }
}
