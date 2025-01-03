using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkDemo.Migrations
{
    /// <inheritdoc />
    public partial class tablerenamed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksPrices_Surrencies_CurrencyId1",
                table: "BooksPrices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Surrencies",
                table: "Surrencies");

            migrationBuilder.RenameTable(
                name: "Surrencies",
                newName: "Currencies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Currencies",
                table: "Currencies",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BooksPrices_Currencies_CurrencyId1",
                table: "BooksPrices",
                column: "CurrencyId1",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksPrices_Currencies_CurrencyId1",
                table: "BooksPrices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Currencies",
                table: "Currencies");

            migrationBuilder.RenameTable(
                name: "Currencies",
                newName: "Surrencies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Surrencies",
                table: "Surrencies",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BooksPrices_Surrencies_CurrencyId1",
                table: "BooksPrices",
                column: "CurrencyId1",
                principalTable: "Surrencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
