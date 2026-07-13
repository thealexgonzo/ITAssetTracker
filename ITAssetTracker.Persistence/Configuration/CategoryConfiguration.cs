using ITAssetTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace ITAssetTracker.Persistence.Configuration;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(100);
        
        builder.HasMany(e => e.AssetTypes)
            .WithOne(e => e.Category);

        DateTime seedCreatedDate = new DateTime(2026, 12, 7, 0, 0, 0);

        builder.HasData
            (
                new
                {
                    Id = 1,
                    Name = "Hardware",
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 2,
                    Name = "Software",
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 3,
                    Name = "Networking",
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 4,
                    Name = "Mobile Devices",
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                }
            );
    }
}
