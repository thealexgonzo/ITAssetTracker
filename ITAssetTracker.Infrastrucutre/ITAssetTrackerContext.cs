using ITAssetTracker.Domain.Common;
using ITAssetTracker.Domain.Entities;
using ITAssetTracker.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace ITAssetTracker.Persistence;

public class ITAssetTrackerContext: DbContext
{
    public ITAssetTrackerContext(DbContextOptions<ITAssetTrackerContext> options) : base(options)
    {
    }

    public DbSet<Asset> Assets { get; set; }
    public DbSet<AssetType> AssetTypes { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Manufacturer> Manufacturers { get; set; }
    public DbSet<AssetProduct> AssetProducts { get; set; }
    public DbSet<Priority> Priorities { get; set; }
    public DbSet<Resolution> Resolutions { get; set; }
    public DbSet<TicketStatus> TicketStatuses { get; set; }
    public DbSet<SupportTicket> SupportTickets { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<AssetStatus> AssetStatuses { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<AssetAssignment> AssetAssignments { get; set; }

    /// <summary>
    /// Set up models by adding constraints, foreign keys, etc
    /// </summary>
    /// <param name="modelBuilder"></param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Searches for all configurations in the assembly and applies them onto the model builder.
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ITAssetTrackerContext).Assembly);
    }

    // All entities that inherit from AuditableEntity are in here - when it's saved or modified)
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach(var entry in ChangeTracker.Entries<AuditableEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedDate = DateTime.Now;
                    // TODO: Need a way to update the current user here as well
                    break;
                case EntityState.Modified:
                    entry.Entity.LastModifiedDate = DateTime.Now;
                    // TODO: Need a way to update the current user here as well
                    break;
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }
}