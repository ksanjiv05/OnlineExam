using Microsoft.EntityFrameworkCore.Migrations;

namespace Exmination.Migrations
{
    public partial class addadmitcard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Catagory",
                table: "Enrollments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sex",
                table: "Enrollments",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StudentAdmitCards",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Roll = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    ExameDate = table.Column<string>(nullable: true),
                    reportingTime = table.Column<string>(nullable: true),
                    EntryClosingTime = table.Column<string>(nullable: true),
                    GenrateExameFor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAdmitCards", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentAdmitCards");

            migrationBuilder.DropColumn(
                name: "Catagory",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "Sex",
                table: "Enrollments");
        }
    }
}
