using ITAssetTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITAssetTracker.Persistence.Configuration;

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

        builder.HasData
            (
                new
                {
                    Id = 1,
                    Name = "Latitude 5420", 
                    ManufacturerId = 1, 
                    AssetTypeId = 1,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 2,
                    Name = "ThinkPad X1 Carbon",
                    ManufacturerId = 2, 
                    AssetTypeId = 1,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 3,
                    Name = "MacBook Pro 16",
                    ManufacturerId = 3,
                    AssetTypeId = 1,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 4,
                    Name = "EliteDesk 800",
                    ManufacturerId = 4,
                    AssetTypeId = 2,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"

                },
                new
                {
                    Id = 5,
                    Name = "UltraSharp 27 Monitor",
                    ManufacturerId = 1,
                    AssetTypeId = 3,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"

                },
                new
                {
                    Id = 6,
                    Name = "PowerEdge R740",
                    ManufacturerId = 1,
                    AssetTypeId = 4,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"

                },
                new
                {
                    Id = 7,
                    Name = "Windows 11 Pro",
                    ManufacturerId = 5, 
                    AssetTypeId = 5,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"

                },
                new
                {
                    Id = 8,
                    Name = "Microsoft 365 Business",
                    ManufacturerId = 5,
                    AssetTypeId = 6,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"

                },
                new
                {
                    Id = 9,
                    Name = "Cisco Catalyst 9300",
                    ManufacturerId = 6,
                    AssetTypeId = 8,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"

                },
                new
                {
                    Id = 10,
                    Name = "Galaxy Tab S8",
                    ManufacturerId = 7,
                    AssetTypeId = 10,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"
                });
    }
}
