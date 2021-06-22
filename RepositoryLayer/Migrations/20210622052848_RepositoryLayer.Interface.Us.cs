using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class RepositoryLayerInterfaceUs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Labels_Notes_NoteId",
                table: "Labels");

            migrationBuilder.DropForeignKey(
                name: "FK_Labels_User_UsersUserId",
                table: "Labels");

            migrationBuilder.DropIndex(
                name: "IX_Labels_NoteId",
                table: "Labels");

            migrationBuilder.DropIndex(
                name: "IX_Labels_UsersUserId",
                table: "Labels");

            migrationBuilder.DropColumn(
                name: "LabelId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "NoteId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UsersUserId",
                table: "Labels");

            migrationBuilder.CreateTable(
                name: "LabelNote",
                columns: table => new
                {
                    LabelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoteId = table.Column<int>(nullable: false),
                    UsersUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabelNote", x => x.LabelId);
                    table.ForeignKey(
                        name: "FK_LabelNote_Notes_NoteId",
                        column: x => x.NoteId,
                        principalTable: "Notes",
                        principalColumn: "NotesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LabelNote_User_UsersUserId",
                        column: x => x.UsersUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserNote",
                columns: table => new
                {
                    NoteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNote", x => x.NoteId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LabelNote_NoteId",
                table: "LabelNote",
                column: "NoteId");

            migrationBuilder.CreateIndex(
                name: "IX_LabelNote_UsersUserId",
                table: "LabelNote",
                column: "UsersUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LabelNote");

            migrationBuilder.DropTable(
                name: "UserNote");

            migrationBuilder.AddColumn<int>(
                name: "LabelId",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NoteId",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsersUserId",
                table: "Labels",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Labels_NoteId",
                table: "Labels",
                column: "NoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Labels_UsersUserId",
                table: "Labels",
                column: "UsersUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Labels_Notes_NoteId",
                table: "Labels",
                column: "NoteId",
                principalTable: "Notes",
                principalColumn: "NotesId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Labels_User_UsersUserId",
                table: "Labels",
                column: "UsersUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
