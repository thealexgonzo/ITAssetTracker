using ITAssetTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITAssetTracker.Persistence.Configuration;

public class SupportTicketConfiguration : IEntityTypeConfiguration<SupportTicket>
{
    public void Configure(EntityTypeBuilder<SupportTicket> builder)
    {
        builder.OwnsOne(e => e.ActivePeriod, ap =>
        {
            ap.Property(p => p.start).HasColumnName("CreationDate").IsRequired();
            ap.Property(p => p.end).HasColumnName("ClosedDate");
        });

        builder.Property(e => e.Title).IsRequired().HasMaxLength(300);
        builder.HasOne(e => e.TicketStatus).WithMany(e => e.SupportTickets).HasForeignKey(e => e.TicketStatusId);
        builder.HasOne(e => e.Priority).WithMany(e => e.SupportTickets).HasForeignKey(e => e.PriorityId);
        builder.HasOne(e => e.Resolution).WithMany(e => e.SupportTickets).HasForeignKey(e => e.ResolutionId);

        DateTime seedCreatedDate = new DateTime(2026, 12, 7, 0, 0, 0);

        builder.HasData
            (
                new
                {
                    Id =1,
                    AssetId = 1, 
                    EmployeeId = 2, 
                    TicketStatusId = 2, 
                    PriorityId = 3, 
                    ResolutionId = 1, 
                    Title = "Laptop overheating",
                    Descriptoin = "Device gets extremely hot during use", 
                    Comments = "Thermal diagnostics underway",
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 2,
                    AssetId = 4, 
                    EmployeeId = 2, 
                    TicketStatusId = 4, 
                    PriorityId = 2, 
                    ResolutionId = 5, 
                    Title = "Monitor flickering",
                    Description = "Screen flickers intermittently", 
                    Comments = "Refresh rate adjusted and issue resolved",
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 3,
                    AssetId = 5, 
                    EmployeeId = 1, 
                    TicketStatusId = 2, 
                    PriorityId = 4, 
                    ResolutionId = 1, 
                    Title = "Network outage", 
                    Description = "Switch intermittently disconnecting", 
                    Comments = "Awaiting maintenance window",
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 4,
                    AssetId = 2, 
                    EmployeeId = 2, 
                    TicketStatusId = 4, 
                    PriorityId = 2, 
                    ResolutionId = 3, 
                    Title = "Keyboard not responding",
                    Description = "Several keys stopped functioning", 
                    Comments = "Keyboard hardware repaired",
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 5,
                    AssetId = 3, 
                    EmployeeId = 1, 
                    TicketStatusId = 1, 
                    PriorityId = 1, 
                    ResolutionId = 1, 
                    Title = "Software installation request",
                    Description = "User requires Visual Studio installation", 
                    Comments = "Pending approval",
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                }
            );


        builder.OwnsOne(e => e.ActivePeriod, ap =>
        {
            ap.Property(p => p.start).HasColumnName("CreationDate").IsRequired();
            ap.Property(p => p.end).HasColumnName("ClosedDate");

            ap.HasData(
                new
                {
                    SupportTicketId = 1,
                    start = new DateOnly(2024, 6, 1),
                    end = (DateOnly?)null
                },
                new
                {
                    SupportTicketId = 2,
                    start = new DateOnly(2024, 5, 10),
                    end = new DateOnly(2024, 5, 12)
                },
                new
                {
                    SupportTicketId = 3,
                    start = new DateOnly(2024, 6, 15),
                    end = (DateOnly?)null
                },
                new
                {
                    SupportTicketId = 4,
                    start = new DateOnly(2024, 4, 5),
                    end = new DateOnly(2024, 4, 6)
                },
                new
                {
                    SupportTicketId = 5,
                    start = new DateOnly(2024, 6, 20),
                    end = (DateOnly?)null
                });
        });
    }
}
