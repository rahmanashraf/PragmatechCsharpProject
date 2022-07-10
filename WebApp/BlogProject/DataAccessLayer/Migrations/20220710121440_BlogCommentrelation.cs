using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class BlogCommentrelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Blog_ID",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Blog_ID1",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Blog_ID1",
                table: "Comments",
                column: "Blog_ID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Blogs_Blog_ID1",
                table: "Comments",
                column: "Blog_ID1",
                principalTable: "Blogs",
                principalColumn: "Blog_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Blogs_Blog_ID1",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_Blog_ID1",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Blog_ID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Blog_ID1",
                table: "Comments");
        }
    }
}
