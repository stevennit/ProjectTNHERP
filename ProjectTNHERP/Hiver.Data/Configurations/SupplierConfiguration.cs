using Hiver.Data.Entities;
using Hiver.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hiver.Data.Configutions
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.ToTable("Suppliers");

            builder.HasOne(x => x.SupplierCompany).WithMany(x => x.Suppliers).HasForeignKey(x => x.IdSupplierCompany);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Mobile).HasColumnType("xml");
            builder.Property(x => x.Email).HasColumnType("xml");
            builder.Property(x => x.Message).HasColumnType("xml");
            builder.Property(x => x.Description).HasMaxLength(250);

            builder.Property(x => x.DoB).HasColumnType("Date");

            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.CreateBy).IsRequired();

            builder.Property(x => x.Status).IsRequired().HasDefaultValue(Status.Active);
        }
    }
}