using Microsoft.EntityFrameworkCore.Migrations;

namespace Exmination.Migrations
{
    public partial class examinationcenterupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "ExameCenter",
                table: "Enrollments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExameCenter",
                table: "Enrollments");

            migrationBuilder.AddColumn<string>(
                name: "ExameCenterCh1",
                table: "Enrollments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExameCenterCh2",
                table: "Enrollments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExameCenterCh3",
                table: "Enrollments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
