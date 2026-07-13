using ITAssetTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
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

            DateTime seedCreatedDate = new DateTime(2026, 12, 7, 0, 0, 0);

            builder.HasData
            (
                new
                {
                    Id = 1,
                    Name = "Available",
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 2,
                    Name = "Assigned",
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 3,
                    Name = "In Repair",
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 4,
                    Name = "Retired",
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 5,
                    Name = "Disposed",
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                }
            );
        }
    }
}
