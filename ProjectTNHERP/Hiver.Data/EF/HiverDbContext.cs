using Hiver.Data.Configurations;
using Hiver.Data.Configutions;
using Hiver.Data.Entities;
using Hiver.Data.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.Data.EF
{
    public class HiverDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public HiverDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure using Fluent API

            modelBuilder.ApplyConfiguration(new MenuConfiguration());

            

            modelBuilder.ApplyConfiguration(new PartnerCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new PartnerConfiguration());

            modelBuilder.ApplyConfiguration(new ProductionConfiguration());
            modelBuilder.ApplyConfiguration(new ProductionDetailConfiguration());

            modelBuilder.ApplyConfiguration(new KnifeMoldCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new KnifeMoldConfiguration());
            modelBuilder.ApplyConfiguration(new KnifeMoldImageConfiguration());
            modelBuilder.ApplyConfiguration(new KnifeMoldUsingConfiguration());

            modelBuilder.ApplyConfiguration(new OrderByConfiguration());
            modelBuilder.ApplyConfiguration(new OrderByStockConfiguration());
            modelBuilder.ApplyConfiguration(new OrderByDetailAndProductionDetailConfiguration());
            modelBuilder.ApplyConfiguration(new OrderSellConfiguration());
            modelBuilder.ApplyConfiguration(new OrderSellProductConfiguration());
            modelBuilder.ApplyConfiguration(new OrderSellDetailAndProductionDetailConfiguration());

            modelBuilder.ApplyConfiguration(new ProductAndProductCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductImageConfiguration());

            modelBuilder.ApplyConfiguration(new StockCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new StockConfiguration());
            modelBuilder.ApplyConfiguration(new StockImageConfiguration());

            modelBuilder.ApplyConfiguration(new SupplierCompanyConfiguration());
            modelBuilder.ApplyConfiguration(new SupplierConfiguration());

            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());


            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

            //Data seeding
            modelBuilder.Seed();
            //base.OnModelCreating(modelBuilder);
        }


        public DbSet<Menu> Menus { set; get; }

        public DbSet<Partner> Customers { set; get; }
        public DbSet<PartnerCategory> CustomerCompanies { set; get; }

        public DbSet<Production> Productions { set; get; }
        public DbSet<ProductionDetail> ProductionDetails { get; set; }

        public DbSet<KnifeMoldCategory> KnifeMoldCategories { set; get; }
        public DbSet<KnifeMold> KnifeMolds { set; get; }
        public DbSet<KnifeMoldImage> KnifeMoldImages { set; get; }
        public DbSet<KnifeMoldUsing> KnifeMoldUsings { set; get; }

        public DbSet<OrderBy> OrderBies { set; get; }
        public DbSet<OrderByDetail> OrderByDetails { set; get; }
        public DbSet<OrderByDetailAndProductionDetail> OrderByDetailAndProductionDetails { set; get; }
        public DbSet<OrderSell> OrderSells { set; get; }
        public DbSet<OrderSellDetail> OrderSellProducts { set; get; }
        public DbSet<OrderSellDetailAndProductionDetail> OrderSellDetailAndProductionDetails { set; get; }

        public DbSet<ProductAndProductCategory> ProductAndProductCategories { set; get; }
        public DbSet<ProductCategory> ProductCategories { set; get; }
        public DbSet<ProductImage> ProductImages { set; get; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Stock> Stocks { set; get; }
        public DbSet<StockCategory> StockCategories { set; get; }
        public DbSet<StockImage> StockImages { set; get; }

        public DbSet<Supplier> Suppliers { set; get; }
        public DbSet<SupplierCompany> SupplierCompanies { set; get; }

    }
}