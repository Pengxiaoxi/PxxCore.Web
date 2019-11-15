using Microsoft.EntityFrameworkCore.Migrations;

namespace PxxCore.Web.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Base_User1",
                table: "Base_User1");

            migrationBuilder.RenameTable(
                name: "Base_User1",
                newName: "Base_User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Base_User",
                table: "Base_User",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Base_User",
                table: "Base_User");

            migrationBuilder.RenameTable(
                name: "Base_User",
                newName: "Base_User1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Base_User1",
                table: "Base_User1",
                column: "ID");
        }
    }
}
