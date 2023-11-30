using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentoringApp.Data.Migrations
{
    public partial class UpdateModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_MentorId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Connections_AspNetUsers_MentorId",
                table: "Connections");

            migrationBuilder.DropForeignKey(
                name: "FK_Connections_AspNetUsers_StudentId",
                table: "Connections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Connections",
                table: "Connections");

            migrationBuilder.RenameTable(
                name: "Connections",
                newName: "ConnectionRequests");

            migrationBuilder.RenameIndex(
                name: "IX_Connections_StudentId",
                table: "ConnectionRequests",
                newName: "IX_ConnectionRequests_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Connections_MentorId",
                table: "ConnectionRequests",
                newName: "IX_ConnectionRequests_MentorId");

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StudentId",
                table: "ConnectionRequests",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MentorId",
                table: "ConnectionRequests",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConnectionRequests",
                table: "ConnectionRequests",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_MentorId",
                table: "AspNetUsers",
                column: "MentorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ConnectionRequests_AspNetUsers_MentorId",
                table: "ConnectionRequests",
                column: "MentorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ConnectionRequests_AspNetUsers_StudentId",
                table: "ConnectionRequests",
                column: "StudentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_MentorId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ConnectionRequests_AspNetUsers_MentorId",
                table: "ConnectionRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_ConnectionRequests_AspNetUsers_StudentId",
                table: "ConnectionRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConnectionRequests",
                table: "ConnectionRequests");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "ConnectionRequests",
                newName: "Connections");

            migrationBuilder.RenameIndex(
                name: "IX_ConnectionRequests_StudentId",
                table: "Connections",
                newName: "IX_Connections_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_ConnectionRequests_MentorId",
                table: "Connections",
                newName: "IX_Connections_MentorId");

            migrationBuilder.AlterColumn<string>(
                name: "StudentId",
                table: "Connections",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "MentorId",
                table: "Connections",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Connections",
                table: "Connections",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_MentorId",
                table: "AspNetUsers",
                column: "MentorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Connections_AspNetUsers_MentorId",
                table: "Connections",
                column: "MentorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Connections_AspNetUsers_StudentId",
                table: "Connections",
                column: "StudentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
