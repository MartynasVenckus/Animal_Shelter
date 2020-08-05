using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Šitie.Migrations
{
    public partial class Animals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "ArivalDate", "ArrivedFrom", "BornDate", "ChipDate", "DepartureDate", "Description", "FurColor", "FurType", "Gender", "HealthCondition", "OrganizationData", "Status", "Type", "VaccineDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 7, 26, 15, 3, 42, 695, DateTimeKind.Local).AddTicks(7901), "Kaunas", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 16, 15, 3, 42, 697, DateTimeKind.Local).AddTicks(9994), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Labai jautrus", "Rudas su juodais taškeliais", 1, 0, "Sveikas, trūksta 1 kojos", @"Katino svajonė 
                 Partizanų g. 15, Kaunas 50203 
                 (8-655) 15024", 0, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2020, 4, 27, 15, 3, 42, 698, DateTimeKind.Local).AddTicks(7911), "Vilnius", new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 26, 15, 3, 42, 698, DateTimeKind.Local).AddTicks(7941), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Labai miela, reikalauja dėmesio", "Juoda baltomis letenėlėmis", 2, 1, "Sveika, alergiška šunims", @"Katino svajonė 
                 Partizanų g. 15, Kaunas 50203 
                 (8-655) 15024", 0, 0, new DateTime(2015, 8, 5, 15, 3, 42, 698, DateTimeKind.Local).AddTicks(7951) },
                    { 3, new DateTime(2020, 6, 16, 15, 3, 42, 698, DateTimeKind.Local).AddTicks(8089), "Klaipėda", new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Driežas", "Žalsvai pilkas", 1, 0, "Sveikas", @"Katino svajonė 
                 Partizanų g. 15, Kaunas 50203 
                 (8-655) 15024", 0, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2020, 4, 27, 15, 3, 42, 698, DateTimeKind.Local).AddTicks(8096), "Kaunas", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 16, 15, 3, 42, 698, DateTimeKind.Local).AddTicks(8099), new DateTime(2020, 8, 4, 15, 3, 42, 698, DateTimeKind.Local).AddTicks(8104), "-", "Ruda", 0, 0, "Labai ligotas", @"Katino svajonė 
                 Partizanų g. 15, Kaunas 50203 
                 (8-655) 15024", 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2020, 4, 27, 15, 3, 42, 698, DateTimeKind.Local).AddTicks(8107), "Kaunas", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 16, 15, 3, 42, 698, DateTimeKind.Local).AddTicks(8110), new DateTime(2020, 8, 3, 15, 3, 42, 698, DateTimeKind.Local).AddTicks(8113), "-", "Ruda", 0, 0, "Truputi ligotas", @"Katino svajonė 
                 Partizanų g. 15, Kaunas 50203 
                 (8-655) 15024", 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2020, 4, 27, 15, 3, 42, 698, DateTimeKind.Local).AddTicks(8117), "Kaunas", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 16, 15, 3, 42, 698, DateTimeKind.Local).AddTicks(8120), new DateTime(2020, 7, 26, 15, 3, 42, 698, DateTimeKind.Local).AddTicks(8124), "-", "Ruda", 0, 1, "Puiki", @"Katino svajonė 
                 Partizanų g. 15, Kaunas 50203 
                 (8-655) 15024", 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
