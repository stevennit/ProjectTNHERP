using Hiver.Data.Entities;
using Hiver.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hiver.Data.Configutions
{
    public class KnifeMoldCategoryConfiguration : IEntityTypeConfiguration<KnifeMoldCategory>
    {
        public void Configure(EntityTypeBuilder<KnifeMoldCategory> builder)
        {
            builder.ToTable("KnifeMoldCategories");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(200);
            builder.Property(x => x.Image).HasMaxLength(250);

            builder.Property(x => x.Status).HasDefaultValue(true);
        }
    }
}