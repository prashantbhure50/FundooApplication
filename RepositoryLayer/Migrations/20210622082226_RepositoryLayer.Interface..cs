using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class RepositoryLayerInterface : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LabelNote_Notes_NoteId",
                table: "LabelNote");

            migrationBuilder.DropForeignKey(
                name: "FK_LabelNote_User_UsersUserId",
                table: "LabelNote");

            migrationBuilder.DropForeignKey(
                name: "FK_Notes_User_UsersUserId",
                table: "Notes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserNote",
                table: "UserNote");

            migrationBuilder.DropIndex(
                name: "IX_Notes_UsersUserId",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_LabelNote_NoteId",
                table: "LabelNote");

            migrationBuilder.DropIndex(
                name: "IX_LabelNote_UsersUserId",
                table: "LabelNote");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserNote");

            migrationBuilder.DropColumn(
                name: "UsersUserId",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "LabelBody",
                table: "Labels");

            migrationBuilder.DropColumn(
                name: "NoteId",
                table: "Labels");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Labels");

            migrationBuilder.DropColumn(
                name: "NoteId",
                table: "LabelNote");

            migrationBuilder.DropColumn(
                name: "UsersUserId",
                table: "LabelNote");

            migrationBuilder.AlterColumn<int>(
                name: "NoteId",
                table: "UserNote",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Note_Id",
                table: "UserNote",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "LabelId",
                table: "UserNote",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LabelName",
                table: "Labels",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Label_Id",
                table: "LabelNote",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NotesId",
                table: "LabelNote",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "LabelNote",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserNote",
                table: "UserNote",
                column: "Note_Id");

            migrationBuilder.CreateIndex(
                name: "IX_UserNote_LabelId",
                table: "UserNote",
                column: "LabelId");

            migrationBuilder.CreateIndex(
                name: "IX_UserNote_NoteId",
                table: "UserNote",
                column: "NoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_UserId",
                table: "Notes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LabelNote_NotesId",
                table: "LabelNote",
                column: "NotesId");

            migrationBuilder.CreateIndex(
                name: "IX_LabelNote_UserId",
                table: "LabelNote",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_LabelNote_Labels_LabelId",
                table: "LabelNote",
                column: "LabelId",
                principalTable: "Labels",
                principalColumn: "LabelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LabelNote_Notes_NotesId",
                table: "LabelNote",
                column: "NotesId",
                principalTable: "Notes",
                principalColumn: "NotesId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LabelNote_User_UserId",
                table: "LabelNote",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_User_UserId",
                table: "Notes",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserNote_Labels_LabelId",
                table: "UserNote",
                column: "LabelId",
                principalTable: "Labels",
                principalColumn: "LabelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserNote_Notes_NoteId",
                table: "UserNote",
                column: "NoteId",
                principalTable: "Notes",
                principalColumn: "NotesId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LabelNote_Labels_LabelId",
                table: "LabelNote");

            migrationBuilder.DropForeignKey(
                name: "FK_LabelNote_Notes_NotesId",
                table: "LabelNote");

            migrationBuilder.DropForeignKey(
                name: "FK_LabelNote_User_UserId",
                table: "LabelNote");

            migrationBuilder.DropForeignKey(
                name: "FK_Notes_User_UserId",
                table: "Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_UserNote_Labels_LabelId",
                table: "UserNote");

            migrationBuilder.DropForeignKey(
                name: "FK_UserNote_Notes_NoteId",
                table: "UserNote");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserNote",
                table: "UserNote");

            migrationBuilder.DropIndex(
                name: "IX_UserNote_LabelId",
                table: "UserNote");

            migrationBuilder.DropIndex(
                name: "IX_UserNote_NoteId",
                table: "UserNote");

            migrationBuilder.DropIndex(
                name: "IX_Notes_UserId",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_LabelNote_NotesId",
                table: "LabelNote");

            migrationBuilder.DropIndex(
                name: "IX_LabelNote_UserId",
                table: "LabelNote");

            migrationBuilder.DropColumn(
                name: "Note_Id",
                table: "UserNote");

            migrationBuilder.DropColumn(
                name: "LabelId",
                table: "UserNote");

            migrationBuilder.DropColumn(
                name: "LabelName",
                table: "Labels");

            migrationBuilder.DropColumn(
                name: "Label_Id",
                table: "LabelNote");

            migrationBuilder.DropColumn(
                name: "NotesId",
                table: "LabelNote");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "LabelNote");

            migrationBuilder.AlterColumn<int>(
                name: "NoteId",
                table: "UserNote",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "UserNote",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsersUserId",
                table: "Notes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LabelBody",
                table: "Labels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NoteId",
                table: "Labels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Labels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NoteId",
                table: "LabelNote",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsersUserId",
                table: "LabelNote",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserNote",
                table: "UserNote",
                column: "NoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_UsersUserId",
                table: "Notes",
                column: "UsersUserId");

            migrationBuilder.CreateIndex(
                name: "IX_LabelNote_NoteId",
                table: "LabelNote",
                column: "NoteId");

            migrationBuilder.CreateIndex(
                name: "IX_LabelNote_UsersUserId",
                table: "LabelNote",
                column: "UsersUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_LabelNote_Notes_NoteId",
                table: "LabelNote",
                column: "NoteId",
                principalTable: "Notes",
                principalColumn: "NotesId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LabelNote_User_UsersUserId",
                table: "LabelNote",
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
    }
}
