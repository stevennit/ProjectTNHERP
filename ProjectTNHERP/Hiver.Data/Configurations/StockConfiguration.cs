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
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasOne(x => x.StockCategory).WithMany(x => x.Stocks).HasForeignKey(x => x.IdStockCategory);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.Property(x => x.Symbol).HasMaxLength(50);

            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.CreateBy).IsRequired();

            builder.Property(x => x.Status).IsRequired().HasDefaultValue(Status.Active);
        }
    }
}