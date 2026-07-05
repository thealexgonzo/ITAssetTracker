using ITAssetTracker.Domain.Common;
using ITAssetTracker.Domain.Entities;
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

        modelBuilder.Entity<Role>().HasData
            (
                new Role
                {

                }
            );

        modelBuilder.Entity<TicketStatus>().HasData
            (
                new TicketStatus
                {

                }
            );

        modelBuilder.Entity<Priority>().HasData
            (
                new Priority
                {

                }
            );

        modelBuilder.Entity<Resolution>().HasData
            (
                new Resolution
                {

                }
            );

        modelBuilder.Entity<User>().HasData
            (
                new User
                {

                }
            );

        modelBuilder.Entity<Category>().HasData
            (
                new Category
                {

                }
            );

        modelBuilder.Entity<Manufacturer>().HasData
            (
                new Manufacturer
                {
                    
                }
            );

        modelBuilder.Entity<AssetType>().HasData
            (
                new AssetType
                {

                }   
            );

        modelBuilder.Entity<AssetProduct>().HasData
            (
                new AssetProduct
                {

                }
            );

        modelBuilder.Entity<Asset>().HasData
            (
                new Asset
                {
                    
                },
                new Asset
                {

                }
            );

        modelBuilder.Entity<AssetAssignment>().HasData
            (
                new AssetAssignment
                {

                }
            );

        modelBuilder.Entity<AssetStatus>().HasData
            (
                new AssetStatus
                {

                }
            );

        modelBuilder.Entity<Employee>().HasData
            (
                new Employee
                {

                }
            );

        modelBuilder.Entity<Department>().HasData
            (
                new Department
                {

                }
            );

        modelBuilder.Entity<SupportTicket>().HasData
            (
                new SupportTicket
                {


                }
            );
    }

    // All entities that inherit from AuditableEntity are in here - when it's saved or modified
    // NOTE: All entities may need to inherit from AuditableEntity
    // NOTE: Should the user editing and updated also be added here?
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach(var entry in ChangeTracker.Entries<AuditableEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedDate = DateTime.Now;
                    break;
                case EntityState.Modified:
                    entry.Entity.LastModifiedDate = DateTime.Now;
                    break;
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }
}

