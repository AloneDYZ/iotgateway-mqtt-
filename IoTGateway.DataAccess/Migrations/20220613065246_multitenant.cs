using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IoTGateway.DataAccess.Migrations
{
    public partial class multitenant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FunctionPrivileges_FrameworkMenus_MenuItemId",
                table: "FunctionPrivileges");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropIndex(
                name: "IX_FunctionPrivileges_MenuItemId",
                table: "FunctionPrivileges");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "FrameworkGroups");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "FrameworkGroups");

            migrationBuilder.RenameColumn(
                name: "UpdateTime",
                table: "FrameworkGroups",
                newName: "ParentId");

            migrationBuilder.RenameColumn(
                name: "CreateTime",
                table: "FrameworkGroups",
                newName: "Manager");

            migrationBuilder.AddColumn<string>(
                name: "TenantCode",
                table: "FunctionPrivileges",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsValid",
                table: "FrameworkUsers",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "TenantCode",
                table: "FrameworkUserRoles",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantCode",
                table: "FrameworkUserGroups",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TenantAllowed",
                table: "FrameworkMenus",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantCode",
                table: "FileAttachments",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantCode",
                table: "DataPrivileges",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantCode",
                table: "ActionLogs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FrameworkTenants",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "TEXT", nullable: false),
                    TCode = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    TName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    TDb = table.Column<string>(type: "TEXT", nullable: true),
                    TDbType = table.Column<int>(type: "INTEGER", nullable: true),
                    DbContext = table.Column<string>(type: "TEXT", nullable: true),
                    TDomain = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    TenantCode = table.Column<string>(type: "TEXT", nullable: true),
                    EnableSub = table.Column<bool>(type: "INTEGER", nullable: false),
                    Enabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreateBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdateBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrameworkTenants", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FrameworkGroups_ParentId",
                table: "FrameworkGroups",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_FrameworkGroups_FrameworkGroups_ParentId",
                table: "FrameworkGroups",
                column: "ParentId",
                principalTable: "FrameworkGroups",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FrameworkGroups_FrameworkGroups_ParentId",
                table: "FrameworkGroups");

            migrationBuilder.DropTable(
                name: "FrameworkTenants");

            migrationBuilder.DropIndex(
                name: "IX_FrameworkGroups_ParentId",
                table: "FrameworkGroups");

            migrationBuilder.DropColumn(
                name: "TenantCode",
                table: "FunctionPrivileges");

            migrationBuilder.DropColumn(
                name: "TenantCode",
                table: "FrameworkUserRoles");

            migrationBuilder.DropColumn(
                name: "TenantCode",
                table: "FrameworkUserGroups");

            migrationBuilder.DropColumn(
                name: "TenantAllowed",
                table: "FrameworkMenus");

            migrationBuilder.DropColumn(
                name: "TenantCode",
                table: "FileAttachments");

            migrationBuilder.DropColumn(
                name: "TenantCode",
                table: "DataPrivileges");

            migrationBuilder.DropColumn(
                name: "TenantCode",
                table: "ActionLogs");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "FrameworkGroups",
                newName: "UpdateTime");

            migrationBuilder.RenameColumn(
                name: "Manager",
                table: "FrameworkGroups",
                newName: "CreateTime");

            migrationBuilder.AlterColumn<bool>(
                name: "IsValid",
                table: "FrameworkUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "FrameworkGroups",
                type: "TEXT",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "FrameworkGroups",
                type: "TEXT",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Expiration = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RefreshToken = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Type = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    UserCode = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FunctionPrivileges_MenuItemId",
                table: "FunctionPrivileges",
                column: "MenuItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_FunctionPrivileges_FrameworkMenus_MenuItemId",
                table: "FunctionPrivileges",
                column: "MenuItemId",
                principalTable: "FrameworkMenus",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
