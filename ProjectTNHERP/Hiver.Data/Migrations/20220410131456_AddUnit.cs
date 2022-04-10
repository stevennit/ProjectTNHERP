using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hiver.Data.Migrations
{
    public partial class AddUnit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"),
                column: "ConcurrencyStamp",
                value: "b4f1fe4e-67ba-4a2e-b39a-41ec5bd3bcf8");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"),
                column: "ConcurrencyStamp",
                value: "af2bb949-5764-4485-8c3d-ccc356911027");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"),
                column: "ConcurrencyStamp",
                value: "bca24597-39f5-4e3e-a8fd-a37150882484");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"),
                column: "ConcurrencyStamp",
                value: "91247607-8c6e-4644-82f1-3ee95c8426ca");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "e01349d9-f2cf-418d-b607-76fafcae7576");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3b14ad16-b802-401e-a15c-1743fbba07c9", "AQAAAAEAACcQAAAAED7asR2DKi30bHQnZaPuw1nZqplX4yoNERu8rjsoudDtlYWSivw2M8jzBD1GyaSa9Q==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "470a40d0-2bc9-481a-b809-d3574694cee4", "AQAAAAEAACcQAAAAEDIsKPcZ1th3Nzkyhw7ju0GSv8WLiPBuyefq20AVM4K45LVEYWpyWTZX6OWYuiRVww==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "38105f31-126a-4cf1-a35b-0a42339a23e6", "AQAAAAEAACcQAAAAEJOIrEV9Y5yGDWAp+RdPmUtNzMZ29308PBu+aK0cziBZInWRa9C9kcrMKX/M4ko2EA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"),
                column: "ConcurrencyStamp",
                value: "37ef3725-fbad-4ec5-9046-ddfb67db28bd");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"),
                column: "ConcurrencyStamp",
                value: "6fa36b16-c4e2-4c4f-b7bc-1294d9771124");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"),
                column: "ConcurrencyStamp",
                value: "0aae2297-8b36-4607-a35c-f8b3ac2880c5");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"),
                column: "ConcurrencyStamp",
                value: "e3f0d0a0-e5b6-4cc0-93b6-e3518cd6ce95");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "e71aa067-93ec-4e9f-900b-54ff6ef52878");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c4d41c9d-58e7-4ed6-91b8-a3344d277fec", "AQAAAAEAACcQAAAAEFBr9s+VBNcH5+ysrCrwS96fTpb91FGNUehHnUxQI/UnVZGB+fuqaF8tdfWWOwjDvQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e017196e-1861-4b8d-be86-a4230267cc1e", "AQAAAAEAACcQAAAAEPxGyNtSpkKtBxkKckdPNGHD7+bg+8ikgMkVWr48R1vTtNPUrnoCWKZRHRnQH2kyww==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a67f4b41-020e-4218-8961-1cde70303bd3", "AQAAAAEAACcQAAAAEH+CmFzjN3seAPwMQIkyFLCWTlA71SiFl6p4KSkDT62z0nk94H5DpsjAajg0QyV4sw==" });
        }
    }
}
