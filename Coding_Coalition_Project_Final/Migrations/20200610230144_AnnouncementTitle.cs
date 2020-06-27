using Microsoft.EntityFrameworkCore.Migrations;

namespace Coding_Coalition_Project.Migrations
{
    public partial class AnnouncementTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AnnouncementTitle",
                table: "Announcements",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnnouncementTitle",
                table: "Announcements");
        }
    }
}
