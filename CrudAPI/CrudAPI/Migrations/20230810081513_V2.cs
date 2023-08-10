using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CrudAPI.Migrations
{
    /// <inheritdoc />
    public partial class V2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31ec1f5f-6362-4416-9f33-b15aa2f4dc9e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50e4b27c-5279-42d2-a613-475624ee72e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e8a1b05-43b4-442d-b436-e81491a98fcb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2f543be9-98a6-4331-8709-2e476fe5c5b0", "3", "HR", "HR" },
                    { "db7d6bda-8849-44be-b9e3-b80da566b882", "2", "User", "User" },
                    { "e9f6c105-c044-4239-8aa4-a7a3892fbe57", "1", "Admin", "Admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f543be9-98a6-4331-8709-2e476fe5c5b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db7d6bda-8849-44be-b9e3-b80da566b882");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9f6c105-c044-4239-8aa4-a7a3892fbe57");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "31ec1f5f-6362-4416-9f33-b15aa2f4dc9e", "3", "HR", "HR" },
                    { "50e4b27c-5279-42d2-a613-475624ee72e6", "1", "Admin", "Admin" },
                    { "6e8a1b05-43b4-442d-b436-e81491a98fcb", "2", "User", "User" }
                });
        }
    }
}
