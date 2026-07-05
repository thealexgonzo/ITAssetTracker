using ITAssetTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITAssetTracker.Persistence.Configuration;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.Property(e => e.JobTitle).IsRequired().HasMaxLength(100);
        builder.Property(e => e.FirstName).IsRequired().HasMaxLength(100);
        builder.Property(e => e.LastName).IsRequired().HasMaxLength(100);
        builder.Property(e => e.DoB).IsRequired();
        builder.Property(e => e.Email).IsRequired().HasMaxLength(100);
        builder.Property(e => e.Phone).IsRequired().HasMaxLength(50);
        builder.Property(e => e.EmploymentPeriod.start).IsRequired();
        builder.HasOne(e => e.User).WithOne(e => e.Employee).HasForeignKey<Employee>(e => e.UserId);
        builder.HasMany(e => e.AssetAssignments).WithOne(e => e.Employee);
        builder.HasOne(e => e.Department).WithMany(e => e.Employees).HasForeignKey(e => e.DepartmentId);
    }
}
