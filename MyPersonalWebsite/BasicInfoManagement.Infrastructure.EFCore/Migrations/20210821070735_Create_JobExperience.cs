using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalInfoManagement.Infrastructure.EFCore.Migrations
{
    public partial class Create_JobExperience : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobExperience",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false),
                    JobPosition = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false),
                    WorkDate = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobExperience", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobExperience");
        }
    }
}
