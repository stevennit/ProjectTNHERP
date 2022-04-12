﻿using Hiver.Data.Entities;
using Hiver.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hiver.Data.Configutions
{
    public class PartnerConfiguration : IEntityTypeConfiguration<Partner>
    {
        public void Configure(EntityTypeBuilder<Partner> builder)
        {
            builder.ToTable("Partners");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(200);
            builder.Property(x => x.Mobile).HasMaxLength(200);
            builder.Property(x => x.Email).HasMaxLength(200);
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.Property(x => x.Image).HasMaxLength(250);

            builder.Property(x => x.DoB).HasColumnType("Date");

            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
        }
    }
}