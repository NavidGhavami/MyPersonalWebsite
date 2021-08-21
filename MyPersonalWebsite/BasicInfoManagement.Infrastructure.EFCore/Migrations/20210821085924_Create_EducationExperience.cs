using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalInfoManagement.Infrastructure.EFCore.Migrations
{
    public partial class Create_EducationExperience : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EducationExperience",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniversityName = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false),
                    EducationDegree = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false),
                    EducationCourse = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false),
                    EducationDate = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationExperience", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EducationExperience");
        }
    }
}
