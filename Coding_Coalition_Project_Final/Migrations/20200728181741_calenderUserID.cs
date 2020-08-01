using Microsoft.EntityFrameworkCore.Migrations;

namespace Coding_Coalition_Project.Migrations
{
    public partial class calenderUserID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SubmitAssignment",
                table: "SubmitAssignment");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Calender",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "submissionType",
                table: "SubmitAssignment",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubmitAssignment",
                table: "SubmitAssignment",
                column: "SAssignmentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SubmitAssignment",
                table: "SubmitAssignment");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Calender");

            migrationBuilder.AlterColumn<string>(
                name: "submissionType",
                table: "SubmitAssignment",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubmitAssignment",
                table: "SubmitAssignment",
                column: "SAssignmentID");
        }
    }
}
