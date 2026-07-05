using ITAssetTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
    }
}
