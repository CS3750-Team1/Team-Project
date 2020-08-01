using Microsoft.EntityFrameworkCore.Migrations;

namespace Coding_Coalition_Project.Migrations
{
    public partial class submitAssignments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubmitAssignment",
                columns: table => new
                {
                    SAssignmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Points = table.Column<int>(nullable: true),
                    maxPoints = table.Column<int>(nullable:false),
                    submissionType = table.Column<string>(nullable:false),
                    AssignmentLocation = table.Column<string>(nullable:false),
                    UserID = table.Column<int>(nullable:false),
                    CourseID = table.Column<int>(nullable:false),
                    AssignmentID = table.Column<int>(nullable:false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubmitAssignment", x => x.SAssignmentID);
                });


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubmitAssignment");
        }
    }
}
