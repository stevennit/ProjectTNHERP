using Hiver.Data.Entities;
using Hiver.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hiver.Data.Configutions
{
    public class ProductionConfiguration : IEntityTypeConfiguration<Production>
    {
        public void Configure(EntityTypeBuilder<Production> builder)
        {
            builder.ToTable("Productions");

            builder.HasOne(x => x.OrderSell).WithMany(x => x.Productions).HasForeignKey(x => x.OrderSellId).OnDelete(DeleteBehavior.SetNull);

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Description).HasMaxLength(250);

            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
        }
    }
}