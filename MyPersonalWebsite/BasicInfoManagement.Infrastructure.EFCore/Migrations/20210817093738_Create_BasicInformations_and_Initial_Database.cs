using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalInfoManagement.Infrastructure.EFCore.Migrations
{
    public partial class Create_BasicInformations_and_Initial_Database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BasicInformations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Family = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Job = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Instagram = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    Language = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false),
                    Experience = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    CompleteProject = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    HappyCustomers = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Articles = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    PersianResume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishResume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecommendationLetters = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicInformations", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasicInformations");
        }
    }
}
