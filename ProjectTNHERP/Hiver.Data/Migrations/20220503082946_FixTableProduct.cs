using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hiver.Data.Migrations
{
    public partial class FixTableProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Symbol",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "Symbol",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Stocks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QtyNG",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QtyProduction",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"),
                column: "ConcurrencyStamp",
                value: "7e6064a8-9228-4015-9c84-880ad5dce834");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"),
                column: "ConcurrencyStamp",
                value: "45973ef5-3152-423f-b293-dfb066fec4e3");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"),
                column: "ConcurrencyStamp",
                value: "631a7b1e-604a-451c-996c-54704d21090a");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"),
                column: "ConcurrencyStamp",
                value: "13796424-7ced-44c8-ae14-15bf1eeb379c");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "c9266372-de8f-474a-a447-eef7234f9aaa");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7ced83df-5c13-40f7-a7ef-2e6f50f2905d", "AQAAAAEAACcQAAAAEH+XiKz1Np1GbDkdMY/fU5zUK7b9oLMWfEhdZT/82FdaRlODCAsLHvAjGGlCrfy9vw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2dd3ea44-2aa1-403d-ad3a-02aa3598ee35", "AQAAAAEAACcQAAAAEAmqNprYYAXkjnXLAaiGJpEzXabL6UJ1giTipl7Ya/MkV63nazIfZEBeFIdsWaukQQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e30ca8bf-b782-41a1-844e-32006b532705", "AQAAAAEAACcQAAAAEBhmFOOVouorQwThzfkwTxzDw4TV2qiAIBDydQ5unz/4qMsnZ3NqQPUuqj7BxuqynQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "QtyNG",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "QtyProduction",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Stocks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Symbol",
                table: "Stocks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Symbol",
                table: "Products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"),
                column: "ConcurrencyStamp",
                value: "430ef8b7-d784-45e1-b94b-bb49d9e2692f");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"),
                column: "ConcurrencyStamp",
                value: "94dc91a1-2be0-4203-b747-d4d192dda9ec");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"),
                column: "ConcurrencyStamp",
                value: "e96447d7-14ec-4c07-8a80-79b0ca9750e6");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"),
                column: "ConcurrencyStamp",
                value: "382e4e5b-c43a-44db-9d94-61231cb5b09d");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "37869906-1e04-4503-b21a-004a66f856fc");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a0b23c14-5a9d-43d2-86e5-ac120cb0a3ed", "AQAAAAEAACcQAAAAEAR12vE6kWS4scggK9G8/p7snWrajuwz6pHXh6l17KmMXQFwMg3EqaPS6ZmMNrOYXg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1aa804ce-092b-46ba-8dce-0f6c0f8ac9af", "AQAAAAEAACcQAAAAEJe0dz38sB8VRDUgOqZ8JK597wU1hGv4UTFWQ3xnPEFlFEwr+VdSqBlU1oWB9rAZJA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3242cfaf-e5ca-4033-ba88-e50fa39e4ace", "AQAAAAEAACcQAAAAEJhTZExfMPMBgTN/D2Z7YA7PooIfv1/COVhU5pPSEiRTkAqBASDcdz23Vfx9f9X3gw==" });
        }
    }
}
