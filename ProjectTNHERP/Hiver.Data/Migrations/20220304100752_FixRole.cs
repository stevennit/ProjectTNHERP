using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hiver.Data.Migrations
{
    public partial class FixRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRoles",
                table: "AppRoles");

            migrationBuilder.DropColumn(
                name: "ImageMore",
                table: "StockCategories");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRoles",
                table: "AppRoles");

            migrationBuilder.AddColumn<string>(
                name: "ImageMore",
                table: "StockCategories",
                type: "xml",
                nullable: true);

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
                value: "35cbe7e5-4a1f-42d6-9b9d-40e67d7370ab");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"),
                column: "ConcurrencyStamp",
                value: "168b7034-c199-4867-8501-4ce475062bd1");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"),
                column: "ConcurrencyStamp",
                value: "1ac3251a-9798-4cae-ae00-c229ed6782fe");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"),
                column: "ConcurrencyStamp",
                value: "6996017e-75a3-4320-9401-cebb8cc882d5");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "e330990f-757c-45cb-8756-676128370bd3");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eb404d4d-9402-40f2-9d97-65b5d57f845f", "AQAAAAEAACcQAAAAEGouHXTKoX6dqYoh8bcyjDA59rjt1lbLVBKl9z4bwLyMtnvdWZPnlFxDQlqzXehatw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "faa81d5e-ff94-4864-b4a4-3144938a8b1b", "AQAAAAEAACcQAAAAEHivmYWRW/ZrrKTZbSQ1RvWEl03kXvtPzQFveEejHU3DqMCRxAyjgKdrqJ3wIUzUDA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a60426cf-a006-4226-a77c-880c33013ca2", "AQAAAAEAACcQAAAAEGrxUMZcRLSXxUmiaBauMIxW8F1UBCVeZuhlJjoJQbPK5s+rZAA9y7sBj4CzfBVVVw==" });
        }
    }
}
