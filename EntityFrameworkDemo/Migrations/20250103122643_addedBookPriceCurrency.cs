using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkDemo.Migrations
{
    /// <inheritdoc />
    public partial class addedBookPriceCurrency : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Language_LanguageId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Language",
                table: "Language");

            migrationBuilder.RenameTable(
                name: "Language",
                newName: "Languages");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Languages",
                table: "Languages",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Surrencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrencyName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surrencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BooksPrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    CurrencyId = table.Column<float>(type: "real", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    CurrencyId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksPrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BooksPrices_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BooksPrices_Surrencies_CurrencyId1",
                        column: x => x.CurrencyId1,
                        principalTable: "Surrencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BooksPrices_BookId",
                table: "BooksPrices",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BooksPrices_CurrencyId1",
                table: "BooksPrices",
                column: "CurrencyId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Languages_LanguageId",
                table: "Books",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Languages_LanguageId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "BooksPrices");

            migrationBuilder.DropTable(
                name: "Surrencies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Languages",
                table: "Languages");

            migrationBuilder.RenameTable(
                name: "Languages",
                newName: "Language");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Language",
                table: "Language",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Language_LanguageId",
                table: "Books",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
