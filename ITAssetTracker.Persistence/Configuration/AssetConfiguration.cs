using ITAssetTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace ITAssetTracker.Persistence.Configuration
{
    // Configure how the model buidler should handle the Asset type
    public class AssetConfiguration : IEntityTypeConfiguration<Asset>
    {
        public void Configure(EntityTypeBuilder<Asset> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Tag)
                .IsRequired();
            
            builder.HasOne(e => e.AssetProducts)
                .WithMany(e => e.Assets)
                .HasForeignKey(e => e.AssetProductId);
            
            builder.HasOne(e => e.AssetStatuses)
                .WithMany(e => e.Assets)
                .HasForeignKey(e => e.AssetStatusId);

            DateTime seedCreatedDate = new DateTime(2026, 12, 7, 0, 0, 0);

            builder.HasData
                    (
                    new
                    {
                        Id = 1,
                        Tag = "10001",
                        Name = "Dell Latitude Laptop",
                        AssetProductId = 1,
                        AssetStatusId = 2,
                        Price = 1200m,
                        Location = "London Office",
                        SerialNumber = "DL5420-ABC123",
                        PurchaseDate = new DateOnly(2023, 1, 10), 
                        WarrantyExpiryDate = new DateOnly(2026, 1, 10), 
                        Description = "Primary developer laptop",
                        CreatedDate = seedCreatedDate,
                        CreatedBy = "Seed",
                    },
                    new
                    {
                        Id = 2,
                        Tag = "10002", 
                        Name = "ThinkPad X1", 
                        AssetProductId = 2, 
                        AssetStatusId = 2, 
                        Price = 1400m, 
                        Location = "Finance Office", 
                        SerialNumber = "TPX1-DEF456", 
                        PurchaseDate = new DateOnly(2023, 3, 12), 
                        WarrantyExpiryDate = new DateOnly(2026, 3, 12), 
                        Description = "Finance department laptop",
                        CreatedDate = seedCreatedDate,
                        CreatedBy = "Seed"
                    },
                    new
                    {
                        Id = 3,
                        Tag = "10003", 
                        Name = "MacBook Pro", 
                        AssetProductId = 3, 
                        AssetStatusId = 1, 
                        Price = 2400m, 
                        Location = "IT Storage", 
                        SerialNumber = "MBP-GHI789", 
                        PurchaseDate = new DateOnly(2024, 1, 20), 
                        WarrantyExpiryDate = new DateOnly(2027, 1, 20), 
                        Description = "Spare executive laptop",
                        CreatedDate = seedCreatedDate,
                        CreatedBy = "Seed"
                    },
                    new
                    {
                        Id = 4,
                        Tag = "10004", 
                        Name = "Dell Monitor", 
                        AssetProductId = 5, 
                        AssetStatusId = 2, 
                        Price = 350m, 
                        Location = "London Office", 
                        SerialNumber = "MON-XYZ111", 
                        PurchaseDate = new DateOnly(2023, 2, 1), 
                        WarrantyExpiryDate = new DateOnly(2026, 2, 1), 
                        Description = "27 inch monitor",
                        CreatedDate = seedCreatedDate,
                        CreatedBy = "Seed"
                    },
                    new
                    {
                        Id = 5,
                        Tag = "10005", 
                        Name = "Cisco Switch", 
                        AssetProductId = 9, 
                        AssetStatusId = 3, 
                        Price = 5000m, 
                        Location = "Server Room", 
                        SerialNumber = "CSC-9300-222", 
                        PurchaseDate = new DateOnly(2022, 5, 1), 
                        WarrantyExpiryDate = new DateOnly(2027, 5, 1), 
                        Description = "Core network switch",
                        CreatedDate = seedCreatedDate,
                        CreatedBy = "Seed"
                    });
        }
    }
}
