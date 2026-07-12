using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ITAssetTracker.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssetStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Priorities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priorities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Resolutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resolutions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TicketStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssetTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssetTypes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssetProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    ManufacturerId = table.Column<int>(type: "INTEGER", nullable: false),
                    AssetTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssetProducts_AssetTypes_AssetTypeId",
                        column: x => x.AssetTypeId,
                        principalTable: "AssetTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssetProducts_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    JobTitle = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    MiddleName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    DoB = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    HireDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    TerminationDate = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    DepartmentId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tag = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    AssetProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    AssetStatusId = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    SerialNumber = table.Column<string>(type: "TEXT", nullable: false),
                    PurchaseDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    WarrantyExpiryDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assets_AssetProducts_AssetProductId",
                        column: x => x.AssetProductId,
                        principalTable: "AssetProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assets_AssetStatuses_AssetStatusId",
                        column: x => x.AssetStatusId,
                        principalTable: "AssetStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssetAssignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AssetId = table.Column<int>(type: "INTEGER", nullable: false),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    AssignedDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    ReturnedDate = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetAssignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssetAssignments_Assets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssetAssignments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupportTickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AssetId = table.Column<int>(type: "INTEGER", nullable: false),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    TicketStatusId = table.Column<int>(type: "INTEGER", nullable: false),
                    PriorityId = table.Column<int>(type: "INTEGER", nullable: false),
                    ResolutionId = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", maxLength: 300, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Comments = table.Column<string>(type: "TEXT", nullable: true),
                    CreationDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    ClosedDate = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportTickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupportTickets_Assets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupportTickets_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupportTickets_Priorities_PriorityId",
                        column: x => x.PriorityId,
                        principalTable: "Priorities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupportTickets_Resolutions_ResolutionId",
                        column: x => x.ResolutionId,
                        principalTable: "Resolutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupportTickets_TicketStatuses_TicketStatusId",
                        column: x => x.TicketStatusId,
                        principalTable: "TicketStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupportTickets_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AssetStatuses",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 165, DateTimeKind.Utc).AddTicks(9628), null, null, "Available" },
                    { 2, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 166, DateTimeKind.Utc).AddTicks(163), null, null, "Assigned" },
                    { 3, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 166, DateTimeKind.Utc).AddTicks(164), null, null, "In Repair" },
                    { 4, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 166, DateTimeKind.Utc).AddTicks(164), null, null, "Retired" },
                    { 5, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 166, DateTimeKind.Utc).AddTicks(165), null, null, "Disposed" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 167, DateTimeKind.Utc).AddTicks(2720), null, null, "Hardware" },
                    { 2, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 167, DateTimeKind.Utc).AddTicks(2721), null, null, "Software" },
                    { 3, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 167, DateTimeKind.Utc).AddTicks(2722), null, null, "Networking" },
                    { 4, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 167, DateTimeKind.Utc).AddTicks(2722), null, null, "Mobile Devices" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 167, DateTimeKind.Utc).AddTicks(8253), null, null, "IT" },
                    { 2, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 167, DateTimeKind.Utc).AddTicks(8254), null, null, "Finance" },
                    { 3, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 167, DateTimeKind.Utc).AddTicks(8277), null, null, "Operations" },
                    { 4, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 167, DateTimeKind.Utc).AddTicks(8278), null, null, "Human Resources" }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 173, DateTimeKind.Utc).AddTicks(1791), null, null, "Dell" },
                    { 2, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 173, DateTimeKind.Utc).AddTicks(1793), null, null, "Lenovo" },
                    { 3, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 173, DateTimeKind.Utc).AddTicks(1793), null, null, "Apple" },
                    { 4, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 173, DateTimeKind.Utc).AddTicks(1794), null, null, "HP" },
                    { 5, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 173, DateTimeKind.Utc).AddTicks(1794), null, null, "Microsoft" },
                    { 6, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 173, DateTimeKind.Utc).AddTicks(1795), null, null, "Cisco" },
                    { 7, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 173, DateTimeKind.Utc).AddTicks(1795), null, null, "Samsung" }
                });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 173, DateTimeKind.Utc).AddTicks(7297), null, null, "Low" },
                    { 2, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 173, DateTimeKind.Utc).AddTicks(7298), null, null, "Medium" },
                    { 3, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 173, DateTimeKind.Utc).AddTicks(7299), null, null, "High" },
                    { 4, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 173, DateTimeKind.Utc).AddTicks(7299), null, null, "Critical" }
                });

            migrationBuilder.InsertData(
                table: "Resolutions",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 174, DateTimeKind.Utc).AddTicks(3326), null, null, "Unresolved" },
                    { 2, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 174, DateTimeKind.Utc).AddTicks(3327), null, null, "Resolved" },
                    { 3, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 174, DateTimeKind.Utc).AddTicks(3328), null, null, "Repaired" },
                    { 4, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 174, DateTimeKind.Utc).AddTicks(3329), null, null, "Replaced" },
                    { 5, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 174, DateTimeKind.Utc).AddTicks(3352), null, null, "Configuration Changed" },
                    { 6, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 174, DateTimeKind.Utc).AddTicks(3352), null, null, "Software Updated" },
                    { 7, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 174, DateTimeKind.Utc).AddTicks(3353), null, null, "User Error" },
                    { 8, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 174, DateTimeKind.Utc).AddTicks(3354), null, null, "No Fault Found" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 174, DateTimeKind.Utc).AddTicks(9316), null, null, "Admin" },
                    { 2, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 174, DateTimeKind.Utc).AddTicks(9317), null, null, "IT Support" },
                    { 3, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 174, DateTimeKind.Utc).AddTicks(9318), null, null, "Manager" },
                    { 4, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 174, DateTimeKind.Utc).AddTicks(9318), null, null, "Employee" }
                });

            migrationBuilder.InsertData(
                table: "TicketStatuses",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 177, DateTimeKind.Utc).AddTicks(4104), null, null, "Open" },
                    { 2, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 177, DateTimeKind.Utc).AddTicks(4106), null, null, "In Progress" },
                    { 3, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 177, DateTimeKind.Utc).AddTicks(4106), null, null, "Resolved" },
                    { 4, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 177, DateTimeKind.Utc).AddTicks(4107), null, null, "Closed" }
                });

            migrationBuilder.InsertData(
                table: "AssetTypes",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 166, DateTimeKind.Utc).AddTicks(7710), null, null, "Laptop" },
                    { 2, 1, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 166, DateTimeKind.Utc).AddTicks(8483), null, null, "Desktop" },
                    { 3, 1, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 166, DateTimeKind.Utc).AddTicks(8484), null, null, "Monitor" },
                    { 4, 1, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 166, DateTimeKind.Utc).AddTicks(8484), null, null, "Server" },
                    { 5, 2, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 166, DateTimeKind.Utc).AddTicks(8485), null, null, "Operating System" },
                    { 6, 2, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 166, DateTimeKind.Utc).AddTicks(8485), null, null, "Productivity Software" },
                    { 7, 3, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 166, DateTimeKind.Utc).AddTicks(8485), null, null, "Router" },
                    { 8, 3, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 166, DateTimeKind.Utc).AddTicks(8486), null, null, "Switch" },
                    { 9, 4, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 166, DateTimeKind.Utc).AddTicks(8486), null, null, "Smartphone" },
                    { 10, 4, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 166, DateTimeKind.Utc).AddTicks(8487), null, null, "Tablet" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "PasswordHash", "RoleId", "UserName" },
                values: new object[,]
                {
                    { 1, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 178, DateTimeKind.Utc).AddTicks(583), null, null, "hash_admin", 1, "admin" },
                    { 2, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 178, DateTimeKind.Utc).AddTicks(1380), null, null, "hash_support", 2, "itsupport1" },
                    { 3, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 178, DateTimeKind.Utc).AddTicks(1380), null, null, "hash_manager", 3, "manager1" },
                    { 4, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 178, DateTimeKind.Utc).AddTicks(1381), null, null, "hash_jsmith", 4, "jsmith" },
                    { 5, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 178, DateTimeKind.Utc).AddTicks(1381), null, null, "hash_sjohnson", 4, "sjohnson" }
                });

            migrationBuilder.InsertData(
                table: "AssetProducts",
                columns: new[] { "Id", "AssetTypeId", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "ManufacturerId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 164, DateTimeKind.Utc).AddTicks(4804), null, null, 1, "Latitude 5420" },
                    { 2, 1, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 164, DateTimeKind.Utc).AddTicks(5644), null, null, 2, "ThinkPad X1 Carbon" },
                    { 3, 1, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 164, DateTimeKind.Utc).AddTicks(5645), null, null, 3, "MacBook Pro 16" },
                    { 4, 2, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 164, DateTimeKind.Utc).AddTicks(5645), null, null, 4, "EliteDesk 800" },
                    { 5, 3, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 164, DateTimeKind.Utc).AddTicks(5646), null, null, 1, "UltraSharp 27 Monitor" },
                    { 6, 4, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 164, DateTimeKind.Utc).AddTicks(5646), null, null, 1, "PowerEdge R740" },
                    { 7, 5, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 164, DateTimeKind.Utc).AddTicks(5647), null, null, 5, "Windows 11 Pro" },
                    { 8, 6, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 164, DateTimeKind.Utc).AddTicks(5647), null, null, 5, "Microsoft 365 Business" },
                    { 9, 8, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 164, DateTimeKind.Utc).AddTicks(5648), null, null, 6, "Cisco Catalyst 9300" },
                    { 10, 10, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 164, DateTimeKind.Utc).AddTicks(5648), null, null, 7, "Galaxy Tab S8" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DepartmentId", "DoB", "FirstName", "JobTitle", "LastModifiedBy", "LastModifiedDate", "LastName", "MiddleName", "UserId", "TerminationDate", "HireDate", "Email", "Phone" },
                values: new object[,]
                {
                    { 1, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 170, DateTimeKind.Utc).AddTicks(7307), 1, new DateOnly(1988, 5, 12), "Alex", "System Administrator", null, null, "Beker", "", 1, null, new DateOnly(2018, 1, 10), "alex.admin@company.com", "07111111111" },
                    { 2, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 170, DateTimeKind.Utc).AddTicks(8517), 1, new DateOnly(1992, 8, 20), "Michael", "IT Support Technician", null, null, "Beker", "Davis", 2, null, new DateOnly(2021, 6, 1), "michael.davis@company.com", "07222222222" },
                    { 3, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 170, DateTimeKind.Utc).AddTicks(8519), 2, new DateOnly(1985, 3, 14), "Emily", "Finance Manager", null, null, "Brown", "", 3, null, new DateOnly(2017, 2, 15), "emily.brown@company.com", "07333333333" },
                    { 4, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 170, DateTimeKind.Utc).AddTicks(8519), 1, new DateOnly(1991, 11, 3), "John", "Software Engineer", null, null, "Smith", "", 4, null, new DateOnly(2020, 9, 1), "john.smith@company.com", "07444444444" },
                    { 5, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 170, DateTimeKind.Utc).AddTicks(8520), 4, new DateOnly(1994, 1, 25), "Sarah", "HR Coordinator", null, null, "Johnson", "", 5, null, new DateOnly(2022, 3, 10), "sarah.johnson@company.com", "07555555555" }
                });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetProductId", "AssetStatusId", "CreatedBy", "CreatedDate", "Description", "LastModifiedBy", "LastModifiedDate", "Location", "Name", "Price", "PurchaseDate", "SerialNumber", "Tag", "WarrantyExpiryDate" },
                values: new object[,]
                {
                    { 1, 1, 2, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 163, DateTimeKind.Utc).AddTicks(4263), "Primary developer laptop", null, null, "London Office", "Dell Latitude Laptop", 1200m, new DateOnly(2023, 1, 10), "DL5420-ABC123", "10001", new DateOnly(2026, 1, 10) },
                    { 2, 2, 2, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 163, DateTimeKind.Utc).AddTicks(5522), "Finance department laptop", null, null, "Finance Office", "ThinkPad X1", 1400m, new DateOnly(2023, 3, 12), "TPX1-DEF456", "10002", new DateOnly(2026, 3, 12) },
                    { 3, 3, 1, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 163, DateTimeKind.Utc).AddTicks(5524), "Spare executive laptop", null, null, "IT Storage", "MacBook Pro", 2400m, new DateOnly(2024, 1, 20), "MBP-GHI789", "10003", new DateOnly(2027, 1, 20) },
                    { 4, 5, 2, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 163, DateTimeKind.Utc).AddTicks(5524), "27 inch monitor", null, null, "London Office", "Dell Monitor", 350m, new DateOnly(2023, 2, 1), "MON-XYZ111", "10004", new DateOnly(2026, 2, 1) },
                    { 5, 9, 3, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 163, DateTimeKind.Utc).AddTicks(5525), "Core network switch", null, null, "Server Room", "Cisco Switch", 5000m, new DateOnly(2022, 5, 1), "CSC-9300-222", "10005", new DateOnly(2027, 5, 1) }
                });

            migrationBuilder.InsertData(
                table: "AssetAssignments",
                columns: new[] { "Id", "AssetId", "CreatedBy", "CreatedDate", "EmployeeId", "LastModifiedBy", "LastModifiedDate", "ReturnedDate", "AssignedDate" },
                values: new object[,]
                {
                    { 1, 1, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 154, DateTimeKind.Utc).AddTicks(6796), 4, null, null, null, new DateOnly(2024, 1, 5) },
                    { 2, 2, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 154, DateTimeKind.Utc).AddTicks(7645), 3, null, null, null, new DateOnly(2024, 2, 10) },
                    { 3, 4, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 154, DateTimeKind.Utc).AddTicks(7645), 4, null, null, null, new DateOnly(2024, 1, 5) },
                    { 4, 1, "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 154, DateTimeKind.Utc).AddTicks(7646), 2, null, null, new DateOnly(2024, 1, 4), new DateOnly(2023, 1, 1) }
                });

            migrationBuilder.InsertData(
                table: "SupportTickets",
                columns: new[] { "Id", "AssetId", "Comments", "CreatedBy", "CreatedDate", "Description", "EmployeeId", "LastModifiedBy", "LastModifiedDate", "PriorityId", "ResolutionId", "TicketStatusId", "Title", "UserId", "ClosedDate", "CreationDate" },
                values: new object[,]
                {
                    { 1, 1, "Thermal diagnostics underway", "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 176, DateTimeKind.Utc).AddTicks(3725), null, 2, null, null, 3, 1, 2, "Laptop overheating", null, null, new DateOnly(2024, 6, 1) },
                    { 2, 4, "Refresh rate adjusted and issue resolved", "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 176, DateTimeKind.Utc).AddTicks(4638), "Screen flickers intermittently", 2, null, null, 2, 5, 4, "Monitor flickering", null, new DateOnly(2024, 5, 12), new DateOnly(2024, 5, 10) },
                    { 3, 5, "Awaiting maintenance window", "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 176, DateTimeKind.Utc).AddTicks(5238), "Switch intermittently disconnecting", 1, null, null, 4, 1, 2, "Network outage", null, null, new DateOnly(2024, 6, 15) },
                    { 4, 2, "Keyboard hardware repaired", "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 176, DateTimeKind.Utc).AddTicks(5239), "Several keys stopped functioning", 2, null, null, 2, 3, 4, "Keyboard not responding", null, new DateOnly(2024, 4, 6), new DateOnly(2024, 4, 5) },
                    { 5, 3, "Pending approval", "Seed", new DateTime(2026, 7, 12, 13, 7, 28, 176, DateTimeKind.Utc).AddTicks(5240), "User requires Visual Studio installation", 1, null, null, 1, 1, 1, "Software installation request", null, null, new DateOnly(2024, 6, 20) }
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
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetAssignments");

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
