using ITAssetTracker.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace ITAssetTracker.DataAccess;

public class ITAssetTrackerContext: DbContext
{
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

    /// <summary>
    /// Connect to the database
    /// </summary>
    /// <param name="optionsBuilder"></param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=/Data/ITAssetTrackerDatabase.db");
    }

    /// <summary>
    /// Set up models by adding constraints, foreign keys, etc
    /// </summary>
    /// <param name="modelBuilder"></param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.UserName).IsRequired().HasMaxLength(100);
            entity.Property(e => e.PasswordHash).IsRequired();
            entity
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasMany(e => e.AssetTypes).WithOne(e => e.Category);
        });

        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasMany(e => e.Models).WithOne(e => e.Manufacturer);
        });

        modelBuilder.Entity<AssetType>(entity =>
        {
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasMany(e => e.Models).WithOne(e => e.AssetType);

            entity.HasOne(e => e.Category)
                .WithMany(e => e.AssetTypes)
                .HasForeignKey(e => e.CategoryId);
                
        });

        modelBuilder.Entity<Model>(entity =>
        {
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(e => e.Manufacturer).WithMany(e => e.Models).HasForeignKey(e => e.ManufacturerId);
            entity.HasOne(e => e.AssetType).WithMany(e => e.Models).HasForeignKey(e => e.AssetTypeId);
        });

        modelBuilder.Entity<Asset>(entity =>
        {
            entity.Property(e => e.Tag)
                .IsRequired();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(e => e.Models).WithMany(e => e.Assets).HasForeignKey(e => e.ModelId);                                                       
        });

        modelBuilder.Entity<AssetAssignment>(entity =>
        {
            entity.HasOne(e => e.Asset).WithMany(e => e.AssetAssignments).HasForeignKey(e => e.AssetId);
            entity.HasOne(e => e.Employee).WithMany(e => e.AssetAssignments).HasForeignKey(e => e.EmployeeId);
        });
    }
}
