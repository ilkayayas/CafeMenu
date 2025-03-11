using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CafeMenu.Migrations
{
    /// <inheritdoc />
    public partial class CategorySeedAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "CreatedDate", "CreatorUserId", "IsDeleted", "ParentCategoryId" },
                values: new object[,]
                {
                    { 1, "Kategori 1", new DateTime(2025, 3, 11, 23, 54, 10, 460, DateTimeKind.Local), 1, false, 0 },
                    { 2, "Kategori 2", new DateTime(2025, 3, 11, 23, 54, 10, 460, DateTimeKind.Local), 1, false, 0 },
                    { 3, "Kategori 1-1", new DateTime(2025, 3, 11, 23, 54, 10, 460, DateTimeKind.Local), 1, false, 1 },
                    { 4, "Kategori 1-2", new DateTime(2025, 3, 11, 23, 54, 10, 460, DateTimeKind.Local), 1, false, 1 },
                    { 5, "Kategori 1-1-1", new DateTime(2025, 3, 11, 23, 54, 10, 460, DateTimeKind.Local), 1, false, 3 },
                    { 6, "Kategori 1-1-2", new DateTime(2025, 3, 11, 23, 54, 10, 460, DateTimeKind.Local), 1, true, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);
        }
    }
}
