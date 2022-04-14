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

            builder.HasOne(x => x.KnifeMoldCategory).WithMany(x => x.KnifeMold).HasForeignKey(x => x.IdKnifeMoldCategory).OnDelete(DeleteBehavior.SetNull);

            builder.Property(x => x.Name).HasMaxLength(200);
            builder.Property(x => x.Description).HasMaxLength(250);

            builder.Property(x => x.Status).HasDefaultValue(true);
        }
    }
}