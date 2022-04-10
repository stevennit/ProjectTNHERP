using Hiver.Data.Entities;
using Hiver.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hiver.Data.Configutions
{
    public class PartnerConfiguration : IEntityTypeConfiguration<Partner>
    {
        public void Configure(EntityTypeBuilder<Partner> builder)
        {
            builder.ToTable("Customers");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasOne(x => x.CustomerCompany).WithMany(c => c.Customer).HasForeignKey(a => a.IdCustomerCompany).OnDelete(DeleteBehavior.SetNull);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Mobile).HasColumnType("xml");
            builder.Property(x => x.Email).HasColumnType("xml");
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.Property(x => x.Image).HasMaxLength(250);

            builder.Property(x => x.DoB).HasColumnType("Date");

            builder.Property(x => x.Status).IsRequired().HasDefaultValue(Status.Active);
        }
    }
}