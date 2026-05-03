using ITAssetTracker.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace ITAssetTracker.Infrastructure;

public class ITAssetTrackerContext: DbContext
{
    //private string _connectionString;
    public ITAssetTrackerContext(DbContextOptions options) : base(options)
    {
    }

    //private string _connectionString;

    public ITAssetTrackerContext()
    {
        
    }

    //public ITAssetTrackerContext(string connectionString)
    //{
    //    _connectionString = connectionString;
    //}

    public DbSet<Asset> Assets { get; set; }
    public DbSet<AssetType> AssetTypes { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Manufacturer> Manufacturers { get; set; }
    public DbSet<Model> Models { get; set; }
    public DbSet<Priority> Priorities { get; set; }
    public DbSet<Resolution> Resolutions { get; set; }
    public DbSet<Status> Statuses { get; set; }
    public DbSet<SupportTicket> SupportTickets { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseSqlite(_connectionString);
    //}

    /// <summary>
    /// Set up models by adding constraints, foreign keys, etc
    /// </summary>
    /// <param name="modelBuilder"></param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Role>(entity =>
        {
            entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
            entity.HasMany(e => e.Users).WithOne(e => e.Role);
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
            entity.HasMany(e => e.SupporTickets).WithOne(e => e.Status);
        });

        modelBuilder.Entity<Priority>(entity =>
        {
            entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
            entity.HasMany(e => e.SupporTickets).WithOne(e => e.Priority);
        });

        modelBuilder.Entity<Resolution>(entity =>
        {
            entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
            entity.HasMany(e => e.SupporTickets).WithOne(e => e.Resolution);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.UserName).IsRequired().HasMaxLength(100);
            entity.Property(e => e.PasswordHash).IsRequired();
            entity.HasOne(e => e.Role).WithMany(e => e.Users).HasForeignKey(e => e.RoleId);
            entity.HasMany(e => e.SupporTickets).WithOne(e => e.User);
            entity.HasOne(e => e.Employee).WithOne(e => e.User);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
            entity.HasMany(e => e.AssetTypes).WithOne(e => e.Category);
        });

        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
            entity.HasMany(e => e.Models).WithOne(e => e.Manufacturer);
        });

        modelBuilder.Entity<AssetType>(entity =>
        {
            entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
            entity.HasMany(e => e.Models).WithOne(e => e.AssetType);
            entity.HasOne(e => e.Category).WithMany(e => e.AssetTypes).HasForeignKey(e => e.CategoryId);                
        });

        modelBuilder.Entity<Model>(entity =>
        {
            entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
            entity.HasOne(e => e.Manufacturer).WithMany(e => e.Models).HasForeignKey(e => e.ManufacturerId);
            entity.HasOne(e => e.AssetType).WithMany(e => e.Models).HasForeignKey(e => e.AssetTypeId);
        });

        modelBuilder.Entity<Asset>(entity =>
        {
            entity.Property(e => e.Tag).IsRequired();
            entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
            entity.HasOne(e => e.Models).WithMany(e => e.Assets).HasForeignKey(e => e.ModelId);                                                       
        });

        modelBuilder.Entity<AssetAssignment>(entity =>
        {
            entity.HasOne(e => e.Asset).WithMany(e => e.AssetAssignments).HasForeignKey(e => e.AssetId);
            entity.HasOne(e => e.Employee).WithMany(e => e.AssetAssignments).HasForeignKey(e => e.EmployeeId);
            entity.Property(e => e.AssignmentDate).IsRequired();
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.Property(e => e.JobTitle).IsRequired().HasMaxLength(100);
            entity.Property(e => e.FirstName).IsRequired().HasMaxLength(100);
            entity.Property(e => e.LastName).IsRequired().HasMaxLength(100);
            entity.Property(e => e.DoB).IsRequired();
            entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
            entity.Property(e => e.Phone).IsRequired().HasMaxLength(50);
            entity.Property(e => e.HireDate).IsRequired();

            entity.HasOne(e => e.User).WithOne(e => e.Employee).HasForeignKey<Employee>(e => e.UserId);
            entity.HasMany(e => e.AssetAssignments).WithOne(e => e.Employee);            
        });

        modelBuilder.Entity<SupportTicket>(entity =>
        {
            entity.Property(e => e.CreationDate).IsRequired();
            entity.Property(e => e.Title).IsRequired().HasMaxLength(300);

            entity.HasOne(e => e.AssetAssignment).WithMany(e => e.SupporTickets).HasForeignKey(e => e.AssetAssignmentId);
            entity.HasOne(e => e.User).WithMany(e => e.SupporTickets).HasForeignKey(e => e.UserId);
            entity.HasOne(e => e.Status).WithMany(e => e.SupporTickets).HasForeignKey(e => e.StatusId);
            entity.HasOne(e => e.Priority).WithMany(e => e.SupporTickets).HasForeignKey(e => e.PriorityId);
            entity.HasOne(e => e.Resolution).WithMany(e => e.SupporTickets).HasForeignKey(e => e.ResolutionId);
        });
    }
}

