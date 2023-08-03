using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudAPI.Migrations
{
    /// <inheritdoc />
    public partial class V2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountTypeId",
                table: "BankTransactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaymentMethodId",
                table: "BankTransactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BankTransactions_AccountTypeId",
                table: "BankTransactions",
                column: "AccountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BankTransactions_PaymentMethodId",
                table: "BankTransactions",
                column: "PaymentMethodId");

            migrationBuilder.AddForeignKey(
                name: "FK_BankTransactions_AccountTypes_AccountTypeId",
                table: "BankTransactions",
                column: "AccountTypeId",
                principalTable: "AccountTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BankTransactions_PaymentMethods_PaymentMethodId",
                table: "BankTransactions",
                column: "PaymentMethodId",
                principalTable: "PaymentMethods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankTransactions_AccountTypes_AccountTypeId",
                table: "BankTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_BankTransactions_PaymentMethods_PaymentMethodId",
                table: "BankTransactions");

            migrationBuilder.DropIndex(
                name: "IX_BankTransactions_AccountTypeId",
                table: "BankTransactions");

            migrationBuilder.DropIndex(
                name: "IX_BankTransactions_PaymentMethodId",
                table: "BankTransactions");

            migrationBuilder.DropColumn(
                name: "AccountTypeId",
                table: "BankTransactions");

            migrationBuilder.DropColumn(
                name: "PaymentMethodId",
                table: "BankTransactions");
        }
    }
}
