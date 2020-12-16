using Hiver.Data.Entities;
using Hiver.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.Data.Configutions
{
    public class ProductionDetailConfiguration : IEntityTypeConfiguration<ProductionDetail>
    {
        public void Configure(EntityTypeBuilder<ProductionDetail> builder)
        {
            builder.ToTable("ProductionDetails");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasOne(x => x.Production).WithMany(x => x.ProductionDetails).HasForeignKey(x => x.IdProduction);

            builder.Property(x => x.PercentComplete).IsRequired();
            builder.Property(x => x.Summary).HasDefaultValue(true);
            builder.Property(x => x.Expanded).HasDefaultValue(true);

            builder.Property(x => x.UserUsing).HasMaxLength(50);

            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
        }
    }
}
