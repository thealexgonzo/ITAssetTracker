using ITAssetTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace ITAssetTracker.Persistence.Configuration;

public class PriorityConfiguration : IEntityTypeConfiguration<Priority>
{
    public void Configure(EntityTypeBuilder<Priority> builder)
    {
        builder.Property(e => e.Name).IsRequired().HasMaxLength(100);
        builder.HasMany(e => e.SupportTickets).WithOne(e => e.Priority);

        DateTime seedCreatedDate = new DateTime(2026, 12, 7, 0, 0, 0);

        builder.HasData(
            new
            {
                Id = 1,
                Name = "Low",
                CreatedDate = seedCreatedDate,
                CreatedBy = "Seed"
            },
            new
            {
                Id = 2,
                Name = "Medium",
                CreatedDate = seedCreatedDate,
                CreatedBy = "Seed"
            },
            new
            {
                Id = 3,
                Name = "High",
                CreatedDate = seedCreatedDate,
                CreatedBy = "Seed"
            },
            new
            {
                Id = 4,
                Name = "Critical",
                CreatedDate = seedCreatedDate,
                CreatedBy = "Seed"
            });
    }
}
