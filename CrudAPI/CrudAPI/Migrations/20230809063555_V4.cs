using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CrudAPI.Migrations
{
    /// <inheritdoc />
    public partial class V4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4088a321-6d9c-410d-8f1d-8132eedcc5d7", "2", "Admin", "Admin" },
                    { "d91c618d-ddef-468b-814b-d9b236ca41b3", "3", "User", "User" },
                    { "fdeb8265-cad2-4718-83a5-16fb6a96a232", "1", "HR", "HR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4088a321-6d9c-410d-8f1d-8132eedcc5d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d91c618d-ddef-468b-814b-d9b236ca41b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdeb8265-cad2-4718-83a5-16fb6a96a232");
        }
    }
}
