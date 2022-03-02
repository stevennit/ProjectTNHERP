using Hiver.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.Data.Configutions
{
    public class StockImageConfiguration : IEntityTypeConfiguration<StockImage>
    {
        public void Configure(EntityTypeBuilder<StockImage> builder)
        {
            builder.ToTable("StockImages");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.ImagePath).HasMaxLength(200).IsRequired(true);
            builder.Property(x => x.Caption).HasMaxLength(200);

            builder.HasOne(x => x.Stock).WithMany(x => x.StockImages).HasForeignKey(x => x.IdTable);
        }
    }
}
