using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkDemo.Migrations
{
    /// <inheritdoc />
    public partial class addeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Surrencies",
                columns: new[] { "Id", "CurrencyCode", "CurrencyName" },
                values: new object[] { 1, "INR", "INR" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Surrencies",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
