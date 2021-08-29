using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceManagements.Infrastructure.EFCore.Migrations
{
    public partial class Create_Customers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CustomerLogo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoAlt = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    LogoTitle = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
