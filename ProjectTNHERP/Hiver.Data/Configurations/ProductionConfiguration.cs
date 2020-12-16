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

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.UserManager).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Description).HasMaxLength(250);

            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
            builder.Property(x => x.Description).IsRequired();
        }
    }
}