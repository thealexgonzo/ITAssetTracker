using ITAssetTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace ITAssetTracker.Persistence.Configuration
{
    public class AssetAssignmentConfiguration : IEntityTypeConfiguration<AssetAssignment>
    {
        public void Configure(EntityTypeBuilder<AssetAssignment> builder)
        {
            // Relationships
            builder.HasOne(e => e.Asset)
                .WithMany(e => e.AssetAssignments)
                .HasForeignKey(e => e.AssetId);

            builder.HasOne(e => e.Employee)
                .WithMany(e => e.AssetAssignments)
                .HasForeignKey(e => e.EmployeeId);

            // Seed the owner
            builder.HasData
            (
                new
                {
                    Id = 1,
                    AssetId = 1,
                    EmployeeId = 4,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 2,
                    AssetId = 2,
                    EmployeeId = 3,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 3,
                    AssetId = 4,
                    EmployeeId = 4,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 4,
                    AssetId = 1,
                    EmployeeId = 2,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "Seed"
                }
            );

            // NOTE: This is how you configure a value object as an owned type
            // Configure and seed the owned value objects
            builder.OwnsOne(e => e.AssignmentPeriod, ap =>
            {
                ap.Property(p => p.start).HasColumnName("AssignedDate").IsRequired();
                ap.Property(p => p.end).HasColumnName("ReturnedDate");

                ap.HasData(
                    new
                    {
                        AssetAssignmentId = 1,
                        start = new DateOnly(2024, 1, 5),
                        end = (DateOnly?)null
                    },
                    new
                    {
                        AssetAssignmentId = 2,
                        start = new DateOnly(2024, 2, 10),
                        end = (DateOnly?)null
                    },
                    new
                    {
                        AssetAssignmentId = 3,
                        start = new DateOnly(2024, 1, 5),
                        end = (DateOnly?)null
                    },
                    new
                    {
                        AssetAssignmentId = 4,
                        start = new DateOnly(2023, 1, 1),
                        end = new DateOnly(2024, 1, 4)
                    }
                    );
            });            
        }
    }
}
