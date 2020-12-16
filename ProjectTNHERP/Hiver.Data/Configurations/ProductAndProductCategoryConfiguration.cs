using Microsoft.EntityFrameworkCore;
using Hiver.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hiver.Data.Configutions
{
    public class ProductAndProductCategoryConfiguration : IEntityTypeConfiguration<ProductAndProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductAndProductCategory> builder)
        {
            builder.HasKey(x => new { x.IdProduct, x.IdProductCategory });
            builder.ToTable("ProductAndProductCategories");

            builder.HasOne(x => x.Product).WithMany(x => x.ProductAndProductCategories).HasForeignKey(x => x.IdProduct);
            builder.HasOne(x => x.ProductCategory).WithMany(x => x.ProductAndProductCategories).HasForeignKey(x => x.IdProductCategory);
        }
    }
}