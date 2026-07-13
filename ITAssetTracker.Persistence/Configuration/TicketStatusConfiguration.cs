using ITAssetTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace ITAssetTracker.Persistence.Configuration
{
    public class TicketStatusConfiguration : IEntityTypeConfiguration<TicketStatus>
    {
        public void Configure(EntityTypeBuilder<TicketStatus> builder)
        {
            builder.Property(e => e.Name).IsRequired().HasMaxLength(100);
            builder.HasMany(e => e.SupportTickets).WithOne(e => e.TicketStatus);

            DateTime seedCreatedDate = new DateTime(2026, 12, 7, 0, 0, 0);

            builder.HasData
            (
                new
                {
                    Id = 1,
                    Name = "Open",
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 2,
                    Name = "In Progress",
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 3,
                    Name = "Resolved",
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 4,
                    Name = "Closed",
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                }
            );
        }
    }
}
