using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RatingAPP.Data.Migrations
{
    /// <inheritdoc />
    public partial class books4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Comment_BookId",
                table: "Comment",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Book_BookId",
                table: "Comment",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Book_BookId",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_BookId",
                table: "Comment");
        }
    }
}
