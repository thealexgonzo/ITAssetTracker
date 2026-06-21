using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITAssetTracker.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssetStatuses",
                columns: table => new
                {
                    AssetStatusId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetStatuses", x => x.AssetStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    ManufacturerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.ManufacturerId);
                });

            migrationBuilder.CreateTable(
                name: "Priorities",
                columns: table => new
                {
                    PriorityId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priorities", x => x.PriorityId);
                });

            migrationBuilder.CreateTable(
                name: "Resolutions",
                columns: table => new
                {
                    ResolutionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resolutions", x => x.ResolutionId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "TicketStatuses",
                columns: table => new
                {
                    TicketStatusId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketStatuses", x => x.TicketStatusId);
                });

            migrationBuilder.CreateTable(
                name: "AssetTypes",
                columns: table => new
                {
                    AssetTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetTypes", x => x.AssetTypeId);
                    table.ForeignKey(
                        name: "FK_AssetTypes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssetProducts",
                columns: table => new
                {
                    AssetProductId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    ManufacturerId = table.Column<int>(type: "INTEGER", nullable: false),
                    AssetTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetProducts", x => x.AssetProductId);
                    table.ForeignKey(
                        name: "FK_AssetProducts_AssetTypes_AssetTypeId",
                        column: x => x.AssetTypeId,
                        principalTable: "AssetTypes",
                        principalColumn: "AssetTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssetProducts_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "ManufacturerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    JobTitle = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    DoB = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    HireDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TerminationDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DepartmentId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    AssetId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tag = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    AssetProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    AssetStatusId = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    SerialNumber = table.Column<string>(type: "TEXT", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    WarrantyExpiryDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.AssetId);
                    table.ForeignKey(
                        name: "FK_Assets_AssetProducts_AssetProductId",
                        column: x => x.AssetProductId,
                        principalTable: "AssetProducts",
                        principalColumn: "AssetProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assets_AssetStatuses_AssetStatusId",
                        column: x => x.AssetStatusId,
                        principalTable: "AssetStatuses",
                        principalColumn: "AssetStatusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssetAssignments",
                columns: table => new
                {
                    AssetAssignmentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AssetId = table.Column<int>(type: "INTEGER", nullable: false),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    AssignedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ReturnedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetAssignments", x => x.AssetAssignmentId);
                    table.ForeignKey(
                        name: "FK_AssetAssignments_Assets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Assets",
                        principalColumn: "AssetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssetAssignments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupportTickets",
                columns: table => new
                {
                    SupportTicketId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AssetId = table.Column<int>(type: "INTEGER", nullable: false),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    TicketStatusId = table.Column<int>(type: "INTEGER", nullable: false),
                    PriorityId = table.Column<int>(type: "INTEGER", nullable: false),
                    ResolutionId = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", maxLength: 300, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Comments = table.Column<string>(type: "TEXT", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ClosedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportTickets", x => x.SupportTicketId);
                    table.ForeignKey(
                        name: "FK_SupportTickets_Assets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Assets",
                        principalColumn: "AssetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupportTickets_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupportTickets_Priorities_PriorityId",
                        column: x => x.PriorityId,
                        principalTable: "Priorities",
                        principalColumn: "PriorityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupportTickets_Resolutions_ResolutionId",
                        column: x => x.ResolutionId,
                        principalTable: "Resolutions",
                        principalColumn: "ResolutionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupportTickets_TicketStatuses_TicketStatusId",
                        column: x => x.TicketStatusId,
                        principalTable: "TicketStatuses",
                        principalColumn: "TicketStatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupportTickets_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "TicketAssignmentHistories",
                columns: table => new
                {
                    TicketAssignmentHistoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SupportTicketId = table.Column<int>(type: "INTEGER", nullable: false),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    AssignedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UnassignedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketAssignmentHistories", x => x.TicketAssignmentHistoryId);
                    table.ForeignKey(
                        name: "FK_TicketAssignmentHistories_SupportTickets_SupportTicketId",
                        column: x => x.SupportTicketId,
                        principalTable: "SupportTickets",
                        principalColumn: "SupportTicketId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssetAssignments_AssetId",
                table: "AssetAssignments",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetAssignments_EmployeeId",
                table: "AssetAssignments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetProducts_AssetTypeId",
                table: "AssetProducts",
                column: "AssetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetProducts_ManufacturerId",
                table: "AssetProducts",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_AssetProductId",
                table: "Assets",
                column: "AssetProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_AssetStatusId",
                table: "Assets",
                column: "AssetStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetTypes_CategoryId",
                table: "AssetTypes",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserId",
                table: "Employees",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SupportTickets_AssetId",
                table: "SupportTickets",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportTickets_EmployeeId",
                table: "SupportTickets",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportTickets_PriorityId",
                table: "SupportTickets",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportTickets_ResolutionId",
                table: "SupportTickets",
                column: "ResolutionId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportTickets_TicketStatusId",
                table: "SupportTickets",
                column: "TicketStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportTickets_UserId",
                table: "SupportTickets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketAssignmentHistories_SupportTicketId",
                table: "TicketAssignmentHistories",
                column: "SupportTicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.InsertData(
    table: "Categories",
    columns: new[] { "CategoryId", "Name" },
    values: new object[,]
    {
        { 1, "Hardware" },
        { 2, "Software" },
        { 3, "Networking" },
        { 4, "Mobile Devices" }
    });

            migrationBuilder.InsertData(
                table: "AssetTypes",
                columns: new[] { "AssetTypeId", "Name", "CategoryId" },
                values: new object[,]
                {
        { 1, "Laptop", 1 },
        { 2, "Desktop", 1 },
        { 3, "Monitor", 1 },
        { 4, "Server", 1 },
        { 5, "Operating System", 2 },
        { 6, "Productivity Software", 2 },
        { 7, "Router", 3 },
        { 8, "Switch", 3 },
        { 9, "Smartphone", 4 },
        { 10, "Tablet", 4 }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "ManufacturerId", "Name" },
                values: new object[,]
                {
        { 1, "Dell" },
        { 2, "Lenovo" },
        { 3, "Apple" },
        { 4, "HP" },
        { 5, "Microsoft" },
        { 6, "Cisco" },
        { 7, "Samsung" }
                });

            migrationBuilder.InsertData(
                table: "AssetStatuses",
                columns: new[] { "AssetStatusId", "Name" },
                values: new object[,]
                {
        { 1, "Available" },
        { 2, "Assigned" },
        { 3, "In Repair" },
        { 4, "Retired" },
        { 5, "Disposed" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Name" },
                values: new object[,]
                {
        { 1, "IT" },
        { 2, "Finance" },
        { 3, "Operations" },
        { 4, "Human Resources" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Name" },
                values: new object[,]
                {
        { 1, "Admin" },
        { 2, "IT Support" },
        { 3, "Manager" },
        { 4, "Employee" }
                });

            migrationBuilder.InsertData(
                table: "TicketStatuses",
                columns: new[] { "TicketStatusId", "Name" },
                values: new object[,]
                {
        { 1, "Open" },
        { 2, "In Progress" },
        { 3, "Resolved" },
        { 4, "Closed" }
                });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "PriorityId", "Name" },
                values: new object[,]
                {
        { 1, "Low" },
        { 2, "Medium" },
        { 3, "High" },
        { 4, "Critical" }
                });

            migrationBuilder.InsertData(
                table: "Resolutions",
                columns: new[] { "ResolutionId", "Name" },
                values: new object[,]
                {
        { 1, "Unresolved" },
        { 2, "Resolved" },
        { 3, "Repaired" },
        { 4, "Replaced" },
        { 5, "Configuration Changed" },
        { 6, "Software Updated" },
        { 7, "User Error" },
        { 8, "No Fault Found" }
                });

            migrationBuilder.InsertData(
                table: "AssetProducts",
                columns: new[] { "AssetProductId", "Name", "ManufacturerId", "AssetTypeId" },
                values: new object[,]
                {
        { 1, "Latitude 5420", 1, 1 },
        { 2, "ThinkPad X1 Carbon", 2, 1 },
        { 3, "MacBook Pro 16", 3, 1 },
        { 4, "EliteDesk 800", 4, 2 },
        { 5, "UltraSharp 27 Monitor", 1, 3 },
        { 6, "PowerEdge R740", 1, 4 },
        { 7, "Windows 11 Pro", 5, 5 },
        { 8, "Microsoft 365 Business", 5, 6 },
        { 9, "Cisco Catalyst 9300", 6, 8 },
        { 10, "Galaxy Tab S8", 7, 10 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "UserName", "PasswordHash", "RoleId" },
                values: new object[,]
                {
        { 1, "admin", "hash_admin", 1 },
        { 2, "itsupport1", "hash_support", 2 },
        { 3, "manager1", "hash_manager", 3 },
        { 4, "jsmith", "hash_jsmith", 4 },
        { 5, "sjohnson", "hash_sjohnson", 4 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[]
                {
        "EmployeeId", "UserId", "JobTitle", "FirstName", "LastName",
        "DepartmentId", "DoB", "Email", "Phone", "HireDate", "TerminationDate"
                },
                values: new object[,]
                {
        { 1, 1, "System Administrator", "Alex", "Admin", 1, new DateTime(1988, 5, 12), "alex.admin@company.com", "07111111111", new DateTime(2018, 1, 10), null },
        { 2, 2, "IT Support Technician", "Michael", "Davis", 1, new DateTime(1992, 8, 20), "michael.davis@company.com", "07222222222", new DateTime(2021, 6, 1), null },
        { 3, 3, "Finance Manager", "Emily", "Brown", 2, new DateTime(1985, 3, 14), "emily.brown@company.com", "07333333333", new DateTime(2017, 2, 15), null },
        { 4, 4, "Software Engineer", "John", "Smith", 3, new DateTime(1991, 11, 3), "john.smith@company.com", "07444444444", new DateTime(2020, 9, 1), null },
        { 5, 5, "HR Coordinator", "Sarah", "Johnson", 4, new DateTime(1994, 1, 25), "sarah.johnson@company.com", "07555555555", new DateTime(2022, 3, 10), null }
                });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[]
                {
        "AssetId", "Tag", "Name", "AssetProductId", "AssetStatusId",
        "Price", "Location", "Description", "SerialNumber",
        "PurchaseDate", "WarrantyExpiryDate"
                },
                values: new object[,]
                {
        { 1, 10001, "Dell Latitude Laptop", 1, 2, 1200, "London Office", "Primary developer laptop", "DL5420-ABC123", new DateTime(2023, 1, 10), new DateTime(2026, 1, 10) },
        { 2, 10002, "ThinkPad X1", 2, 2, 1400, "Finance Office", "Finance department laptop", "TPX1-DEF456", new DateTime(2023, 3, 12), new DateTime(2026, 3, 12) },
        { 3, 10003, "MacBook Pro", 3, 1, 2400, "IT Storage", "Spare executive laptop", "MBP-GHI789", new DateTime(2024, 1, 20), new DateTime(2027, 1, 20) },
        { 4, 10004, "Dell Monitor", 5, 2, 350, "London Office", "27 inch monitor", "MON-XYZ111", new DateTime(2023, 2, 1), new DateTime(2026, 2, 1) },
        { 5, 10005, "Cisco Switch", 9, 3, 5000, "Server Room", "Core network switch", "CSC-9300-222", new DateTime(2022, 5, 1), new DateTime(2027, 5, 1) }
                });

            migrationBuilder.InsertData(
                table: "AssetAssignments",
                columns: new[] { "AssetAssignmentId", "AssetId", "EmployeeId", "AssignedDate", "ReturnedDate" },
                values: new object[,]
                {
        { 1, 1, 4, new DateTime(2024, 1, 5), null },
        { 2, 2, 3, new DateTime(2024, 2, 10), null },
        { 3, 4, 4, new DateTime(2024, 1, 5), null },
        { 4, 1, 2, new DateTime(2023, 1, 1), new DateTime(2024, 1, 4) }
                });

            migrationBuilder.InsertData(
                table: "SupportTickets",
                columns: new[]
                {
        "SupportTicketId", "AssetId", "EmployeeId", "TicketStatusId",
        "PriorityId", "ResolutionId", "Title", "Description",
        "Comments", "CreationDate", "ClosedDate"
                },
                values: new object[,]
                {
        { 1, 1, 2, 2, 3, 1, "Laptop overheating", "Device gets extremely hot during use", "Thermal diagnostics underway", new DateTime(2024, 6, 1), null },
        { 2, 4, 2, 4, 2, 5, "Monitor flickering", "Screen flickers intermittently", "Refresh rate adjusted and issue resolved", new DateTime(2024, 5, 10), new DateTime(2024, 5, 12) },
        { 3, 5, 1, 2, 4, 1, "Network outage", "Switch intermittently disconnecting", "Awaiting maintenance window", new DateTime(2024, 6, 15), null },
        { 4, 2, 2, 4, 2, 3, "Keyboard not responding", "Several keys stopped functioning", "Keyboard hardware repaired", new DateTime(2024, 4, 5), new DateTime(2024, 4, 6) },
        { 5, 3, 1, 1, 1, 1, "Software installation request", "User requires Visual Studio installation", "Pending approval", new DateTime(2024, 6, 20), null }
                });

            migrationBuilder.InsertData(
                table: "TicketAssignmentHistories",
                columns: new[]
                {
        "TicketAssignmentHistoryId", "SupportTicketId", "EmployeeId",
        "AssignedDate", "UnassignedDate"
                },
                values: new object[,]
                {
        { 1, 1, 1, new DateTime(2024, 6, 1), new DateTime(2024, 6, 2) },
        { 2, 1, 2, new DateTime(2024, 6, 2), null },
        { 3, 2, 2, new DateTime(2024, 5, 10), new DateTime(2024, 5, 12) },
        { 4, 3, 1, new DateTime(2024, 6, 15), null },
        { 5, 4, 2, new DateTime(2024, 4, 5), new DateTime(2024, 4, 6) },
        { 6, 5, 1, new DateTime(2024, 6, 20), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetAssignments");

            migrationBuilder.DropTable(
                name: "TicketAssignmentHistories");

            migrationBuilder.DropTable(
                name: "SupportTickets");

            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Priorities");

            migrationBuilder.DropTable(
                name: "Resolutions");

            migrationBuilder.DropTable(
                name: "TicketStatuses");

            migrationBuilder.DropTable(
                name: "AssetProducts");

            migrationBuilder.DropTable(
                name: "AssetStatuses");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "AssetTypes");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
