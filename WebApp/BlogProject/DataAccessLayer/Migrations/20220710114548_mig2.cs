using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cat_ID",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryCat_ID",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CategoryCat_ID",
                table: "Blogs",
                column: "CategoryCat_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Categories_CategoryCat_ID",
                table: "Blogs",
                column: "CategoryCat_ID",
                principalTable: "Categories",
                principalColumn: "Cat_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Categories_CategoryCat_ID",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_CategoryCat_ID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "Cat_ID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "CategoryCat_ID",
                table: "Blogs");
        }
    }
}
