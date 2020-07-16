using Microsoft.EntityFrameworkCore.Migrations;

namespace Coding_Coalition_Project.Migrations
{
    public partial class updateUserInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
               name: "CreditHours",
               table: "UserInfo",
               nullable: false);

            migrationBuilder.AddColumn<int>(
                name: "AccountCharges",
                table: "UserInfo",
                nullable: false);

            migrationBuilder.AddColumn<int>(
               name: "AccountPayments",
               table: "UserInfo",
               nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
