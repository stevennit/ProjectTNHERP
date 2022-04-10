using Hiver.Data.Entities;
using Hiver.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hiver.Data.Configutions
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => new { x.Id });

            builder.ToTable("Products");


            builder.Property(x => x.Name).HasMaxLength(200);
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.Property(x => x.Symbol).HasMaxLength(50);
            builder.Property(x => x.ViewCount).HasDefaultValue(0);

            builder.Property(x => x.Status).HasDefaultValue(Status.Active);

        }
    }
}