using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace prueba.Server.Data.Migrations
{
    public partial class PersonSeedConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[] { 1, 1, "Doris" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[] { 2, 2, "Maria" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
