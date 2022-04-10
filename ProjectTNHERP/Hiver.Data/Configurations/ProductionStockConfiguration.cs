using Hiver.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.Data.Configurations
{
    public class ProductionStockConfiguration : IEntityTypeConfiguration<ProductionStock>
    {
        public void Configure(EntityTypeBuilder<ProductionStock> builder)
        {
            builder.ToTable("ProductionStocks");

            builder.HasKey(x => x.Id);

        }
    }
}
