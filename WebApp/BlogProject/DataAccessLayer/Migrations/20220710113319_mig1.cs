using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    About_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    About_Details1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    About_Details2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    About_Image1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    About_Image2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    About_MapLoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    About_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.About_ID);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Blog_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Blog_Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Blog_Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Blog_ThumbnailImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Blog_Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Blog_CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Blog_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Blog_ID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Cat_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cat_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cat_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cat_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Cat_ID);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Comment_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment_Writer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comment_Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comment_Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comment_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Comment_ID);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Contact_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contact_UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact_Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact_Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact_Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Contact_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Contact_ID);
                });

            migrationBuilder.CreateTable(
                name: "Writers",
                columns: table => new
                {
                    Writer_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Writer_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Writer_About = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Writer_Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Writer_Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Writer_Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Writer_Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Writers", x => x.Writer_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Writers");
        }
    }
}
