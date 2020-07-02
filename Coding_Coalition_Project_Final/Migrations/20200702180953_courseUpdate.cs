using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Coding_Coalition_Project.Migrations
{
    public partial class courseUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseCapacity",
                table: "Courses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CourseCredits",
                table: "Courses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CourseLocation",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourseMeetingDay",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CourseMeetingTime",
                table: "Courses",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "AssignmentDescription",
                table: "Assignments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "submissionType",
                table: "Assignments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseCapacity",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseCredits",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseLocation",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseMeetingDay",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseMeetingTime",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "AssignmentDescription",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "submissionType",
                table: "Assignments");
        }
    }
}
