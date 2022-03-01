using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hiver.Data.Migrations
{
    public partial class FixTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Message",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"),
                column: "ConcurrencyStamp",
                value: "7dfc557c-ad34-489a-9cec-b456e2356f60");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"),
                column: "ConcurrencyStamp",
                value: "900ede45-0b24-4cf5-b73f-501dd14f9eb5");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"),
                column: "ConcurrencyStamp",
                value: "32efda2b-bcae-49c2-9159-b07b6020da9d");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"),
                column: "ConcurrencyStamp",
                value: "6287b393-6f60-423a-b017-b4473b1e389b");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "8ede799e-5e89-4ffd-bfcb-342799271d70");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "51a4b9ef-278a-4f11-978f-3f572dd1b510", "AQAAAAEAACcQAAAAEObDhsiZDhnHaym+F6WxNXhZDd9vJTPcYisgxtBStHpYttUEv8tB9KDlo8tiBBOiBg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fd86829c-a36c-42ea-81a2-a0f99a2997eb", "AQAAAAEAACcQAAAAEH7PDKF7dAika/nQ6ei29KoAGhdo7B4waXg2Ww6bLF2ns2eJFqqSEBD7jmc7Dzdw4A==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5650d56c-143e-4a30-bc4b-50bc3b8f9be6", "AQAAAAEAACcQAAAAEMqN6NXK2FhCjhCk07de9ZDuDF9SVFhglpbyZH5u1bOlN3csE9Uc6tCD6Kbs/VwqvA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "Customers",
                type: "xml",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"),
                column: "ConcurrencyStamp",
                value: "2a0857ba-a041-4bd9-b754-4b715fcfe060");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"),
                column: "ConcurrencyStamp",
                value: "3d97317d-9128-470c-b810-9ec7a646dc00");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"),
                column: "ConcurrencyStamp",
                value: "cd805027-9248-4a12-8928-99f978629fbb");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"),
                column: "ConcurrencyStamp",
                value: "b6e475a1-f563-4931-8e9b-be5acdff62b2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "4ec5adb3-5aeb-4b78-b066-e8f013683dd2");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "16284ffe-70c1-453f-b758-f9c3f21cb0f0", "AQAAAAEAACcQAAAAEDnD1YLdmWbvuFA1LY+Z7hx282rHANJ/y7dglZdDfe9peNDPBnREF5hlYanl1iZqyA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d9403524-4dec-4ba8-bc03-50538141bef3", "AQAAAAEAACcQAAAAEDz27fFR/Ir4m6unChFLa6iJLaO4DgowodCdOBvnatp0rvOqI9o7W8Wjbj7xcMfYDQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eac548e8-bc36-429a-b05a-3ed794be509c", "AQAAAAEAACcQAAAAEHlMHOdrwbZxoceSsJcS2tkrwNmFmfLnf5P2NCgB5h+wa4Pf1qbdIm02TrsTzrBifQ==" });
        }
    }
}
