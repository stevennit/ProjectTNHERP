using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hiver.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppControllers",
                columns: table => new
                {
                    Controller = table.Column<string>(nullable: false),
                    Action = table.Column<string>(nullable: false),
                    Area = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: true),
                    Licensed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppControllers", x => new { x.Controller, x.Action });
                });

            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoleControllerGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRole = table.Column<Guid>(nullable: false),
                    Controller = table.Column<string>(nullable: true),
                    Action = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleControllerGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoleControllers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Controller = table.Column<string>(nullable: false),
                    Action = table.Column<string>(nullable: false),
                    IdAppUser = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleControllers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    ProviderKey = table.Column<string>(nullable: true),
                    ProviderDisplayName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 200, nullable: false),
                    LastName = table.Column<string>(maxLength: 200, nullable: false),
                    Dob = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "AppControllers",
                columns: new[] { "Controller", "Action", "Area", "Description", "Licensed" },
                values: new object[,]
                {
                    { "User", "Index", null, "Quản lý User", true },
                    { "Home", "Index", null, "Trang Chủ", true }
                });

            migrationBuilder.InsertData(
                table: "AppRoleControllerGroup",
                columns: new[] { "Id", "Action", "Controller", "Description", "IdRole" },
                values: new object[,]
                {
                    { 4, "DETAIL", "User", null, new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee") },
                    { 3, "EDIT", "User", null, new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee") },
                    { 2, "Delete", "User", null, new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee") },
                    { 1, "Index", "User", null, new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee") }
                });

            migrationBuilder.InsertData(
                table: "AppRoleControllers",
                columns: new[] { "Id", "Action", "Controller", "Description", "IdAppUser" },
                values: new object[,]
                {
                    { 3, "Index", "Home", null, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 2, "Index", "Home", null, new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7") },
                    { 1, "Index", "User", null, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") }
                });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"), "c8c4d7a8-125b-4c6e-8661-a146a9e8d352", "Nhân Sự", "Nhansu", "Cấp 2" },
                    { new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"), "6f161636-ee12-4639-a90b-58224a5f69bf", "Kho", "Kho", "Cấp 2" },
                    { new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"), "f1908745-a5ae-4189-92c3-4a3ade5d1918", "Mua hàng", "MuaHang", "Cấp 2" },
                    { new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"), "d947d4ff-ce24-4b3f-bfbd-78c09aa642e4", "BanHang", "BanHang", "Cấp 2" },
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "a8118ade-f9e6-4747-8519-e1d03244694f", "Administrator role", "Administrator", "Cấp 1" }
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"), 0, "154a0c4c-f954-47d9-a9b2-db904d62b811", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "it@gmail.com", true, "Nguyễn", "It", false, null, "it@gmail.com", "it", "AQAAAAEAACcQAAAAEG0avp7TI7Mee7TFwsRlPjGlrDWO+sgTJROX51iDXytWGxzQ2cW+ncU8iOC4Vd/xVg==", null, false, "", false, "it" },
                    { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, "41cb2951-4f67-4dd3-af8b-04d58968a24e", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Nguyễn", "Admin", false, null, "admin@gmail.com", "admin", "AQAAAAEAACcQAAAAEFzpsLXVLCOe7xHWFO2aZYyLRGWR3UQ4bu5c5v9qi3NZzlzJFk841USm3g67ZE9ITA==", null, false, "", false, "admin" },
                    { new Guid("171f3098-762c-4b02-85c5-a687f6601de4"), 0, "b740119b-65dc-4348-8994-e9a2371a0787", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "kho@gmail.com", true, "Nguyễn", "Kho", false, null, "kho@gmail.com", "kho", "AQAAAAEAACcQAAAAELE17/+dFlvBDHSj5lsjvD71OfOSBMz9XJkciEhGQaDc3/oUUuEHUb5+C4gqHOX5XQ==", null, false, "", false, "kho" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppControllers");

            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppRoleControllerGroup");

            migrationBuilder.DropTable(
                name: "AppRoleControllers");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "AppUserTokens");
        }
    }
}
