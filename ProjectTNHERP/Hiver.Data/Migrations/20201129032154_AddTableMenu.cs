using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hiver.Data.Migrations
{
    public partial class AddTableMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentID = table.Column<int>(nullable: true),
                    MenuName = table.Column<string>(maxLength: 150, nullable: true),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    IconClass = table.Column<string>(maxLength: 50, nullable: true),
                    Url = table.Column<string>(maxLength: 200, nullable: true),
                    MenuOrder = table.Column<int>(nullable: false),
                    IsVisible = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuID);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"),
                column: "ConcurrencyStamp",
                value: "59a9bb67-63d1-4c16-8c01-19444235112f");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"),
                column: "ConcurrencyStamp",
                value: "94429baf-7266-4156-a268-bce3e3c7aefe");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"),
                column: "ConcurrencyStamp",
                value: "177bd326-022c-4122-b88e-241988bd95a2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"),
                column: "ConcurrencyStamp",
                value: "c810a9da-9122-48fe-9b0b-b48395dc3943");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "10503bf0-6278-490f-aa58-1dfc9feab94b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ba221777-5ccd-4f31-a160-c52cfe632c2e", "AQAAAAEAACcQAAAAEPKOgoTKL2qxY8Pla5aanrrBvAMytrWwWKJ8009/Pxnc9RUR6SzFtP4nP+NS9WTzMQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3c4c45b3-b175-4439-8692-21bb113b1d20", "AQAAAAEAACcQAAAAECWVXUxGyCWnojfc5hKZlT1zDXXjoz5sNTsnDTATwc6asy4yM5ZkaWE268eLeSBw8w==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ab16e7cb-494f-48f8-9cb3-896f3335ed6e", "AQAAAAEAACcQAAAAEITzp/zJVLmRNDtgh/iH8la2cLgS7J2DEcDs6MW4vKf9eKswdytAh9Svj3bI+1C5Rw==" });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuID", "Description", "IconClass", "IsVisible", "MenuName", "MenuOrder", "ParentID", "Url" },
                values: new object[,]
                {
                    { 1, null, null, true, "Trang Chính", 1, null, "/" },
                    { 2, null, null, true, "Kho", 1, null, "/" },
                    { 3, null, null, true, "Nguyên Liệu", 1, 2, "/" },
                    { 4, null, null, true, "Thành Phẩm", 1, 2, "/" },
                    { 5, null, null, true, "Kinh Doanh", 1, null, "/" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"),
                column: "ConcurrencyStamp",
                value: "fbb658d6-8eea-4e01-9379-f68e07114685");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"),
                column: "ConcurrencyStamp",
                value: "10ed008d-1c96-4c77-910d-06c2b107d849");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"),
                column: "ConcurrencyStamp",
                value: "6b84de06-6254-4c83-8297-6e90ec7ff96c");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"),
                column: "ConcurrencyStamp",
                value: "257912a8-511e-4c1a-bb15-8b66d2bcf132");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "798137e9-1f6c-4481-a014-a878f087075c");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ae7e2616-384e-4a3d-8955-a7b3a5cafa61", "AQAAAAEAACcQAAAAEApRPcoql+ZZZ+h5WvdknA5sC0RNpwf17TCInsWAaoSNWyM/nFgX4KDlOeuBNA8t+g==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "023dedd4-3f2f-4bb9-9d52-bf8965fa35b8", "AQAAAAEAACcQAAAAEChMh44s/vFPOi9aexEWsb3mfVdlGavmvHNHm4G33Z0JmSWv9ayDHkot6erpFdyuqw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "755a13a4-3eca-497b-bacf-85217bb0ed33", "AQAAAAEAACcQAAAAEGhc93cgRrMlUFBmsJVNOwsyZTricIYgnhkLdjdNv1myiIXY6zRBkV4du3xvqs9JOw==" });
        }
    }
}
