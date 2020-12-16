using Hiver.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hiver.Data.Configutions
{
    public class KnifeMoldImageConfiguration : IEntityTypeConfiguration<KnifeMoldImage>
    {
        public void Configure(EntityTypeBuilder<KnifeMoldImage> builder)
        {
            builder.ToTable("KnifeMoldImages");
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.KnifeMold).WithMany(x => x.KnifeMoldImages).HasForeignKey(x => x.IdKnifeMold);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.ImagePath).HasMaxLength(200).IsRequired(true);
            builder.Property(x => x.Caption).HasMaxLength(200);

           
        }
    }
}