using ITAssetTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Persistence.Configuration
{
    public class AssetStatusConfiguration : IEntityTypeConfiguration<AssetStatus>
    {
        public void Configure(EntityTypeBuilder<AssetStatus> builder)
        {
            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
            
            builder.HasMany(e => e.Assets)
                .WithOne(e => e.AssetStatuses);
        }
    }
}
