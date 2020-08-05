using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Šitie.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArivalDate = table.Column<DateTime>(nullable: false),
                    ChipDate = table.Column<DateTime>(nullable: false),
                    VaccineDate = table.Column<DateTime>(nullable: false),
                    ArrivedFrom = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    BornDate = table.Column<DateTime>(nullable: false),
                    FurType = table.Column<int>(nullable: false),
                    FurColor = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    HealthCondition = table.Column<string>(nullable: true),
                    OrganizationData = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    DepartureDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    IsAdmin = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
