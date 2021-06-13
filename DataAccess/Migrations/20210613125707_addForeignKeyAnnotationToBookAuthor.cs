using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class addForeignKeyAnnotationToBookAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookAuthors_authors_Author_Id1",
                table: "bookAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_bookAuthors_books_Book_Id1",
                table: "bookAuthors");

            migrationBuilder.DropIndex(
                name: "IX_bookAuthors_Author_Id1",
                table: "bookAuthors");

            migrationBuilder.DropIndex(
                name: "IX_bookAuthors_Book_Id1",
                table: "bookAuthors");

            migrationBuilder.DropColumn(
                name: "Author_Id1",
                table: "bookAuthors");

            migrationBuilder.DropColumn(
                name: "Book_Id1",
                table: "bookAuthors");

            migrationBuilder.CreateIndex(
                name: "IX_bookAuthors_Book_Id",
                table: "bookAuthors",
                column: "Book_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_bookAuthors_authors_Author_Id",
                table: "bookAuthors",
                column: "Author_Id",
                principalTable: "authors",
                principalColumn: "Author_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_bookAuthors_books_Book_Id",
                table: "bookAuthors",
                column: "Book_Id",
                principalTable: "books",
                principalColumn: "Book_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookAuthors_authors_Author_Id",
                table: "bookAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_bookAuthors_books_Book_Id",
                table: "bookAuthors");

            migrationBuilder.DropIndex(
                name: "IX_bookAuthors_Book_Id",
                table: "bookAuthors");

            migrationBuilder.AddColumn<int>(
                name: "Author_Id1",
                table: "bookAuthors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Book_Id1",
                table: "bookAuthors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_bookAuthors_Author_Id1",
                table: "bookAuthors",
                column: "Author_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_bookAuthors_Book_Id1",
                table: "bookAuthors",
                column: "Book_Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_bookAuthors_authors_Author_Id1",
                table: "bookAuthors",
                column: "Author_Id1",
                principalTable: "authors",
                principalColumn: "Author_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_bookAuthors_books_Book_Id1",
                table: "bookAuthors",
                column: "Book_Id1",
                principalTable: "books",
                principalColumn: "Book_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
