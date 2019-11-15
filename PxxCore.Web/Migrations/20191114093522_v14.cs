using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PxxCore.Web.Migrations
{
    public partial class v14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Base_SysLog",
                columns: table => new
                {
                    SysLogId = table.Column<string>(nullable: false),
                    ObjectId = table.Column<string>(maxLength: 32, nullable: true),
                    LogType = table.Column<string>(maxLength: 2, nullable: true),
                    IPAddress = table.Column<string>(maxLength: 32, nullable: true),
                    IPAddressName = table.Column<string>(maxLength: 32, nullable: true),
                    CompanyId = table.Column<string>(maxLength: 32, nullable: true),
                    DepartmentId = table.Column<string>(maxLength: 32, nullable: true),
                    CreateDate = table.Column<DateTime>(maxLength: 32, nullable: true),
                    CreateUserId = table.Column<string>(maxLength: 32, nullable: true),
                    CreateUserName = table.Column<string>(maxLength: 32, nullable: true),
                    ModuleId = table.Column<string>(maxLength: 32, nullable: true),
                    Remark = table.Column<string>(maxLength: 32, nullable: true),
                    Status = table.Column<string>(maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Base_SysLog", x => x.SysLogId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Base_SysLog");
        }
    }
}
