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

            //Sample value object configuration
            //builder.OwnsOne(
            //e => e.EmploymentPeriod,
            //period =>
            //{
            //    period.Property(p => p.StartDate)
            //        .HasColumnName("StartDate");

            //    period.Property(p => p.EndDate)
            //        .HasColumnName("EndDate");
            //});
        }
    }
}
