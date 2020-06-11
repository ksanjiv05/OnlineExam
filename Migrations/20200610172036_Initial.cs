using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Exmination.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address_ = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Pincode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EximinationCenters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Code = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Pincode = table.Column<string>(nullable: false),
                    CenterInchargeName = table.Column<string>(nullable: false),
                    CenterInchargeEmail = table.Column<string>(nullable: false),
                    SeatAvailable = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EximinationCenters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Registations",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Registration_number = table.Column<string>(nullable: false),
                    ExaminationApplied = table.Column<string>(nullable: false),
                    CandidateName = table.Column<string>(nullable: false),
                    Mobile = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registations", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: false),
                    ContactNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Father = table.Column<string>(nullable: false),
                    Mobile = table.Column<string>(nullable: true),
                    ParmanentAddressId = table.Column<int>(nullable: false),
                    SameAsParmanent = table.Column<bool>(nullable: false),
                    CorrespondanceAddressId = table.Column<int>(nullable: true),
                    Programm = table.Column<string>(nullable: true),
                    ExameCenterCh1 = table.Column<string>(nullable: true),
                    ExameCenterCh2 = table.Column<string>(nullable: true),
                    ExameCenterCh3 = table.Column<string>(nullable: true),
                    Profile = table.Column<string>(nullable: false),
                    Signature = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enrollments_Address_CorrespondanceAddressId",
                        column: x => x.CorrespondanceAddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Enrollments_Address_ParmanentAddressId",
                        column: x => x.ParmanentAddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_CorrespondanceAddressId",
                table: "Enrollments",
                column: "CorrespondanceAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_ParmanentAddressId",
                table: "Enrollments",
                column: "ParmanentAddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "EximinationCenters");

            migrationBuilder.DropTable(
                name: "Registations");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
