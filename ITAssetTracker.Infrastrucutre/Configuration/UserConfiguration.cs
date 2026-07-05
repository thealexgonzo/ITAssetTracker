using ITAssetTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Persistence.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(e => e.UserName).IsRequired().HasMaxLength(100);
            builder.Property(e => e.PasswordHash).IsRequired();
            builder.HasOne(e => e.Role).WithMany(e => e.Users).HasForeignKey(e => e.RoleId);
            builder.HasOne(e => e.Employee).WithOne(e => e.User);
        }
    }
}
