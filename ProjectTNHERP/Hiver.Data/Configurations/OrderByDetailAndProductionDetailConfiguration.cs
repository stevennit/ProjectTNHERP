using Hiver.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hiver.Data.Configutions
{
    public class OrderByDetailAndProductionDetailConfiguration : IEntityTypeConfiguration<OrderByDetailAndProductionDetail>
    {
        public void Configure(EntityTypeBuilder<OrderByDetailAndProductionDetail> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.ToTable("OrderByDetailAndProductionDetails");

            builder.HasOne(x => x.OrderByDetail).WithMany(x => x.OrderByDetailAndProductionDetails).HasForeignKey(x => x.IdOrderByDetail);
            builder.HasOne(x => x.ProductionDetail).WithMany(x => x.OrderByDetailAndProductionDetails).HasForeignKey(x => x.IdProductionDetail);
        }
    }
}