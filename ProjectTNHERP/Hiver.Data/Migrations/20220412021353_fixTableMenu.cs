using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hiver.Data.Migrations
{
    public partial class fixTableMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"),
                column: "ConcurrencyStamp",
                value: "bbacc70c-e694-4d7d-ac27-2e934f6d5115");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"),
                column: "ConcurrencyStamp",
                value: "d7f3fc56-ed14-45e9-b00f-be6006f83cd0");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"),
                column: "ConcurrencyStamp",
                value: "bbb99696-a698-4bd3-9bcb-b1e96f55376d");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"),
                column: "ConcurrencyStamp",
                value: "8cd9c059-29f9-43b5-b283-6480833b9ebf");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "afb5dfcc-a434-430b-a12d-942b1f3c0569");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "430bab2c-7eaf-46b1-9b50-24e0723d4956", "AQAAAAEAACcQAAAAEFHm1S/soDJNQE57doJ5w5aLLFEByKxLfT81apDfBhsLbK0lnQ+78oczn/vWVbdKAA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ca58163b-7a9e-4b13-9432-17488a478979", "AQAAAAEAACcQAAAAEEHLQL6UERxhrbKqzwZRA31JpV60w69IyJGkiNblH0MpbyOOEWF4ZTkOhaAH7QgBrw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dd489eb4-34ee-44cd-9c9e-b5ba4c640869", "AQAAAAEAACcQAAAAEK/yN39kQyq3v7O5Ry1H0N0Un331hLAho3VL4a8tXcs3V7NDiu/SVOFt2msOUOnD7w==" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "Url",
                value: "/Store");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "Url",
                value: "/Product");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "Url",
                value: "/Sale");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"),
                column: "ConcurrencyStamp",
                value: "61116c40-2ce0-4917-add5-f216a9509072");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"),
                column: "ConcurrencyStamp",
                value: "72254431-7f38-457f-947f-910bd23f6748");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"),
                column: "ConcurrencyStamp",
                value: "a71a2b0f-da0a-428a-86a7-003de39d4ae3");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"),
                column: "ConcurrencyStamp",
                value: "08122348-6990-4ccc-96c4-3e2ef93d6ef6");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "32f740db-0503-415c-aa67-301ed3146c0f");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5269e26a-fbcc-4473-aa4a-68ba3ab05a1c", "AQAAAAEAACcQAAAAEE4Nz3kYconYLdtloD4QO+SyPuiCU3xjsERg9pqRk4cR1iLOrVr/6dlKGnKGqKVT+A==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8f61da11-9887-49d3-a50d-2acbcc4ab5c2", "AQAAAAEAACcQAAAAEPeIEtOXy5VBzGQqvThAa81VBhFNe35Md1/MFhwtY4z15j7ITGbKaWV8FH38A35iTA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "57a1b735-6fd4-464e-8440-07b49a391732", "AQAAAAEAACcQAAAAEEEFK6BNGCGR7gSThTwQ18wncR0pRd645magNK8mEKQPU1TACsu6xSaisHGnjhu1vQ==" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "Url",
                value: "/");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "Url",
                value: "/");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "Url",
                value: "/");
        }
    }
}
