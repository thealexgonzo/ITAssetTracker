using ITAssetTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
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

            DateTime seedCreatedDate = new DateTime(2026, 12, 7, 0, 0, 0);

            builder.HasData
            (
                new
                {
                    Id = 1,
                    UserName = "admin", 
                    PasswordHash = "hash_admin", 
                    RoleId = 1,
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 2,
                    UserName = "itsupport1", 
                    PasswordHash = "hash_support",
                    RoleId = 2,
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 3,
                    UserName = "manager1", 
                    PasswordHash = "hash_manager", 
                    RoleId = 3,
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 4,
                    UserName = "jsmith",
                    PasswordHash = "hash_jsmith", 
                    RoleId = 4,
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                },
                new
                {
                    Id = 5,
                    UserName = "sjohnson", 
                    PasswordHash = "hash_sjohnson", 
                    RoleId = 4,
                    CreatedDate = seedCreatedDate,
                    CreatedBy = "Seed"
                }
            );
        }
    }
}
