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
    public class LSXConfiguration : IEntityTypeConfiguration<LSX>
    {
        public void Configure(EntityTypeBuilder<LSX> builder)
        {
            builder.ToTable("LSXs");

            builder.HasKey(x => x.Id);

        }
    }
}
