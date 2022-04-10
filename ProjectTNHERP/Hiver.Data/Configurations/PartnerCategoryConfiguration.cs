using Hiver.Data.Entities;
using Hiver.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Hiver.Data.Configutions
{
    public class PartnerCategoryConfiguration : IEntityTypeConfiguration<PartnerCategory>
    {
        public void Configure(EntityTypeBuilder<PartnerCategory> builder)
        {
            builder.ToTable("PartnerCategories");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(200);
            builder.Property(x => x.Mobile).HasMaxLength(20);
            builder.Property(x => x.Address).HasMaxLength(200);
            builder.Property(x => x.Email).HasMaxLength(50).IsUnicode(false);
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.Property(x => x.Image).HasMaxLength(250);

            builder.Property(x => x.DoB).HasColumnType("Date");

            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
        }
    }
}