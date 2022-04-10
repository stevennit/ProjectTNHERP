using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hiver.Data.Migrations
{
    public partial class FixTableProductionStock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductionStocks_Productions_ProductionId",
                table: "ProductionStocks");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionStocks_Stocks_StockId",
                table: "ProductionStocks");

            migrationBuilder.AlterColumn<Guid>(
                name: "UnitId",
                table: "ProductionStocks",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "StockId",
                table: "ProductionStocks",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductionId",
                table: "ProductionStocks",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionStocks_Productions_ProductionId",
                table: "ProductionStocks",
                column: "ProductionId",
                principalTable: "Productions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionStocks_Stocks_StockId",
                table: "ProductionStocks",
                column: "StockId",
                principalTable: "Stocks",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductionStocks_Productions_ProductionId",
                table: "ProductionStocks");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionStocks_Stocks_StockId",
                table: "ProductionStocks");

            migrationBuilder.AlterColumn<Guid>(
                name: "UnitId",
                table: "ProductionStocks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "StockId",
                table: "ProductionStocks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductionId",
                table: "ProductionStocks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionStocks_Productions_ProductionId",
                table: "ProductionStocks",
                column: "ProductionId",
                principalTable: "Productions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionStocks_Stocks_StockId",
                table: "ProductionStocks",
                column: "StockId",
                principalTable: "Stocks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
