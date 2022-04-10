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

            builder.ToTable("StockCategories");

            builder.Property(x => x.Name).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.Property(x => x.Image).HasMaxLength(250);

            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
        }
    }
}