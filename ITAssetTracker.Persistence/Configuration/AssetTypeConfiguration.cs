using ITAssetTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace ITAssetTracker.Persistence.Configuration;

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

        DateTime seedCreatedDate = new DateTime(2026, 12, 7, 0, 0, 0);


        builder.HasData
            (
                new
                {
                    Id = 1,
                    Name = "Laptop",
                    CategoryId = 1,
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 2,
                    Name = "Desktop",
                    CategoryId = 1,
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 3,
                    Name = "Monitor",
                    CategoryId = 1,
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 4,
                    Name = "Server",
                    CategoryId = 1,
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 5,
                    Name = "Operating System",
                    CategoryId = 2,
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 6,
                    Name = "Productivity Software",
                    CategoryId = 2,
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 7,
                    Name = "Router",
                    CategoryId = 3,
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 8,
                    Name = "Switch",
                    CategoryId = 3,
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 9,
                    Name = "Smartphone",
                    CategoryId = 4,
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"

                },
                new
                {
                    Id = 10,
                    Name = "Tablet",
                    CategoryId = 4,
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                }
            );
    }
}
