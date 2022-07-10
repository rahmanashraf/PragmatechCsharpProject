using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Blogs_Blog_ID1",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "Blog_ID1",
                table: "Comments",
                newName: "BlogsBlog_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_Blog_ID1",
                table: "Comments",
                newName: "IX_Comments_BlogsBlog_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Blogs_BlogsBlog_ID",
                table: "Comments",
                column: "BlogsBlog_ID",
                principalTable: "Blogs",
                principalColumn: "Blog_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Blogs_BlogsBlog_ID",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "BlogsBlog_ID",
                table: "Comments",
                newName: "Blog_ID1");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_BlogsBlog_ID",
                table: "Comments",
                newName: "IX_Comments_Blog_ID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Blogs_Blog_ID1",
                table: "Comments",
                column: "Blog_ID1",
                principalTable: "Blogs",
                principalColumn: "Blog_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
