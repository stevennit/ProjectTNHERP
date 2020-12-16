using Hiver.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hiver.Data.Configutions
{
    public class KnifeMoldUsingConfiguration : IEntityTypeConfiguration<KnifeMoldUsing>
    {
        public void Configure(EntityTypeBuilder<KnifeMoldUsing> builder)
        {
            builder.ToTable("KnifeMoldUsings");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasOne(x => x.ProductionDetail).WithMany(x => x.KnifeMoldUsings).HasForeignKey(x => x.IdProductionDetail);

            builder.Property(x => x.UserUsingStart).IsRequired().HasMaxLength(50);
            builder.Property(x => x.DateUsingStart).IsRequired().HasColumnType("Date");
            builder.Property(x => x.UserUsingStart).IsRequired().HasMaxLength(50);
            builder.Property(x => x.DateUsingEnd).IsRequired().HasColumnType("Date");

        }
    }
}