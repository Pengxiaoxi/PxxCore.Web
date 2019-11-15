using Microsoft.EntityFrameworkCore.Migrations;

namespace PxxCore.Web.Migrations
{
    public partial class V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Base_User",
                table: "Base_User");

            migrationBuilder.RenameTable(
                name: "Base_User",
                newName: "Base_User1");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Base_User1",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Base_User1",
                maxLength: 32,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifyBy",
                table: "Base_User1",
                maxLength: 32,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Base_User1",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddBy",
                table: "Base_User1",
                maxLength: 32,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Base_User1",
                table: "Base_User1",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Base_User1",
                table: "Base_User1");

            migrationBuilder.RenameTable(
                name: "Base_User1",
                newName: "Base_User");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Base_User",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Base_User",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 32,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifyBy",
                table: "Base_User",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 32,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Age",
                table: "Base_User",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddBy",
                table: "Base_User",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 32,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Base_User",
                table: "Base_User",
                column: "ID");
        }
    }
}
