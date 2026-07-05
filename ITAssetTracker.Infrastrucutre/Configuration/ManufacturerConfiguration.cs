using ITAssetTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Persistence.Configuration
{
    public class ManufacturerConfiguration : IEntityTypeConfiguration<Manufacturer>
    {
        public void Configure(EntityTypeBuilder<Manufacturer> builder)
        {
            builder.Property(e => e.Name).IsRequired().HasMaxLength(100);
            builder.HasMany(e => e.AssetProducts).WithOne(e => e.Manufacturer);
        }
    }
}
