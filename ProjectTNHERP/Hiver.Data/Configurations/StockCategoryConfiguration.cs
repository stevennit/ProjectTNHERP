using Hiver.Data.Entities;
using Hiver.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hiver.Data.Configutions
{
    public class StockCategoryConfiguration : IEntityTypeConfiguration<StockCategory>
    {
        public void Configure(EntityTypeBuilder<StockCategory> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.ToTable("StockCategories");

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.Property(x => x.Image).HasMaxLength(250);

            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.CreateBy).IsRequired();

            builder.Property(x => x.Status).IsRequired().HasDefaultValue(Status.Active);
        }
    }
}