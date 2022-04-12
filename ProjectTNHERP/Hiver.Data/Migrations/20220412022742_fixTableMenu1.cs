using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hiver.Data.Migrations
{
    public partial class fixTableMenu1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"),
                column: "ConcurrencyStamp",
                value: "8f7df327-02db-4cd0-b664-26a3770b1d58");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"),
                column: "ConcurrencyStamp",
                value: "3e1cb968-f534-4daf-8d78-3a52d55628ae");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"),
                column: "ConcurrencyStamp",
                value: "5fe29536-0363-4b66-89f4-fd118d3c06dd");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"),
                column: "ConcurrencyStamp",
                value: "7d9e996f-5dd7-482a-b376-90758d671a36");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "d4992de3-2243-4d36-8252-eaf6e1ce2e8b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fe7cae9b-016e-4d16-82b6-3e16ca274844", "AQAAAAEAACcQAAAAEFoSlpCWCcs/HMoyWArHuV0bEM9zFlG0Uj/c8WVKp5lVUVUtAU5y8vbUq9j2z5UAIQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "52569db3-7a74-4fc6-847e-0d48c0a98d4b", "AQAAAAEAACcQAAAAEKZozGu5hMX4gEDYysvlFYPx4Cyb+Kiz3fj3maaU6wg1olN2Uc9BNdEO1ZlLFrBX2A==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3d0a12e0-748d-4854-b070-e43b2289c644", "AQAAAAEAACcQAAAAENYEW4fBaDCPuJ/iTcJjb0M3iqWDauu085FmmCriT5EacjpsQfx0xNUUAJ6i6IcC5g==" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "MenuVisible",
                value: 4);

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuID", "Description", "IconClass", "IconNumber", "IsVisible", "MenuName", "MenuOrder", "MenuVisible", "ParentID", "Url" },
                values: new object[,]
                {
                    { 6, null, null, null, true, "Khách Hàng", null, 5, -1, "/Customer" },
                    { 7, null, null, null, true, "Nhà Cung Cấp", null, 4, -1, "/Supplier" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CreateBy", "CreateDate", "Description", "Image", "ModifyBy", "ModifyDate", "Name" },
                values: new object[,]
                {
                    { new Guid("f9cb0cac-5219-42f7-8182-a7b01d122c4b"), null, null, null, null, null, null, "Tem Loại 1" },
                    { new Guid("fee35eb7-a414-4ec1-8ce0-7d11fc10ff3d"), null, null, null, null, null, null, "Tem Loại 2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("f9cb0cac-5219-42f7-8182-a7b01d122c4b"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("fee35eb7-a414-4ec1-8ce0-7d11fc10ff3d"));

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
                keyValue: 5,
                column: "MenuVisible",
                value: 5);
        }
    }
}
