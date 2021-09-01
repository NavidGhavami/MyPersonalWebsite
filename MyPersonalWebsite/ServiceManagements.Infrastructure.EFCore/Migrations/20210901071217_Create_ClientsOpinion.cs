using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceManagements.Infrastructure.EFCore.Migrations
{
    public partial class Create_ClientsOpinion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientsOpinion",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ClientJob = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientsOpinion", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientsOpinion");
        }
    }
}
