using ITAssetTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace ITAssetTracker.Persistence.Configuration
{
    public class ResolutionConfiguration : IEntityTypeConfiguration<Resolution>
    {
        public void Configure(EntityTypeBuilder<Resolution> builder)
        {
            builder.Property(e => e.Name).IsRequired().HasMaxLength(100);
            builder.HasMany(e => e.SupportTickets).WithOne(e => e.Resolution);

            DateTime seedCreatedDate = new DateTime(2026, 12, 7, 0, 0, 0);

            builder.HasData(
                new
                {
                    Id = 1,
                    Name = "Unresolved",
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 2,
                    Name = "Resolved",
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 3,
                    Name = "Repaired",
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 4,
                    Name = "Replaced",
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 5, 
                    Name = "Configuration Changed",
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 6, 
                    Name = "Software Updated",
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 7,
                    Name = "User Error",
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 8,
                    Name = "No Fault Found",
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                }
            );
        }
    }
}
