using Microsoft.EntityFrameworkCore.Migrations;

namespace Šitie.Migrations
{
    public partial class Users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsAdmin", "Name", "Password", "Surname" },
                values: new object[] { 1, "vardenis.pvardenis@gmail.com", true, "Vardenis", "123456", "Pavardenis" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsAdmin", "Name", "Password", "Surname" },
                values: new object[] { 2, "domas@gmail.com", false, "Domas", "asdfasfsafas", "Domaitis" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsAdmin", "Name", "Password", "Surname" },
                values: new object[] { 3, "lukas.lukaitis@gmail.com", false, "Lukas", "12345678", "Lukaitis" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
