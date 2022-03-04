using Hiver.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.Data.Configurations
{
    public class AppRoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.ToTable("AppRoles");

            builder.HasKey(x => new { x.ControllerName , x.ActionName });


            builder.Property(x => x.Description).HasMaxLength(200);
            builder.Property(x => x.Name).IsRequired();

        }
    }
}
