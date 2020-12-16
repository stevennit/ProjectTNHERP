using Hiver.Data.Entities;
using Hiver.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hiver.Data.Configutions
{
    public class OrderSellProductConfiguration : IEntityTypeConfiguration<OrderSellDetail>
    {
        public void Configure(EntityTypeBuilder<OrderSellDetail> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("OrderSellDetails");

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasOne(x => x.OrderSell).WithMany(x => x.OrderSellDetails).HasForeignKey(x => x.IdOrderSell);
            builder.HasOne(x => x.Product).WithMany(x => x.OrderSellDetails).HasForeignKey(x => x.IdProduct);

            builder.Property(x => x.Description).HasMaxLength(250);

            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.CreateBy).IsRequired();
            builder.Property(x => x.Status).IsRequired().HasDefaultValue(Status.Active);
        }
    }
}