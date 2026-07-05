using ITAssetTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITAssetTracker.Persistence.Configuration;

public class PriorityConfiguration : IEntityTypeConfiguration<Priority>
{
    public void Configure(EntityTypeBuilder<Priority> builder)
    {
        builder.Property(e => e.Name).IsRequired().HasMaxLength(100);
        builder.HasMany(e => e.SupportTickets).WithOne(e => e.Priority);
    }
}
