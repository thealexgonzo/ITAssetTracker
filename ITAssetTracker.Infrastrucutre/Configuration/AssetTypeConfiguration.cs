using ITAssetTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Persistence.Configuration
{
    public class AssetTypeConfiguration : IEntityTypeConfiguration<AssetType>
    {
        public void Configure(EntityTypeBuilder<AssetType> builder)
        {
            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
            
            builder.HasMany(e => e.AssetProducts)
                .WithOne(e => e.AssetType);
            
            builder.HasOne(e => e.Category)
                .WithMany(e => e.AssetTypes)
                .HasForeignKey(e => e.CategoryId);
        }
    }
}
