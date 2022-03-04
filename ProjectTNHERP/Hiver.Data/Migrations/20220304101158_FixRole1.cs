using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hiver.Data.Migrations
{
    public partial class FixRole1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AppRoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AppRoles",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumns: new[] { "ActionName", "ControllerName" },
                keyValues: new object[] { "admin", "Delete" },
                column: "ConcurrencyStamp",
                value: "1c586551-5c63-4fa6-9af6-69b3ae00e00f");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumns: new[] { "ActionName", "ControllerName" },
                keyValues: new object[] { "admin", "Register" },
                column: "ConcurrencyStamp",
                value: "6ec51bec-81fd-4ce0-8309-6838bf3932d8");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumns: new[] { "ActionName", "ControllerName" },
                keyValues: new object[] { "GetAllPaging", "Users" },
                column: "ConcurrencyStamp",
                value: "66c1d8dd-608a-400d-a568-8a1f0e6ce537");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumns: new[] { "ActionName", "ControllerName" },
                keyValues: new object[] { "GetById", "Users" },
                column: "ConcurrencyStamp",
                value: "ebabc8b3-7a6f-430f-8b29-57363bbf4de7");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumns: new[] { "ActionName", "ControllerName" },
                keyValues: new object[] { "Update", "Users" },
                column: "ConcurrencyStamp",
                value: "f4522014-0442-4141-b379-58fddd3472bf");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "084bc250-997e-4011-aa80-c8f8b9d13ae1", "AQAAAAEAACcQAAAAEM9oCKKTOkqrpHgtUktIp/rHqqF37D16qFxRrtVOD1uJW02j8GakpFOQWXU0Q4Pp2w==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e0656383-6e8d-4536-ad65-1850d0a1c8bf", "AQAAAAEAACcQAAAAEIFYpx9SPhLbZfviqEIAOX2YWf+zkeRbBrU0dhWlm9JB/jutA5FnB7FKBXSn8kRqcg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9f1837bb-6f54-4b25-84f6-10bc88ba2efa", "AQAAAAEAACcQAAAAEB4TnDA05U59PmVSJwGFyiSQA19cYcVZPOCAA5Jw1cyZzi3TKSQyodEA2wZ0U9IZnQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AppRoles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AppRoles",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumns: new[] { "ActionName", "ControllerName" },
                keyValues: new object[] { "admin", "Delete" },
                column: "ConcurrencyStamp",
                value: "4c822311-7e3a-4bfb-9084-e4c88a5e819b");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumns: new[] { "ActionName", "ControllerName" },
                keyValues: new object[] { "admin", "Register" },
                column: "ConcurrencyStamp",
                value: "b3e39fa9-e54e-4a4f-bec9-2aa4c7c10a1a");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumns: new[] { "ActionName", "ControllerName" },
                keyValues: new object[] { "GetAllPaging", "Users" },
                column: "ConcurrencyStamp",
                value: "0dd8cbc2-72c0-4cf7-bf99-12203b07888c");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumns: new[] { "ActionName", "ControllerName" },
                keyValues: new object[] { "GetById", "Users" },
                column: "ConcurrencyStamp",
                value: "169224ee-3522-4047-bbc4-483b38b42fad");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumns: new[] { "ActionName", "ControllerName" },
                keyValues: new object[] { "Update", "Users" },
                column: "ConcurrencyStamp",
                value: "6ac4da06-bf28-4cba-9fa1-06b4e0164674");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c75763b2-2df4-49ba-9786-dcdc82fa6feb", "AQAAAAEAACcQAAAAEDvqU+m0FxZPFcMDRL7ju2JTQApOvmaYvzuHAWpkMC3izgcRM32TiqtgFIndQfFICA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "62ac4177-98e0-4da6-a9f5-9765b2a30394", "AQAAAAEAACcQAAAAEKhGO/E5WzstVhDj4gdz6KFZRkbAQLfLrlc0PNeZ85UNPqHkeR7IJWwaEAJiCZ1uMg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "509c0b90-5e3f-42ff-b125-2c8e1caacce2", "AQAAAAEAACcQAAAAEHbR9QcgZu/ARrlpG/YPIY9KwieTaYqASBS3BTAYtUJdrkcu6KssoVOkRgfnmEKkUw==" });
        }
    }
}
