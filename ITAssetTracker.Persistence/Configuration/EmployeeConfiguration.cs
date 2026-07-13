using ITAssetTracker.Domain.Entities;
using ITAssetTracker.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Email = ITAssetTracker.Domain.ValueObjects.Email;

namespace ITAssetTracker.Persistence.Configuration;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        // Relationships
        builder.Property(e => e.JobTitle).IsRequired().HasMaxLength(100);
        builder.Property(e => e.FirstName).IsRequired().HasMaxLength(100);
        builder.Property(e => e.LastName).IsRequired().HasMaxLength(100);
        builder.Property(e => e.DoB).IsRequired();
        builder.HasOne(e => e.User).WithOne(e => e.Employee).HasForeignKey<Employee>(e => e.UserId);
        builder.HasMany(e => e.AssetAssignments).WithOne(e => e.Employee);
        builder.HasOne(e => e.Department).WithMany(e => e.Employees).HasForeignKey(e => e.DepartmentId);

        // Seed the owner
        DateTime seedCreatedDate = new DateTime(2026, 12, 7, 0, 0, 0);

        builder.HasData(
            new
            {
                Id = 1,
                UserId = 1,
                JobTitle = "System Administrator",
                FirstName = "Alex",
                MiddleName = string.Empty,
                LastName = "Beker",
                DoB = new DateOnly(1988, 5, 12),
                DepartmentId = 1,
                CreatedDate = seedCreatedDate,
                CreatedBy = "Seed"
            },
            new
            {
                Id = 2,
                UserId = 2,
                JobTitle = "IT Support Technician",
                FirstName = "Michael",
                MiddleName = "Davis",
                LastName = "Beker",
                DoB = new DateOnly(1992, 8, 20),
                DepartmentId = 1,
                CreatedDate = seedCreatedDate,
                CreatedBy = "Seed"
            },
            new
            {
                Id = 3,
                UserId = 3,
                JobTitle = "Finance Manager",
                FirstName = "Emily",
                MiddleName = string.Empty,
                LastName = "Brown", 
                DoB = new DateOnly(1985, 3, 14),
                DepartmentId = 2,
                CreatedDate = seedCreatedDate,
                CreatedBy = "Seed"
            },
            new
            {
                Id = 4,
                UserId = 4, 
                JobTitle = "Software Engineer", 
                FirstName = "John", 
                MiddleName = string.Empty,
                LastName = "Smith", 
                DoB = new DateOnly(1991, 11, 3),
                DepartmentId = 1,
                CreatedDate = seedCreatedDate,
                CreatedBy = "Seed"
            },
            new
            {
                Id = 5,
                UserId = 5, 
                JobTitle = "HR Coordinator", 
                FirstName = "Sarah", 
                MiddleName = string.Empty,
                LastName = "Johnson", 
                DoB = new DateOnly(1994, 1, 25),
                DepartmentId = 4,
                CreatedDate = seedCreatedDate,
                CreatedBy = "Seed"
            });

        // Configure and seed the owned value objects
        builder.OwnsOne(e => e.EmploymentPeriod, ep =>
        {
            ep.Property(p => p.start).HasColumnName("HireDate").IsRequired();
            ep.Property(p => p.end).HasColumnName("TerminationDate");

            ep.HasData(
                new
                {
                    EmployeeId = 1,
                    start = new DateOnly(2018, 1, 10),
                    end = (DateOnly?)null
                },
                new
                {
                    EmployeeId = 2,
                    start = new DateOnly(2021, 6, 1),
                    end = (DateOnly?)null
                },
                new
                {
                    EmployeeId = 3,
                    start = new DateOnly(2017, 2, 15),
                    end = (DateOnly?)null
                },
                new
                {
                    EmployeeId = 4,
                    start = new DateOnly(2020, 9, 1),
                    end = (DateOnly?)null
                },
                new
                {
                    EmployeeId = 5,
                    start = new DateOnly(2022, 3, 10),
                    end = (DateOnly?)null
                });
        });

        builder.OwnsOne(e => e.Email, ep =>
        {
            ep.Property(p => p.Value).HasColumnName("Email").HasMaxLength(100).IsRequired();

            ep.HasData(
                new
                {
                    EmployeeId = 1,
                    Value = "alex.admin@company.com"
                },
                new
                {
                    EmployeeId = 2,
                    Value = "michael.davis@company.com"
                },
                new
                {
                    EmployeeId = 3,
                    Value = "emily.brown@company.com"
                },
                new
                {
                    EmployeeId = 4,
                    Value = "john.smith@company.com"
                },
                new
                {
                    EmployeeId = 5,
                    Value = "sarah.johnson@company.com"
                });
        });

        builder.OwnsOne(e => e.Phone, ep =>
        {
            ep.Property(p => p.Value).HasColumnName("Phone").HasMaxLength(50).IsRequired();

            ep.HasData(
                new
                {
                    EmployeeId = 1,
                    Value = "07111111111"
                },
                new
                {
                    EmployeeId = 2,
                    Value = "07222222222"
                },
                new
                {
                    EmployeeId = 3,
                    Value = "07333333333"
                },
                new
                {
                    EmployeeId = 4,
                    Value = "07444444444"
                },
                new
                {
                    EmployeeId = 5,
                    Value = "07555555555"
                });
        });
    }
}
