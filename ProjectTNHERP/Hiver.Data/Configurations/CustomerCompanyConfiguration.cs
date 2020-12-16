using Hiver.Data.Entities;
using Hiver.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Hiver.Data.Configutions
{
    public class CustomerCompanyConfiguration : IEntityTypeConfiguration<CustomerCompany>
    {
        public void Configure(EntityTypeBuilder<CustomerCompany> builder)
        {
            builder.ToTable("CustomerCompanies");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Mobile).HasMaxLength(20);
            builder.Property(x => x.Address).HasColumnType("xml");
            builder.Property(x => x.Email).HasMaxLength(50).IsUnicode(false);
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.Property(x => x.Image).HasMaxLength(250);
            builder.Property(x => x.ImageMore).HasColumnType("xml");

            builder.Property(x => x.DoB).HasColumnType("Date");

            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.CreateBy).IsRequired();

            builder.Property(x => x.Status).IsRequired().HasDefaultValue(Status.Active);
        }
    }
}