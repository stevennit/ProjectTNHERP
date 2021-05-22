using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hiver.Data.Migrations
{
    public partial class TableMenu_removeIConUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconUpdate",
                table: "Menus");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IconUpdate",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: true);

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
        }
    }
}
