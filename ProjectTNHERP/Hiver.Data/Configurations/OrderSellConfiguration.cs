using Hiver.Data.Entities;
using Hiver.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hiver.Data.Configutions
{
    public class OrderSellConfiguration : IEntityTypeConfiguration<OrderSell>
    {
        public void Configure(EntityTypeBuilder<OrderSell> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("OrderSells");
            

            builder.Property(x => x.Name).HasMaxLength(200);
            builder.Property(x => x.Description).HasMaxLength(250);

            builder.Property(x => x.Status).HasDefaultValue(true);
        }
    }
}