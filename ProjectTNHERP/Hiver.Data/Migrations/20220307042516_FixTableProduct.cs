using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hiver.Data.Migrations
{
    public partial class FixTableProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ViewCount",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ViewCount",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

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
    }
}
