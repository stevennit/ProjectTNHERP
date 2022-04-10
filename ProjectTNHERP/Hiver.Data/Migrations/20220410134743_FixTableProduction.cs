using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hiver.Data.Migrations
{
    public partial class FixTableProduction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Productions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "Productions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Productions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"),
                column: "ConcurrencyStamp",
                value: "74d7bcdb-616e-4e8b-ba45-df25a6c570a4");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"),
                column: "ConcurrencyStamp",
                value: "88370efa-f115-4f1a-b3c1-ab30cd3def63");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"),
                column: "ConcurrencyStamp",
                value: "6a3ffb00-9992-4f91-99d9-a8fddacd0b79");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"),
                column: "ConcurrencyStamp",
                value: "6b9c5d14-73ff-46ae-87cc-16c7e242b90a");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "9050c59a-5cb7-44b8-85c3-a34e3163f413");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "26ca39a4-69b0-45de-b6fa-c99ebc8638c5", "AQAAAAEAACcQAAAAEH9zcHvFlIgfi7bGD392O5VtiBwHYK2VXAWczEgCaYUfleaw40lUDGJtOdb5hWqMPA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6570455f-e4ad-46aa-88b7-d37340fc0920", "AQAAAAEAACcQAAAAEKJjvn0S1qjcdrhi7D1GOz9KvPKuGSIQoLgwQKcqu5jJClmtA4SqkNzJKP3/xQCyJg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7554241d-bc3f-4077-913f-f635c4cad3ea", "AQAAAAEAACcQAAAAEDVn0Nzl2+DIkZHv4chDCjBLsBfaZoff1MCV6YjFrYM1YVa4VfRob9CVq9U2M5IbuQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Productions");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Productions");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Productions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"),
                column: "ConcurrencyStamp",
                value: "b4f1fe4e-67ba-4a2e-b39a-41ec5bd3bcf8");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"),
                column: "ConcurrencyStamp",
                value: "af2bb949-5764-4485-8c3d-ccc356911027");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"),
                column: "ConcurrencyStamp",
                value: "bca24597-39f5-4e3e-a8fd-a37150882484");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"),
                column: "ConcurrencyStamp",
                value: "91247607-8c6e-4644-82f1-3ee95c8426ca");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "e01349d9-f2cf-418d-b607-76fafcae7576");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3b14ad16-b802-401e-a15c-1743fbba07c9", "AQAAAAEAACcQAAAAED7asR2DKi30bHQnZaPuw1nZqplX4yoNERu8rjsoudDtlYWSivw2M8jzBD1GyaSa9Q==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "470a40d0-2bc9-481a-b809-d3574694cee4", "AQAAAAEAACcQAAAAEDIsKPcZ1th3Nzkyhw7ju0GSv8WLiPBuyefq20AVM4K45LVEYWpyWTZX6OWYuiRVww==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "38105f31-126a-4cf1-a35b-0a42339a23e6", "AQAAAAEAACcQAAAAEJOIrEV9Y5yGDWAp+RdPmUtNzMZ29308PBu+aK0cziBZInWRa9C9kcrMKX/M4ko2EA==" });
        }
    }
}
