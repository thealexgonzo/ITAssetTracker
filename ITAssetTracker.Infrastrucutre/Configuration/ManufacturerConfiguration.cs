using ITAssetTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace ITAssetTracker.Persistence.Configuration
{
    public class ManufacturerConfiguration : IEntityTypeConfiguration<Manufacturer>
    {
        public void Configure(EntityTypeBuilder<Manufacturer> builder)
        {
            builder.Property(e => e.Name).IsRequired().HasMaxLength(100);
            builder.HasMany(e => e.AssetProducts).WithOne(e => e.Manufacturer);

            builder.HasData(
                new
                {
                    Id = 1,
                    Name = "Dell",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 2,
                    Name = "Lenovo",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 3,
                    Name = "Apple",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 4,
                    Name = "HP",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 5,
                    Name = "Microsoft",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 6,
                    Name = "Cisco",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 7,
                    Name = "Samsung",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"
                }
            );
        }
    }
}
