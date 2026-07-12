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



            builder.HasData(
                new
                {
                    Id = 1,
                    Name = "Unresolved",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 2,
                    Name = "Resolved",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 3,
                    Name = "Repaired",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 4,
                    Name = "Replaced",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 5, 
                    Name = "Configuration Changed",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 6, 
                    Name = "Software Updated",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 7,
                    Name = "User Error",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 8,
                    Name = "No Fault Found",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"
                }
            );
        }
    }
}
