using ITAssetTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Persistence.Configuration
{
    public class AssetAssignmentConfiguration : IEntityTypeConfiguration<AssetAssignment>
    {
        public void Configure(EntityTypeBuilder<AssetAssignment> builder)
        {
            builder.HasOne(e => e.Asset)
                .WithMany(e => e.AssetAssignments)
                .HasForeignKey(e => e.AssetId);

            builder.HasOne(e => e.Employee)
                .WithMany(e => e.AssetAssignments)
                .HasForeignKey(e => e.EmployeeId);
            
            builder.Property(e => e.AssignmentPeriod.start)
                .IsRequired();
        }
    }
}
