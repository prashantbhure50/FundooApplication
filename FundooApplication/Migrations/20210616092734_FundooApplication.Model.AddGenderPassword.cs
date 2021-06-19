using Microsoft.EntityFrameworkCore.Migrations;

namespace FundooApplication.Migrations
{
    public partial class FundooApplicationModelAddGenderPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Gender", "Password" },
                values: new object[] { "Male", "1234" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Gender", "Password" },
                values: new object[] { "Male", "9876" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Gender", "Password" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Gender", "Password" },
                values: new object[] { null, null });
        }
    }
}
