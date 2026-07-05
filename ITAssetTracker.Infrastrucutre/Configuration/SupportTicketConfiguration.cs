using ITAssetTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Persistence.Configuration
{
    public class SupportTicketConfiguration : IEntityTypeConfiguration<SupportTicket>
    {
        public void Configure(EntityTypeBuilder<SupportTicket> builder)
        {
            builder.Property(e => e.ActivePeriod.start).IsRequired();
            builder.Property(e => e.Title).IsRequired().HasMaxLength(300);
            builder.HasOne(e => e.TicketStatus).WithMany(e => e.SupportTickets).HasForeignKey(e => e.TicketStatusId);
            builder.HasOne(e => e.Priority).WithMany(e => e.SupportTickets).HasForeignKey(e => e.PriorityId);
            builder.HasOne(e => e.Resolution).WithMany(e => e.SupportTickets).HasForeignKey(e => e.ResolutionId);
        }
    }
}
