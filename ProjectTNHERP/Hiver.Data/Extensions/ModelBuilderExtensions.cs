using Hiver.Data.Entities;
using Hiver.Utilities.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            #region Add Data AppUser

            var hasher = new PasswordHasher<AppUser>();

            modelBuilder.Entity<AppUser>().HasData(
                new AppUser
                {
                    Id = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE"),
                    UserName = "admin",
                    NormalizedUserName = "admin",
                    Email = "admin@gmail.com",
                    NormalizedEmail = "admin@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Nguyennam1"),
                    SecurityStamp = string.Empty,
                    FirstName = "Nguyễn",
                    LastName = "Admin",
                    Dob = new DateTime(2020, 01, 31)
                },
                new AppUser
                {
                    Id = new Guid("A3335A51-C19B-4EC8-9DEC-39EF33E69BF7"),
                    UserName = "it",
                    NormalizedUserName = "it",
                    Email = "it@gmail.com",
                    NormalizedEmail = "it@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Nguyennam1"),
                    SecurityStamp = string.Empty,
                    FirstName = "Nguyễn",
                    LastName = "It",
                    Dob = new DateTime(2020, 01, 31)
                },
                new AppUser
                {
                    Id = new Guid("171F3098-762C-4B02-85C5-A687F6601DE4"),
                    UserName = "kho",
                    NormalizedUserName = "kho",
                    Email = "kho@gmail.com",
                    NormalizedEmail = "kho@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Nguyennam1"),
                    SecurityStamp = string.Empty,
                    FirstName = "Nguyễn",
                    LastName = "Kho",
                    Dob = new DateTime(2020, 01, 31)
                }
            );
            #endregion


            #region Add Data Role 
            modelBuilder.Entity<AppRole>().HasData(
                new AppRole
                {
                    Id = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC"),
                    Name = "admin",
                    ControllerName = "Users",
                    ActionName = "GetAllPaging",
                    Description = "Tài khoản - Xem tất cả tài khoản"
                }, new AppRole
                {
                    Id = new Guid("44694FAB-619C-4BCC-A8A1-4247A17905F5"),
                    Name = "admin",
                    ControllerName = "Users",
                    ActionName = "GetById",
                    Description = "Tài khoản - Xem chi tiết tài khoản"
                }, new AppRole
                {
                    Id = new Guid("80B0A1AC-D287-4BA3-92C4-51CBCEA55920"),
                    Name = "admin",
                    ControllerName = "Register",
                    ActionName = "admin",
                    Description = "Tài khoản - Đăng ký tài khoản"
                }, new AppRole
                {
                    Id = new Guid("2629553D-758A-460B-92CF-5C34B76A97A7"),
                    Name = "admin",
                    ControllerName = "Users",
                    ActionName = "Update",
                    Description = "Tài khoản - Cập nhập tài khoản"
                },new AppRole
                {
                    Id = new Guid("7FEB5851-4244-4538-A6BD-3B98C18AFEEE"),
                    Name = "admin",
                    ControllerName = "Delete",
                    ActionName = "admin",
                    Description = "Tài khoản - Xóa tài khoản"
                }
            );
            #endregion

            #region Add Data Menu 
            modelBuilder.Entity<Menu>().HasData(
               new Menu
               {
                   MenuID = 1,
                   ParentID = -1,
                   MenuName = "Trang Chính",
                   Description = null,
                   Url = "/",
                   IconClass = null,
                   MenuVisible = 1,
                   IsVisible = true,
               },
               new Menu
               {
                   MenuID = 2,
                   ParentID = -1,
                   MenuName = "Kho",
                   Description = null,
                   Url = "/",
                   IconClass = null,
                   MenuVisible = 2,
                   IsVisible = true,
               },
               new Menu
               {
                   MenuID = 3,
                   ParentID = 2,
                   MenuName = "Nguyên Liệu",
                   Description = null,
                   Url = "/Store",
                   IconClass = null,
                   MenuVisible = 3,
                   IsVisible = true,
               },
               new Menu
               {
                   MenuID = 4,
                   ParentID = 2,
                   MenuName = "Thành Phẩm",
                   Description = null,
                   Url = "/Product",
                   IconClass = null,
                   MenuVisible = 4,
                   IsVisible = true,
               },
               new Menu
               {
                   MenuID = 5,
                   ParentID = -1,
                   MenuName = "Kinh Doanh",
                   Description = null,
                   Url = "/Sale",
                   IconClass = null,
                   MenuVisible = 4,
                   IsVisible = true,
               },
               new Menu
               {
                   MenuID = 6,
                   ParentID = -1,
                   MenuName = "Khách Hàng",
                   Description = null,
                   Url = "/Customer",
                   IconClass = null,
                   MenuVisible = 5,
                   IsVisible = true,
               },
               new Menu
               {
                   MenuID = 7,
                   ParentID = -1,
                   MenuName = "Nhà Cung Cấp",
                   Description = null,
                   Url = "/Supplier",
                   IconClass = null,
                   MenuVisible = 4,
                   IsVisible = true,
               }
           );
            #endregion

            #region Data ProductCategory
            modelBuilder.Entity<ProductCategory>().HasData(
              new ProductCategory
              {
                  Id = new Guid("f9cb0cac-5219-42f7-8182-a7b01d122c4b"),
                  Name = "Tem Loại 1"
              }, new ProductCategory
              {
                  Id = new Guid("fee35eb7-a414-4ec1-8ce0-7d11fc10ff3d"),
                  Name = "Tem Loại 2"
              }
            );
            #endregion
        }
    }
}