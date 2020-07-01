using Microsoft.EntityFrameworkCore.Migrations;

namespace Coding_Coalition_Project.Migrations
{
    public partial class subject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.AlterColumn<string>(
                name: "CourseSubject",
                table: "Courses",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {



            migrationBuilder.AlterColumn<int>(
                name: "CourseSubject",
                table: "Courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
