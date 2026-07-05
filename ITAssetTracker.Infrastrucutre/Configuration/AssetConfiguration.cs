using ITAssetTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITAssetTracker.Persistence.Configuration
{
    // Configure how the model buidler should handle the Asset type
    public class AssetConfiguration : IEntityTypeConfiguration<Asset>
    {
        public void Configure(EntityTypeBuilder<Asset> builder)
        {
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
        }
    }
}
