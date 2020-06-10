using Microsoft.EntityFrameworkCore.Migrations;

namespace Exmination.Migrations
{
    public partial class update_enroll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ExameCenterCh1",
                table: "Enrollments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExameCenterCh2",
                table: "Enrollments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExameCenterCh3",
                table: "Enrollments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Profile",
                table: "Enrollments",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Signature",
                table: "Enrollments",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExameCenterCh1",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "ExameCenterCh2",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "ExameCenterCh3",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "Profile",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "Signature",
                table: "Enrollments");
        }
    }
}
