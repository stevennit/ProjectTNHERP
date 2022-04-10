using Hiver.Data.Entities;
using Hiver.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hiver.Data.Configutions
{
    public class StockConfiguration : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Stocks");

            builder.HasOne(x => x.StockCategory).WithMany(x => x.Stocks).HasForeignKey(x => x.IdStockCategory);

            builder.Property(x => x.Name).HasMaxLength(200);
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.Property(x => x.Symbol).HasMaxLength(50);

            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
        }
    }
}