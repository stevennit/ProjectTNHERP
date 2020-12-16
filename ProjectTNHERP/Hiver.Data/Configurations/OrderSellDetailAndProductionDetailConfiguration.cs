using Hiver.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.Data.Configutions
{
    public class OrderSellDetailAndProductionDetailConfiguration : IEntityTypeConfiguration<OrderSellDetailAndProductionDetail>
    {
        public void Configure(EntityTypeBuilder<OrderSellDetailAndProductionDetail> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.ToTable("OrderSellDetailAndProductionDetails");

            builder.HasOne(x => x.OrderSellDetail).WithMany(x => x.OrderSellDetailAndProductionDetails).HasForeignKey(x => x.IdOrderSellDetail);
            builder.HasOne(x => x.ProductionDetail).WithMany(x => x.OrderSellDetailAndProductionDetails).HasForeignKey(x => x.IdProductionDetail);
        }
    }
}
