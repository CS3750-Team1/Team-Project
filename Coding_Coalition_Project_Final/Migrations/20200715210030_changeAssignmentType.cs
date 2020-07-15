using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Coding_Coalition_Project.Migrations
{
    public partial class changeAssignmentType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.DropColumn(
                name: "AssignmentCode",
                table: "Assignments");

            

            migrationBuilder.AddColumn<string>(
                name: "AssignmentType",
                table: "Assignments",
                nullable: true);


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.DropColumn(
                name: "AssignmentType",
                table: "Assignments");

         
            migrationBuilder.AddColumn<int>(
                name: "AssignmentCode",
                table: "Assignments",
                type: "int",
                nullable: false,
                defaultValue: 0);


        }
    }
}
