using ITAssetTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace ITAssetTracker.Persistence.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(e => e.Name).IsRequired().HasMaxLength(100);
            builder.HasMany(e => e.Users).WithOne(e => e.Role);

            builder.HasData(
                new
                {
                    Id = 1,
                    Name = "Admin",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 2,
                    Name = "IT Support",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 3,
                    Name = "Manager",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 4,
                    Name = "Employee",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"
                });
        }
    }
}
