using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hiver.Data.Migrations
{
    public partial class updatedatabaseMenu3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MenuOrder",
                table: "Menus");

            migrationBuilder.AddColumn<int>(
                name: "MenuVisible",
                table: "Menus",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"),
                column: "ConcurrencyStamp",
                value: "d0e549f8-19b3-4daa-9e58-40ef36ad5ab9");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"),
                column: "ConcurrencyStamp",
                value: "4525e19d-e786-4901-bd77-4e017e8bcb9f");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"),
                column: "ConcurrencyStamp",
                value: "48b9b00c-d609-49cb-99f8-b8a4b6faa767");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"),
                column: "ConcurrencyStamp",
                value: "9c4aa21f-0d5b-42ad-96c4-0a9ecabd2844");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "569c36a4-4164-4412-a6d2-4934e6694c9d");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f181e4ac-83e4-4281-919a-dd84f601c89b", "AQAAAAEAACcQAAAAEOiZMqS/dZ4pTfaGgtGSArflaT7ipn7HV9Gi9T59+2KtuzKMtcAnd5SmHYmLzV+TzA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8a0579c6-89e5-468d-9b58-8e8d82006b67", "AQAAAAEAACcQAAAAEK41Tpkt+wFBZp3IdAM9UJzFb5qQa6U5aXCj9FnnZbP9Y3t6wEalDZEtds++3nowTw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c4fdeaae-be89-4706-8f6f-f14db1420ad6", "AQAAAAEAACcQAAAAEPDFfkmFCcl+7aK//guZjGsU8TtEWBkiDiXPYnhaydDEDOukfGvne7poWs33AotunQ==" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "MenuVisible",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "MenuVisible",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "MenuVisible",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "MenuVisible",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "MenuVisible",
                value: 5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MenuVisible",
                table: "Menus");

            migrationBuilder.AddColumn<int>(
                name: "MenuOrder",
                table: "Menus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"),
                column: "ConcurrencyStamp",
                value: "9a69b57a-6cd1-4370-9aaa-33c445fda7d4");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"),
                column: "ConcurrencyStamp",
                value: "c37e3fb7-bac4-437c-8b6e-2495cab66e13");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"),
                column: "ConcurrencyStamp",
                value: "aad3f04c-6cfe-44da-a327-4eba066e4ef2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"),
                column: "ConcurrencyStamp",
                value: "ea6cf8b4-239c-4a53-a3a9-94dd87398366");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "9780539e-00a4-43c0-aa2b-c158f298ede4");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2608bf32-7989-411b-ad42-d231db1b6391", "AQAAAAEAACcQAAAAEOLFEtOiMjIONQuGLUxIIcaiKjNnAHJv5FbvlAFNoZJVgT8zUeoJDo2gqsLEGl9Ceg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1696fcde-0cfc-4547-be00-77d0fcb3007a", "AQAAAAEAACcQAAAAEGGPWnx3UiMAjblQPZJS9mx+1dGBlshSISx2ymIfX+Nh67sV9tVLn9pGLhCRiL6zLQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fa1079b1-9e7d-4ea8-88f4-332c984631c1", "AQAAAAEAACcQAAAAEIbiVMa66g/dPcYtKsEnVerZt8R2t3mFEZLOmxB35cj74RJ3qldForXe4SrB8CHvjg==" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "MenuOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "MenuOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "MenuOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "MenuOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "MenuOrder",
                value: 1);
        }
    }
}
