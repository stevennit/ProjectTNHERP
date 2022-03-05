using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hiver.Data.Migrations
{
    public partial class FixRole2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRoles",
                table: "AppRoles");

            migrationBuilder.AlterColumn<string>(
                name: "ActionName",
                table: "AppRoles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ControllerName",
                table: "AppRoles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRoles",
                table: "AppRoles",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"),
                column: "ConcurrencyStamp",
                value: "39e7ad45-b255-4e9b-8321-f4b5f7fda2b3");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"),
                column: "ConcurrencyStamp",
                value: "e5a5032d-4973-433f-aa13-c587f470b260");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"),
                column: "ConcurrencyStamp",
                value: "820c528e-14ab-4417-b834-47077d8be08c");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"),
                column: "ConcurrencyStamp",
                value: "d91bf3b9-80ae-4134-9300-83f74f700e1f");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "9fcb18b3-c0bc-4a45-bf28-7dc0e8782682");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c7950f4e-ea35-40b1-8249-2fefd7cdb8f1", "AQAAAAEAACcQAAAAEKdi13ZB5Vl9zbiLrpOwoYtUZlyo6nPKXpf3C3aCYf/6o/nm/Nz0T+v15MylmUmItQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aa3f3727-23c7-4dc6-9dee-2e0a05e25152", "AQAAAAEAACcQAAAAEE0pgFnvpunRLWBpIaUnH0py6AMvlb/57v7xdB+QiWLQT2SNw1pq+wUYZBCmAC4w4g==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c74a8258-1741-4e9d-b02e-589fc72a8bd0", "AQAAAAEAACcQAAAAEEcNg1pkrTW5CLYBaHqDLjSYCcQJxxnoLOxQMPz8tRrd1OiwaqmY+bqU5SbzGcvSPQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRoles",
                table: "AppRoles");

            migrationBuilder.AlterColumn<string>(
                name: "ControllerName",
                table: "AppRoles",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActionName",
                table: "AppRoles",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRoles",
                table: "AppRoles",
                columns: new[] { "ControllerName", "ActionName" });

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
    }
}
