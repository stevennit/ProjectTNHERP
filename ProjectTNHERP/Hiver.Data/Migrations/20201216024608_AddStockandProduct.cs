using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hiver.Data.Migrations
{
    public partial class AddStockandProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Symbol",
                table: "Stocks",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Symbol",
                table: "Products",
                maxLength: 50,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"),
                column: "ConcurrencyStamp",
                value: "a1eb6e95-8ec6-4bda-90e8-0003983642ae");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"),
                column: "ConcurrencyStamp",
                value: "c1f154aa-bd10-4e60-8d0e-9c913b5d0cc9");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"),
                column: "ConcurrencyStamp",
                value: "e13b623f-7188-42e7-85ca-4806d4b75729");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"),
                column: "ConcurrencyStamp",
                value: "e6cc4a12-4f2c-4f13-b371-e79ed0c9ac8b");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "4b5516e0-1f60-4d65-948a-b43a35896df5");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3cb3ac51-eb25-4170-869b-fe55a14b53a6", "AQAAAAEAACcQAAAAEB16sW7EPzliuGxKgWWkamPTR8UdO6fSosJjWGSWBy0pIGfQm+vJ8CWsJzKQD9tSDw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5fff7c0a-d6fa-48e8-a321-e6ef0ce8faaf", "AQAAAAEAACcQAAAAECYFMLK+vJp2kOOcAflh2VkYDizqt831cB4/Ds0lD0q4ZEVrOVHy4t1Sg3wIrUuTgA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c47f7488-b924-4a9c-980c-9abfbbe77967", "AQAAAAEAACcQAAAAEJjKvDM3ROETW0MMGGimm3pEsAKPYIrYAj+yv6NfVmYBr66dckMf0KQSggW3KLW+AQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Symbol",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "Symbol",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"),
                column: "ConcurrencyStamp",
                value: "ea708706-b236-4d7f-b00c-d29c2629a6e1");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"),
                column: "ConcurrencyStamp",
                value: "60c46723-a4de-407e-b0ef-be8f0c5563a1");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"),
                column: "ConcurrencyStamp",
                value: "04a405e2-8a0a-46b9-ba29-c4f2f126f287");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"),
                column: "ConcurrencyStamp",
                value: "6fd72333-0086-40bb-8ac7-4739e331754f");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "53fc0eb0-80f8-41d5-a461-3aeb0d2efd13");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "70f59a19-2937-461a-9e64-e1a774ee4302", "AQAAAAEAACcQAAAAECCZ9MJ7DLO85Fd0afM5VgFKDSUi7z9YFrVf9brZiDZfuOI0eeHRSsypj0JEuc/PxQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fb1f11c4-4e29-42ff-8380-e7e27a78adfa", "AQAAAAEAACcQAAAAELTwr+GUa0DIPVO6PtH/duQjuOh7yDHuWM8Sj1oZk5U5Et6aMfiLsNGH2Hy0nMva7A==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a1d5306f-fc5a-442e-a450-16c83a807a03", "AQAAAAEAACcQAAAAEHu5ADWI9DbjyGmGPsODvsCIRnSVyC+ee2A8AfKz1ovkvim/Q40PbuUW7x/dLI0I1g==" });
        }
    }
}
