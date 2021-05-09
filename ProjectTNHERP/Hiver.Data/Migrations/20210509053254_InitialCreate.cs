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
                name: "AppRoleControllerGroups",
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
                    table.PrimaryKey("PK_AppRoleControllerGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoleControllers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Controller = table.Column<string>(nullable: false),
                    Action = table.Column<string>(nullable: false),
                    AppUser = table.Column<string>(nullable: false),
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

            migrationBuilder.CreateTable(
                name: "CustomerCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Mobile = table.Column<string>(maxLength: 20, nullable: true),
                    Email = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "xml", nullable: true),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    Image = table.Column<string>(maxLength: 250, nullable: true),
                    ImageMore = table.Column<string>(type: "xml", nullable: true),
                    DoB = table.Column<DateTime>(type: "Date", nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KnifeMoldCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Image = table.Column<string>(maxLength: 250, nullable: true),
                    ImageMore = table.Column<string>(type: "xml", nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnifeMoldCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentID = table.Column<int>(nullable: true),
                    MenuName = table.Column<string>(maxLength: 150, nullable: true),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    IconClass = table.Column<string>(maxLength: 50, nullable: true),
                    Url = table.Column<string>(maxLength: 200, nullable: true),
                    MenuOrder = table.Column<int>(nullable: false),
                    IsVisible = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuID);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    Image = table.Column<string>(maxLength: 250, nullable: true),
                    ImageMore = table.Column<string>(type: "xml", nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Productions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    UserManager = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Symbol = table.Column<string>(maxLength: 50, nullable: true),
                    Width = table.Column<double>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    Detail = table.Column<string>(nullable: true),
                    ViewCount = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    Image = table.Column<string>(maxLength: 250, nullable: true),
                    ImageMore = table.Column<string>(type: "xml", nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SupplierCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Mobile = table.Column<string>(maxLength: 20, nullable: true),
                    Address = table.Column<string>(type: "xml", nullable: true),
                    Email = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    Image = table.Column<string>(maxLength: 250, nullable: true),
                    ImageMore = table.Column<string>(type: "xml", nullable: true),
                    DoB = table.Column<DateTime>(type: "Date", nullable: false),
                    DateWorkFirst = table.Column<DateTime>(nullable: false),
                    DateWorkEnd = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Mobile = table.Column<string>(type: "xml", nullable: true),
                    Email = table.Column<string>(type: "xml", nullable: true),
                    Message = table.Column<string>(type: "xml", nullable: true),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    Detail = table.Column<string>(nullable: true),
                    Image = table.Column<string>(maxLength: 250, nullable: true),
                    ImageMore = table.Column<string>(type: "xml", nullable: true),
                    DoB = table.Column<DateTime>(type: "Date", nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false, defaultValue: 1),
                    IdCustomerCompany = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_CustomerCompanies_IdCustomerCompany",
                        column: x => x.IdCustomerCompany,
                        principalTable: "CustomerCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "KnifeMolds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Width = table.Column<double>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Column = table.Column<int>(nullable: false),
                    Row = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    Detail = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false, defaultValue: 1),
                    IdKnifeMoldCategory = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnifeMolds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KnifeMolds_KnifeMoldCategories_IdKnifeMoldCategory",
                        column: x => x.IdKnifeMoldCategory,
                        principalTable: "KnifeMoldCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "ProductionDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QtyComplate = table.Column<int>(nullable: false),
                    StartWork = table.Column<DateTime>(nullable: false),
                    EndWork = table.Column<DateTime>(nullable: false),
                    PercentComplete = table.Column<decimal>(nullable: false),
                    Summary = table.Column<bool>(nullable: false, defaultValue: true),
                    Expanded = table.Column<bool>(nullable: false, defaultValue: true),
                    UserUsing = table.Column<string>(maxLength: 50, nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false, defaultValue: 1),
                    IdProduction = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductionDetails_Productions_IdProduction",
                        column: x => x.IdProduction,
                        principalTable: "Productions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductAndProductCategories",
                columns: table => new
                {
                    IdProduct = table.Column<int>(nullable: false),
                    IdProductCategory = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAndProductCategories", x => new { x.IdProduct, x.IdProductCategory });
                    table.ForeignKey(
                        name: "FK_ProductAndProductCategories_Products_IdProduct",
                        column: x => x.IdProduct,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductAndProductCategories_ProductCategories_IdProductCategory",
                        column: x => x.IdProductCategory,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Symbol = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    Detail = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false, defaultValue: 1),
                    IdStockCategory = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stocks_StockCategories_IdStockCategory",
                        column: x => x.IdStockCategory,
                        principalTable: "StockCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Mobile = table.Column<string>(type: "xml", nullable: true),
                    Email = table.Column<string>(type: "xml", nullable: true),
                    Message = table.Column<string>(type: "xml", nullable: true),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    Detail = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    ImageMore = table.Column<string>(nullable: true),
                    DoB = table.Column<DateTime>(type: "Date", nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false, defaultValue: 1),
                    IdSupplierCompany = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Suppliers_SupplierCompanies_IdSupplierCompany",
                        column: x => x.IdSupplierCompany,
                        principalTable: "SupplierCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderSells",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    Detail = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false, defaultValue: 1),
                    IdCustomer = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderSells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderSells_Customers_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KnifeMoldImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdKnifeMold = table.Column<int>(nullable: true),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnifeMoldImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KnifeMoldImages_KnifeMolds_IdKnifeMold",
                        column: x => x.IdKnifeMold,
                        principalTable: "KnifeMolds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KnifeMoldUsings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserUsingStart = table.Column<int>(maxLength: 50, nullable: false),
                    DateUsingStart = table.Column<DateTime>(type: "Date", nullable: false),
                    UserUsingEnd = table.Column<int>(nullable: true),
                    DateUsingEnd = table.Column<DateTime>(type: "Date", nullable: false),
                    IdProductionDetail = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnifeMoldUsings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KnifeMoldUsings_ProductionDetails_IdProductionDetail",
                        column: x => x.IdProductionDetail,
                        principalTable: "ProductionDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdStock = table.Column<int>(nullable: true),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockImages_Stocks_IdStock",
                        column: x => x.IdStock,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderBies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    Detail = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false, defaultValue: 1),
                    IdSupplier = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderBies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderBies_Suppliers_IdSupplier",
                        column: x => x.IdSupplier,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderSellDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qty = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    DateDelivery = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false, defaultValue: 1),
                    IdProduct = table.Column<int>(nullable: false),
                    IdOrderSell = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderSellDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderSellDetails_OrderSells_IdOrderSell",
                        column: x => x.IdOrderSell,
                        principalTable: "OrderSells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderSellDetails_Products_IdProduct",
                        column: x => x.IdProduct,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderByDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qty = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false, defaultValue: 1),
                    IdStock = table.Column<int>(nullable: false),
                    StockId = table.Column<int>(nullable: true),
                    IdOrderBy = table.Column<int>(nullable: false),
                    OrderById = table.Column<int>(nullable: true),
                    KnifeMoldId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderByDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderByDetails_KnifeMolds_KnifeMoldId",
                        column: x => x.KnifeMoldId,
                        principalTable: "KnifeMolds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderByDetails_OrderBies_OrderById",
                        column: x => x.OrderById,
                        principalTable: "OrderBies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderByDetails_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderSellDetailAndProductionDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdOrderSellDetail = table.Column<int>(nullable: false),
                    IdProductionDetail = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderSellDetailAndProductionDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderSellDetailAndProductionDetails_OrderSellDetails_IdOrderSellDetail",
                        column: x => x.IdOrderSellDetail,
                        principalTable: "OrderSellDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderSellDetailAndProductionDetails_ProductionDetails_IdProductionDetail",
                        column: x => x.IdProductionDetail,
                        principalTable: "ProductionDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderByDetailAndProductionDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdOrderByDetail = table.Column<int>(nullable: false),
                    IdProductionDetail = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderByDetailAndProductionDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderByDetailAndProductionDetails_OrderByDetails_IdOrderByDetail",
                        column: x => x.IdOrderByDetail,
                        principalTable: "OrderByDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderByDetailAndProductionDetails_ProductionDetails_IdProductionDetail",
                        column: x => x.IdProductionDetail,
                        principalTable: "ProductionDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                table: "AppRoleControllerGroups",
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
                columns: new[] { "Id", "Action", "AppUser", "Controller", "Description" },
                values: new object[,]
                {
                    { 4, "Update", "admin", "Users", null },
                    { 3, "Register", "admin", "Users", null },
                    { 5, "Delete", "admin", "Users", null },
                    { 1, "GetAllPaging", "admin", "Users", null },
                    { 2, "GetById", "admin", "Users", null }
                });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"), "c16a3082-7de0-46a0-8742-44ac2ccb5720", "Nhân Sự", "Nhansu", "Cấp 2" },
                    { new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"), "ca41d082-e85f-4aaa-827a-4cb75de35b62", "Kho", "Kho", "Cấp 2" },
                    { new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"), "7a091f7f-84b9-4774-a95f-f5c24ec1bac0", "Mua hàng", "MuaHang", "Cấp 2" },
                    { new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"), "a11aeada-f23b-4e50-b22b-785d2f84ba0e", "BanHang", "BanHang", "Cấp 2" },
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "0149f1bf-3402-49bd-867e-10bfa2f3c79f", "Administrator role", "Administrator", "Cấp 1" }
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, "dbf34965-4a03-4237-bd36-a619b2754e5e", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Nguyễn", "Admin", false, null, "admin@gmail.com", "admin", "AQAAAAEAACcQAAAAEDhVBaGAyc8mX96cfX9DGfn5HRjrc6TMIqzzGbTmb5G2KxfF1Bl9Vs8HzhAtBQYXUw==", null, false, "", false, "admin" },
                    { new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"), 0, "799387cc-2581-464e-b22f-87196dc0a98b", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "it@gmail.com", true, "Nguyễn", "It", false, null, "it@gmail.com", "it", "AQAAAAEAACcQAAAAEEPlLXBSqi+zlQETwSOlB+gnMXlReCFslh2c+vd9jzsowCioJNSX3oU9itTS824KWg==", null, false, "", false, "it" },
                    { new Guid("171f3098-762c-4b02-85c5-a687f6601de4"), 0, "fcf15d14-0317-4213-829d-79d2fa09c1d9", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "kho@gmail.com", true, "Nguyễn", "Kho", false, null, "kho@gmail.com", "kho", "AQAAAAEAACcQAAAAEMHwYqtyZn3v4+ESJX5Xk0CTOey3qk3tkUpmx7CHrrYmgGpC2AlFqa+mcLyC4cRNaA==", null, false, "", false, "kho" }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuID", "Description", "IconClass", "IsVisible", "MenuName", "MenuOrder", "ParentID", "Url" },
                values: new object[,]
                {
                    { 4, null, null, true, "Thành Phẩm", 1, 2, "/" },
                    { 1, null, null, true, "Trang Chính", 1, -1, "/" },
                    { 2, null, null, true, "Kho", 1, -1, "/" },
                    { 3, null, null, true, "Nguyên Liệu", 1, 2, "/" },
                    { 5, null, null, true, "Kinh Doanh", 1, -1, "/" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_IdCustomerCompany",
                table: "Customers",
                column: "IdCustomerCompany");

            migrationBuilder.CreateIndex(
                name: "IX_KnifeMoldImages_IdKnifeMold",
                table: "KnifeMoldImages",
                column: "IdKnifeMold");

            migrationBuilder.CreateIndex(
                name: "IX_KnifeMolds_IdKnifeMoldCategory",
                table: "KnifeMolds",
                column: "IdKnifeMoldCategory");

            migrationBuilder.CreateIndex(
                name: "IX_KnifeMoldUsings_IdProductionDetail",
                table: "KnifeMoldUsings",
                column: "IdProductionDetail");

            migrationBuilder.CreateIndex(
                name: "IX_OrderBies_IdSupplier",
                table: "OrderBies",
                column: "IdSupplier");

            migrationBuilder.CreateIndex(
                name: "IX_OrderByDetailAndProductionDetails_IdOrderByDetail",
                table: "OrderByDetailAndProductionDetails",
                column: "IdOrderByDetail");

            migrationBuilder.CreateIndex(
                name: "IX_OrderByDetailAndProductionDetails_IdProductionDetail",
                table: "OrderByDetailAndProductionDetails",
                column: "IdProductionDetail");

            migrationBuilder.CreateIndex(
                name: "IX_OrderByDetails_KnifeMoldId",
                table: "OrderByDetails",
                column: "KnifeMoldId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderByDetails_OrderById",
                table: "OrderByDetails",
                column: "OrderById");

            migrationBuilder.CreateIndex(
                name: "IX_OrderByDetails_StockId",
                table: "OrderByDetails",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderSellDetailAndProductionDetails_IdOrderSellDetail",
                table: "OrderSellDetailAndProductionDetails",
                column: "IdOrderSellDetail");

            migrationBuilder.CreateIndex(
                name: "IX_OrderSellDetailAndProductionDetails_IdProductionDetail",
                table: "OrderSellDetailAndProductionDetails",
                column: "IdProductionDetail");

            migrationBuilder.CreateIndex(
                name: "IX_OrderSellDetails_IdOrderSell",
                table: "OrderSellDetails",
                column: "IdOrderSell");

            migrationBuilder.CreateIndex(
                name: "IX_OrderSellDetails_IdProduct",
                table: "OrderSellDetails",
                column: "IdProduct");

            migrationBuilder.CreateIndex(
                name: "IX_OrderSells_IdCustomer",
                table: "OrderSells",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAndProductCategories_IdProductCategory",
                table: "ProductAndProductCategories",
                column: "IdProductCategory");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionDetails_IdProduction",
                table: "ProductionDetails",
                column: "IdProduction");

            migrationBuilder.CreateIndex(
                name: "IX_StockImages_IdStock",
                table: "StockImages",
                column: "IdStock");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_IdStockCategory",
                table: "Stocks",
                column: "IdStockCategory");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_IdSupplierCompany",
                table: "Suppliers",
                column: "IdSupplierCompany");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppControllers");

            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppRoleControllerGroups");

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

            migrationBuilder.DropTable(
                name: "KnifeMoldImages");

            migrationBuilder.DropTable(
                name: "KnifeMoldUsings");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "OrderByDetailAndProductionDetails");

            migrationBuilder.DropTable(
                name: "OrderSellDetailAndProductionDetails");

            migrationBuilder.DropTable(
                name: "ProductAndProductCategories");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "StockImages");

            migrationBuilder.DropTable(
                name: "OrderByDetails");

            migrationBuilder.DropTable(
                name: "OrderSellDetails");

            migrationBuilder.DropTable(
                name: "ProductionDetails");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "KnifeMolds");

            migrationBuilder.DropTable(
                name: "OrderBies");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "OrderSells");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Productions");

            migrationBuilder.DropTable(
                name: "KnifeMoldCategories");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "StockCategories");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "SupplierCompanies");

            migrationBuilder.DropTable(
                name: "CustomerCompanies");
        }
    }
}
