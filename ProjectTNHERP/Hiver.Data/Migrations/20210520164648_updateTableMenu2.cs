using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hiver.Data.Migrations
{
    public partial class updateTableMenu2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IconUpdate",
                table: "Menus",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "IconNumber",
                table: "Menus",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"),
                column: "ConcurrencyStamp",
                value: "a0198817-1e77-42b2-9539-d636155d1778");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"),
                column: "ConcurrencyStamp",
                value: "b6071b80-68dd-4859-92dd-4640c0859934");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"),
                column: "ConcurrencyStamp",
                value: "765fd726-dc18-4bcd-850a-f9cd8f0aa92a");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"),
                column: "ConcurrencyStamp",
                value: "73663c28-1d2f-4569-85ea-36be73e497f7");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "c5f4fbf7-8ecc-4616-9753-a95e41009c6b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ecb35da9-bd36-48f1-9719-e922b2fdcef5", "AQAAAAEAACcQAAAAEKjtp2OGVkReVRcEerO2JKvSEayK41knIVmxwZkG5ItPTCJ2Q6dGy78OxAtI2U1ekA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "00b2f43a-1d90-4c48-9b0b-3f0477742824", "AQAAAAEAACcQAAAAEHGKzeiQUXuPl0m9CbG4wUB/Lnd0HAFpG2EyQjf+KDScyyNFIREwbpUvETzJl1lRTw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f8a0852c-d83f-499e-ba11-7102b561311a", "AQAAAAEAACcQAAAAEPdJIslgJlNlnXUxjwIQnLsaU4Y+NqfeJiKapj6wciJbVzrZjBvl99qkAzJ1gh7L1A==" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                columns: new[] { "IconNumber", "IconUpdate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                columns: new[] { "IconNumber", "IconUpdate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                columns: new[] { "IconNumber", "IconUpdate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                columns: new[] { "IconNumber", "IconUpdate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                columns: new[] { "IconNumber", "IconUpdate" },
                values: new object[] { null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IconUpdate",
                table: "Menus",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IconNumber",
                table: "Menus",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"),
                column: "ConcurrencyStamp",
                value: "d9da422b-193e-4786-98ea-25dba3bdc363");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"),
                column: "ConcurrencyStamp",
                value: "c460ef38-f5de-491e-a013-717ad998bdad");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"),
                column: "ConcurrencyStamp",
                value: "f242ea13-803d-4159-b481-9b67dfdfe59b");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"),
                column: "ConcurrencyStamp",
                value: "f0b3dea2-4ae7-49fe-bef5-695a13902842");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "f73c8a14-40cd-43fe-9f29-5899908b00d4");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b130c516-4675-4f91-93ce-9dce751a8963", "AQAAAAEAACcQAAAAEAIG4GHtngU5s+0xPI8mNARTFvFfPtfshXcp1sMbR9ra32+n5+856x/BOG5sEPQ9Mw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "febc414d-b1c7-4dfb-86f2-c68f78107daa", "AQAAAAEAACcQAAAAEG8m1EUgtXSAijccgRWRhFGL7pjoLdTwy+nT9fFagd8CQ02h4/1j569CgLwUjY7jdg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cffa6e55-fae2-4c0d-8c79-d76100398f86", "AQAAAAEAACcQAAAAEPne6kRGKhjADnF/PquEdCcVlpK6Usg6AUMXdKVQH7knD0/XKdK6F+iv5uY0uJ7aWQ==" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                columns: new[] { "IconNumber", "IconUpdate" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                columns: new[] { "IconNumber", "IconUpdate" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                columns: new[] { "IconNumber", "IconUpdate" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                columns: new[] { "IconNumber", "IconUpdate" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                columns: new[] { "IconNumber", "IconUpdate" },
                values: new object[] { 0, 0 });
        }
    }
}
