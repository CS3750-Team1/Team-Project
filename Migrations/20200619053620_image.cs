using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Coding_Coalition_Project.Migrations
{
    public partial class image : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "UserInfo",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "UserImage",
                table: "UserInfo",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "UserInfo");

            migrationBuilder.DropColumn(
                name: "UserImage",
                table: "UserInfo");
        }
    }
}
