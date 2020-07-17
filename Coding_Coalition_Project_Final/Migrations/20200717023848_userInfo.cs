using Microsoft.EntityFrameworkCore.Migrations;

namespace Coding_Coalition_Project.Migrations
{
    public partial class userInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Twitter",
                table: "UserInfo",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "UserInfo",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Linkedin",
                table: "UserInfo",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreditHours",
                table: "UserInfo",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Biography",
                table: "UserInfo",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountPayments",
                table: "UserInfo",
                nullable: true);


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
