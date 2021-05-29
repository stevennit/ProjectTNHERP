using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hiver.Data.Migrations
{
    public partial class updateTableMenu4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MenuOrder",
                table: "Menus",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"),
                column: "ConcurrencyStamp",
                value: "caa68d07-03e1-441e-97f7-dbddd6917a2e");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"),
                column: "ConcurrencyStamp",
                value: "288ffdd3-03e0-49f8-969f-e2f64f8b927a");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"),
                column: "ConcurrencyStamp",
                value: "43a8cfea-6cde-467e-93a4-618748f2a2f2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"),
                column: "ConcurrencyStamp",
                value: "e02959d9-8640-4c5d-b261-7bf33a1b2ac5");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "de973332-8321-4f35-b54a-d394177d676b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c55e0627-b298-41bd-bf2d-34657e953ab6", "AQAAAAEAACcQAAAAEAoDQz1IoNz/Lpqdv8dPZOIXwcGxd0P3MmxGhMKyQj4oaSpVygG26yY9qSev9Ne/3w==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c1fbec04-165b-400e-a4ba-e0d7186cb49b", "AQAAAAEAACcQAAAAEJcjRw++2PVTS303FVzSjELfEquWQIlPIuz9sYJFTdptlsqKODKtbJHyE0Cer7ABzA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "840ba850-d372-4d12-8777-11f1e1e7a51e", "AQAAAAEAACcQAAAAEJcz6EUQFoc7NWk/k1PjvLQkbpZpionU9/G9bWdcXtnWXp9EJt+S0FkQdbBVlW2E0Q==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MenuOrder",
                table: "Menus");

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
        }
    }
}
