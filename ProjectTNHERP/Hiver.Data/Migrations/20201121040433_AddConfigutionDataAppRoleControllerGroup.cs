using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hiver.Data.Migrations
{
    public partial class AddConfigutionDataAppRoleControllerGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRoleControllerGroup",
                table: "AppRoleControllerGroup");

            migrationBuilder.RenameTable(
                name: "AppRoleControllerGroup",
                newName: "AppRoleControllerGroups");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRoleControllerGroups",
                table: "AppRoleControllerGroups",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"),
                column: "ConcurrencyStamp",
                value: "9f47e40e-9847-4ecb-95fa-d7112923d2dc");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"),
                column: "ConcurrencyStamp",
                value: "57ab6088-20a1-4302-829e-734482558e2b");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"),
                column: "ConcurrencyStamp",
                value: "5e141fe4-295d-4347-b18d-d6a15662caab");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"),
                column: "ConcurrencyStamp",
                value: "4dabc972-1d5e-4619-ab2c-7a2dce2251a9");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "651c9c87-1f07-462c-9478-36b4d6f67b2f");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "09f5af09-5ec8-4304-8aa2-5b8fac498cec", "AQAAAAEAACcQAAAAEDX5sjy5roghVUlb7hXK9SOhbdxm1xSI/uApgjWsTvymnOSMSvp9nJHAcWizxIuykg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cd5073f7-8e7b-46ea-9cca-ef89af94c5f1", "AQAAAAEAACcQAAAAEJwtLl8Tt1Yx7l4NKC1+TtweuKKIfpN60ozRkbCZIO1OsjnUS2mIkMyHHMM26X18PQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7dc47abc-ea3e-4ff2-b480-824cab2eae52", "AQAAAAEAACcQAAAAEJNAR2ft4ElYI+oVFcDxKEW9uif2F91ssvF5fbjdWpZBoki8nh0Sam6F4gv47PT/VA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRoleControllerGroups",
                table: "AppRoleControllerGroups");

            migrationBuilder.RenameTable(
                name: "AppRoleControllerGroups",
                newName: "AppRoleControllerGroup");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRoleControllerGroup",
                table: "AppRoleControllerGroup",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"),
                column: "ConcurrencyStamp",
                value: "6f161636-ee12-4639-a90b-58224a5f69bf");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"),
                column: "ConcurrencyStamp",
                value: "d947d4ff-ce24-4b3f-bfbd-78c09aa642e4");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"),
                column: "ConcurrencyStamp",
                value: "c8c4d7a8-125b-4c6e-8661-a146a9e8d352");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"),
                column: "ConcurrencyStamp",
                value: "f1908745-a5ae-4189-92c3-4a3ade5d1918");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "a8118ade-f9e6-4747-8519-e1d03244694f");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b740119b-65dc-4348-8994-e9a2371a0787", "AQAAAAEAACcQAAAAELE17/+dFlvBDHSj5lsjvD71OfOSBMz9XJkciEhGQaDc3/oUUuEHUb5+C4gqHOX5XQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "41cb2951-4f67-4dd3-af8b-04d58968a24e", "AQAAAAEAACcQAAAAEFzpsLXVLCOe7xHWFO2aZYyLRGWR3UQ4bu5c5v9qi3NZzlzJFk841USm3g67ZE9ITA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "154a0c4c-f954-47d9-a9b2-db904d62b811", "AQAAAAEAACcQAAAAEG0avp7TI7Mee7TFwsRlPjGlrDWO+sgTJROX51iDXytWGxzQ2cW+ncU8iOC4Vd/xVg==" });
        }
    }
}
