using Microsoft.EntityFrameworkCore.Migrations;

namespace FundooApplication.Migrations
{
    public partial class FundooApplicationModelUserContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[] { 1L, "Prasahantbhure50@gmail.com", "Prashant", "Bhure" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[] { 2L, "dipesh.walte@bridgelabz.com", "Dipesh", "Walte" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2L);
        }
    }
}
