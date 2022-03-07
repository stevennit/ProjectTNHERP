using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hiver.Data.Migrations
{
    public partial class FixTableProduct1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ViewCount",
                table: "Products",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"),
                column: "ConcurrencyStamp",
                value: "4c306abb-ed37-40a5-929f-9f1f4abe5712");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"),
                column: "ConcurrencyStamp",
                value: "9ed996b4-5156-49f8-9788-fccab2bfc1aa");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"),
                column: "ConcurrencyStamp",
                value: "99abe4be-1461-4a09-bc37-b7c07bc56b32");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"),
                column: "ConcurrencyStamp",
                value: "006297a5-b430-4b19-a1fb-3c22e9a83aa7");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "15f7e91d-d3ae-4eb0-b41c-ee21e5b63425");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c0cf2930-35dc-43e8-b4c8-cad591cd2602", "AQAAAAEAACcQAAAAEBehYT3P5d4ptO6zwIJKr5dPUakbeaVZMFrWSt38DzGCqpIgNYWK8CJrDl8Q/VqsfA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "560b5402-1b76-4dea-95cd-bd54482bbeed", "AQAAAAEAACcQAAAAEOoguSr5iRyJzi48W6Hb27YYdiaMgurLf3xhrN4yzu8b8amukhlNdn0FyTqHJmeX4Q==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8eff4296-b468-42d5-b612-4839d6573f2e", "AQAAAAEAACcQAAAAEDXYm9PHUHvvoSwDuNFjywFqEcOK5RIGnsj8qqLfvxLjDlV+dVTPi9kgf1Hxq6kCYQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ViewCount",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"),
                column: "ConcurrencyStamp",
                value: "25a439bc-732b-4b1e-b264-c30a10083de9");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"),
                column: "ConcurrencyStamp",
                value: "609731ee-2d95-4a8a-b395-0ceaf503651e");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"),
                column: "ConcurrencyStamp",
                value: "61473d60-faff-441d-bb11-b0bdafa606a0");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"),
                column: "ConcurrencyStamp",
                value: "f5a2d162-af0d-42fb-8f07-856f750464a6");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "62066576-6f87-4b88-9fcd-616eaeb4ad32");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "718de112-4313-4c98-9b56-169ad82745ac", "AQAAAAEAACcQAAAAECNlKuv8FYrVHRH4jSM1tNkmVgBZul08SH1TtSS3ptIPomtWrDtg6jkZLRaLXnVCIQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "194672bc-d046-4282-b440-b7594f1aa904", "AQAAAAEAACcQAAAAEHOe4aoC5LTa6vWu9fUxclGoMO8UwnNg4tPsM0Sr7ObRZ7T/+r8Rvau0sdsWaYbIVQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "188220be-2799-43c4-addc-eedf11b2510d", "AQAAAAEAACcQAAAAECMg4RH6M8mrnMWgTv4xv7PMekVFyzVng1H3uNT/loZ1ffYqgeA7DnjTJ6W8me5CoQ==" });
        }
    }
}
