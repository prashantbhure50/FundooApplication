using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class RepositoryLayerInterfaceUserContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_User_UsersId",
                table: "Notes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Notes_UsersId",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Notes");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "User",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "UsersUserId",
                table: "Notes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsersUserId",
                table: "Labels",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_UsersUserId",
                table: "Notes",
                column: "UsersUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Labels_UsersUserId",
                table: "Labels",
                column: "UsersUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Labels_User_UsersUserId",
                table: "Labels",
                column: "UsersUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_User_UsersUserId",
                table: "Notes",
                column: "UsersUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Labels_User_UsersUserId",
                table: "Labels");

            migrationBuilder.DropForeignKey(
                name: "FK_Notes_User_UsersUserId",
                table: "Notes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Notes_UsersUserId",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Labels_UsersUserId",
                table: "Labels");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UsersUserId",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "UsersUserId",
                table: "Labels");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "Notes",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_UsersId",
                table: "Notes",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_User_UsersId",
                table: "Notes",
                column: "UsersId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
