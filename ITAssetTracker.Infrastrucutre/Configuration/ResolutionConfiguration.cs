using ITAssetTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITAssetTracker.Persistence.Configuration
{
    public class ResolutionConfiguration : IEntityTypeConfiguration<Resolution>
    {
        public void Configure(EntityTypeBuilder<Resolution> builder)
        {
            builder.Property(e => e.Name).IsRequired().HasMaxLength(100);
            builder.HasMany(e => e.SupportTickets).WithOne(e => e.Resolution);
        }
    }
}
