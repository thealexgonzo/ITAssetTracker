using ITAssetTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Persistence.Configuration
{
    public class AssetProductConfiguration : IEntityTypeConfiguration<AssetProduct>
    {
        public void Configure(EntityTypeBuilder<AssetProduct> builder)
        {
            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
            
            builder.HasOne(e => e.Manufacturer)
                .WithMany(e => e.AssetProducts)
                .HasForeignKey(e => e.ManufacturerId);
            
            builder.HasOne(e => e.AssetType)
                .WithMany(e => e.AssetProducts)
                .HasForeignKey(e => e.AssetTypeId);
        }
    }
}
