using Hiver.Data.Entities;
using Hiver.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hiver.Data.Configutions
{
    internal class KnifeMoldConfiguration : IEntityTypeConfiguration<KnifeMold>
    {
        public void Configure(EntityTypeBuilder<KnifeMold> builder)
        {
            builder.ToTable("KnifeMolds");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasOne(x => x.KnifeMoldCategory).WithMany(x => x.KnifeMold).HasForeignKey(x => x.IdKnifeMoldCategory).OnDelete(DeleteBehavior.SetNull);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Description).HasMaxLength(250);

            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.CreateBy).IsRequired();
            builder.Property(x => x.Status).IsRequired().HasDefaultValue(Status.Active);
        }
    }
}