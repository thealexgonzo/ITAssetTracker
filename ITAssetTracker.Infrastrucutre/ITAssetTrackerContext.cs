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

        modelBuilder.Entity<Role>().HasData
            (
                new Role("Admin"),
                new Role("IT Support"),
                new Role("Manager"),
                new Role("Employee")
            );

        modelBuilder.Entity<TicketStatus>().HasData
            (
                new TicketStatus("Open"),
                new TicketStatus("In Progress"),
                new TicketStatus("Resolved"),
                new TicketStatus("Closed")
            );

        modelBuilder.Entity<Priority>().HasData
            (
                new Priority("Low"),
                new Priority("Medium"),
                new Priority("High"),
                new Priority("Critical")
            );

        modelBuilder.Entity<Resolution>().HasData
            (
                new Resolution("Unresolved"),
                new Resolution("Resolved"),
                new Resolution("Repaired"),
                new Resolution("Replaced"),
                new Resolution("Configuration Changed"),
                new Resolution("Software Updated"),
                new Resolution("User Error"),
                new Resolution("No Fault Found")
            );

        modelBuilder.Entity<User>().HasData
            (
                new User("admin", "hash_admin", 1),
                new User("itsupport1", "hash_support", 2),
                new User("manager1", "hash_manager", 3),
                new User("jsmith", "hash_jsmith", 4),
                new User("sjohnson", "hash_sjohnson", 4)
            );

        modelBuilder.Entity<Category>().HasData
            (
                new Category("Hardware"),
                new Category("Software"),
                new Category("Networking"),
                new Category("Mobile Devices")
            );

        modelBuilder.Entity<Manufacturer>().HasData
            (
                new Manufacturer("Dell"),
                new Manufacturer("Lenovo"),
                new Manufacturer("Apple"),
                new Manufacturer("HP"),
                new Manufacturer("Microsoft"),
                new Manufacturer("Cisco"),
                new Manufacturer("Samsung")
            );

        modelBuilder.Entity<AssetType>().HasData
            (
                new AssetType("Laptop", 1),
                new AssetType("Desktop", 1),
                new AssetType("Monitor", 1),
                new AssetType("Server", 1),
                new AssetType("Operating System", 2),
                new AssetType("Productivity Software", 2),
                new AssetType("Router", 3),
                new AssetType("Switch", 3),
                new AssetType("Smartphone", 4),
                new AssetType( "Tablet", 4)
            );

        modelBuilder.Entity<AssetProduct>().HasData
            (
                new AssetProduct("Latitude 5420", 1, 1 ),
                new AssetProduct("ThinkPad X1 Carbon", 2, 1),
                new AssetProduct("MacBook Pro 16", 3, 1),
                new AssetProduct("EliteDesk 800", 4, 2),
                new AssetProduct("UltraSharp 27 Monitor", 1, 3),
                new AssetProduct("PowerEdge R740", 1, 4),
                new AssetProduct("Windows 11 Pro", 5, 5),
                new AssetProduct("Microsoft 365 Business", 5, 6),
                new AssetProduct("Cisco Catalyst 9300", 6, 8),
                new AssetProduct("Galaxy Tab S8", 7, 10)
            );

        modelBuilder.Entity<Asset>().HasData
            (
                new Asset("10001", "Dell Latitude Laptop", 1, 2, 1200, "London Office", "DL5420-ABC123", new DateOnly(2023, 1, 10), new DateOnly(2026, 1, 10), "Primary developer laptop"),
                new Asset("10002", "ThinkPad X1", 2, 2, 1400, "Finance Office", "TPX1-DEF456", new DateOnly(2023, 3, 12), new DateOnly(2026, 3, 12), "Finance department laptop"),
                new Asset("10003", "MacBook Pro", 3, 1, 2400, "IT Storage", "MBP-GHI789", new DateOnly(2024, 1, 20), new DateOnly(2027, 1, 20), "Spare executive laptop"),
                new Asset("10004", "Dell Monitor", 5, 2, 350, "London Office", "MON-XYZ111", new DateOnly(2023, 2, 1), new DateOnly(2026, 2, 1), "27 inch monitor"),
                new Asset("10005", "Cisco Switch", 9, 3, 5000, "Server Room", "CSC-9300-222", new DateOnly(2022, 5, 1), new DateOnly(2027, 5, 1), "Core network switch")
            );

        modelBuilder.Entity<AssetAssignment>().HasData
            (
                new AssetAssignment(1, 4, new DateRange(new DateOnly(2024, 1, 5))),
                new AssetAssignment(2, 3, new DateRange(new DateOnly(2024, 2, 10))),
                new AssetAssignment(4, 4, new DateRange(new DateOnly(2024, 1, 5))),
                new AssetAssignment(1, 2, new DateRange(new DateOnly(2023, 1, 1), new DateOnly(2024, 1, 4)))
            );

        modelBuilder.Entity<AssetStatus>().HasData
            (
                new AssetStatus("Available"),
                new AssetStatus("Assigned"),
                new AssetStatus("In Repair"),
                new AssetStatus("Retired"),
                new AssetStatus("Disposed")
            );

        modelBuilder.Entity<Employee>().HasData
            (
                new Employee(1, "System Administrator", "Alex", "Beker", new DateOnly(1988, 5, 12), new Email("alex.admin@company.com"), new Phone("07111111111"), new DateRange(new DateOnly(2018, 1, 10)), 1),
                new Employee(2, "IT Support Technician", "Michael", "Davis", new DateOnly(1992, 8, 20), new Email ("michael.davis@company.com"), new Phone("07222222222"), new DateRange(new DateOnly(2021, 6, 1)), 1),
                new Employee(3, "Finance Manager", "Emily", "Brown", new DateOnly(1985, 3, 14), new Email("emily.brown@company.com"), new Phone("07333333333"), new DateRange(new DateOnly(2017, 2, 15)), 2),
                new Employee(4, "Software Engineer", "John", "Smith", new DateOnly(1991, 11, 3),new Email("john.smith@company.com"), new Phone("07444444444"), new DateRange(new DateOnly(2020, 9, 1)), 1),
                new Employee(5, "HR Coordinator", "Sarah", "Johnson", new DateOnly(1994, 1, 25),new Email("sarah.johnson@company.com"), new Phone("07555555555"), new DateRange(new DateOnly(2022, 3, 10)), 4)
            );

        modelBuilder.Entity<Department>().HasData
            (
                new Department("IT"),
                new Department("Finance"),
                new Department("Operations"),
                new Department("Human Resources")
            );

        modelBuilder.Entity<SupportTicket>().HasData
            (
                new SupportTicket(1, 2, 2, 3, 1, "Laptop overheating", new DateRange(new DateOnly(2024, 6, 1), null), "Device gets extremely hot during use", "Thermal diagnostics underway"),
                new SupportTicket(4, 2, 4, 2, 5, "Monitor flickering", new DateRange(new DateOnly(2024, 5, 10), new DateOnly(2024, 5, 12)), "Screen flickers intermittently", "Refresh rate adjusted and issue resolved"),
                new SupportTicket(5, 1, 2, 4, 1, "Network outage", new DateRange(new DateOnly(2024, 6, 15), null)), "Switch intermittently disconnecting", "Awaiting maintenance window",
                new SupportTicket(2, 2, 4, 2, 3, "Keyboard not responding", new DateRange(new DateOnly(2024, 4, 5), new DateOnly(2024, 4, 6)), "Several keys stopped functioning", "Keyboard hardware repaired"),
                new SupportTicket(3, 1, 1, 1, 1, "Software installation request", new DateRange(new DateOnly(2024, 6, 20), null), "User requires Visual Studio installation", "Pending approval")
            );
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