using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceManagements.Infrastructure.EFCore.Migrations
{
    public partial class Create_Plans : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ServiceName",
                table: "Services",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ServiceLogo",
                table: "Services",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ServiceDescription",
                table: "Services",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Plans",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PlanPrice = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    PlanDescription1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlanDescription2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlanDescription3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlanDescription4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlanDescription5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlanDescription6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlanDescription7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlanDescription8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlanDescription9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlanDescription10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.AlterColumn<string>(
                name: "ServiceName",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "ServiceLogo",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "ServiceDescription",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
