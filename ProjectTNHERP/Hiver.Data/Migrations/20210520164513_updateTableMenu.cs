using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hiver.Data.Migrations
{
    public partial class updateTableMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IconNumber",
                table: "Menus",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IconUpdate",
                table: "Menus",
                nullable: false,
                defaultValue: 0);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconNumber",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "IconUpdate",
                table: "Menus");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"),
                column: "ConcurrencyStamp",
                value: "ca41d082-e85f-4aaa-827a-4cb75de35b62");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"),
                column: "ConcurrencyStamp",
                value: "a11aeada-f23b-4e50-b22b-785d2f84ba0e");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"),
                column: "ConcurrencyStamp",
                value: "c16a3082-7de0-46a0-8742-44ac2ccb5720");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"),
                column: "ConcurrencyStamp",
                value: "7a091f7f-84b9-4774-a95f-f5c24ec1bac0");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "0149f1bf-3402-49bd-867e-10bfa2f3c79f");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fcf15d14-0317-4213-829d-79d2fa09c1d9", "AQAAAAEAACcQAAAAEMHwYqtyZn3v4+ESJX5Xk0CTOey3qk3tkUpmx7CHrrYmgGpC2AlFqa+mcLyC4cRNaA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dbf34965-4a03-4237-bd36-a619b2754e5e", "AQAAAAEAACcQAAAAEDhVBaGAyc8mX96cfX9DGfn5HRjrc6TMIqzzGbTmb5G2KxfF1Bl9Vs8HzhAtBQYXUw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "799387cc-2581-464e-b22f-87196dc0a98b", "AQAAAAEAACcQAAAAEEPlLXBSqi+zlQETwSOlB+gnMXlReCFslh2c+vd9jzsowCioJNSX3oU9itTS824KWg==" });
        }
    }
}
