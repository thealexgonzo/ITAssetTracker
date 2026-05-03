using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITAssetTracker.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Statuses",
                columns: table => new
                {
                    StatusId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.StatusId);
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
                name: "Models",
                columns: table => new
                {
                    ModelId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    ManufacturerId = table.Column<int>(type: "INTEGER", nullable: false),
                    AssetTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.ModelId);
                    table.ForeignKey(
                        name: "FK_Models_AssetTypes_AssetTypeId",
                        column: x => x.AssetTypeId,
                        principalTable: "AssetTypes",
                        principalColumn: "AssetTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Models_Manufacturers_ManufacturerId",
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
                    TerminationDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
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
                    ModelId = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.AssetId);
                    table.ForeignKey(
                        name: "FK_Assets_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "ModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssetAssignment",
                columns: table => new
                {
                    AssetAssignmentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AssetId = table.Column<int>(type: "INTEGER", nullable: false),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    AssignmentDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetAssignment", x => x.AssetAssignmentId);
                    table.ForeignKey(
                        name: "FK_AssetAssignment_Assets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Assets",
                        principalColumn: "AssetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssetAssignment_Employees_EmployeeId",
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
                    AssetAssignmentId = table.Column<int>(type: "INTEGER", nullable: false),
                    StatusId = table.Column<int>(type: "INTEGER", nullable: false),
                    PriorityId = table.Column<int>(type: "INTEGER", nullable: false),
                    ResolutionId = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", maxLength: 300, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Comments = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CloseDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportTickets", x => x.SupportTicketId);
                    table.ForeignKey(
                        name: "FK_SupportTickets_AssetAssignment_AssetAssignmentId",
                        column: x => x.AssetAssignmentId,
                        principalTable: "AssetAssignment",
                        principalColumn: "AssetAssignmentId",
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
                        name: "FK_SupportTickets_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupportTickets_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssetAssignment_AssetId",
                table: "AssetAssignment",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetAssignment_EmployeeId",
                table: "AssetAssignment",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_ModelId",
                table: "Assets",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetTypes_CategoryId",
                table: "AssetTypes",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserId",
                table: "Employees",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Models_AssetTypeId",
                table: "Models",
                column: "AssetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_ManufacturerId",
                table: "Models",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportTickets_AssetAssignmentId",
                table: "SupportTickets",
                column: "AssetAssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportTickets_PriorityId",
                table: "SupportTickets",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportTickets_ResolutionId",
                table: "SupportTickets",
                column: "ResolutionId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportTickets_StatusId",
                table: "SupportTickets",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportTickets_UserId",
                table: "SupportTickets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    {1, "Hardware"},
                    {2, "Software"},
                    {3, "Networking"},
                    {4, "Peripherals"},
                    {5, "Mobile Devices"},
                    {6, "Infrastructure"}
            });

            migrationBuilder.InsertData(
                table: "AssetTypes",
                columns: new[] { "AssetTypeId", "Name", "CategoryId" },
                values: new object[,]
                {
                    {1, "Laptop", 1},
                    {2, "Desktop", 1},
                    {3, "Server", 1},
                    {4, "Operating System", 2},
                    {5, "Application Software", 2},
                    {6, "Router", 3},
                    {7, "Switch", 3},
                    {8, "Firewall", 3},
                    {9, "Monitor", 4},
                    {10, "Keyboard", 4},
                    {11, "Mouse", 4},
                    {12, "Printer", 4},
                    {13, "Smartphone", 5},
                    {14, "Tablet", 5},
                    {15, "Rack", 6},
                    {16, "Power Supply Unit", 6}
            });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "ManufacturerId", "Name" },
                values: new object[,]
                {
                {1, "Dell"},
                {2, "HP"},
                {3, "Lenovo"},
                {4, "Apple"},
                {5, "Microsoft"},
                {6, "Cisco"},
                {7, "Asus"},
                {8, "Acer"},
                {9, "Samsung"}
            });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Name" },
                values: new object[,]
                {
                    {1, "Admin"},
                    {2, "IT Support"},
                    {3, "Manager"},
                    {4, "Employee"},
                    {5, "External"}
            });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "StatusId", "Name" },
                values: new object[,]
                {
                    {1, "Open"},
                    {2, "In Progress"},
                    {3, "Pending"},
                    {4, "Resolved"},
                    {5, "Closed"}
            });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "PriorityId", "Name" },
                values: new object[,]
                {
                    {1, "Low"},
                    {2, "Medium"},
                    {3, "High"},
                    {4, "Critical"}
            });

            migrationBuilder.InsertData(
                table: "Resolutions",
                columns: new[] { "ResolutionId", "Name" },
                values: new object[,]
                {
                    {1, "Resolved"},
                    {2, "Replaced"},
                    {3, "Repaired"},
                    {4, "Configuration Changed"},
                    {5, "Software Updated"},
                    {6, "User Error"},
                    {7, "No Fault Found"},
                    {8, "Workaround Provided"}
            });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "UserName", "PasswordHash", "RoleId" },
                values: new object[,]
                {
                    {1, "admin", "hash_admin_123", 1},
                    {2, "itsupport1", "hash_support_123", 2},
                    {3, "manager1", "hash_manager_123", 3},
                    {4, "employee1", "hash_employee_123", 4},
                    {5, "employee2", "hash_employee_456", 4},
                    {6, "external_user1", "hash_external_123", 5},
                    {7, "employee3", "hash_employee_789", 4},
                    {8, "employee4", "hash_employee_101", 4},
                    {9, "employee5", "hash_employee_202", 4}
            });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "UserId", "JobTitle", "FirstName", "LastName", "DoB", "Email", "Phone", "HireDate", "TerminationDate" },
                values: new object[,]
                {
                    {1, 1, "Systems Administrator", "Alex", "Admin", "1987-04-18", "alex.admin@company.com", "07111111111", "2017-02-01", null},
                    {2, 2, "IT Support Technician", "Michael", "Davis", "1992-08-30", "michael.davis@company.com", "07222222222", "2021-06-10", null},
                    {3, 3, "Department Manager", "Emily", "Brown", "1985-02-10", "emily.brown@company.com", "07333333333", "2018-01-20", null},
                    {4, 4, "Software Engineer", "John", "Smith", "1990-05-12", "john.smith@company.com", "07444444444", "2020-03-15", null},
                    {5, 5, "Accountant", "Sarah", "Johnson", "1988-11-23", "sarah.johnson@company.com", "07555555555", "2019-07-01", null},
                    {6, 7, "HR Coordinator", "Laura", "Wilson", "1994-01-09", "laura.wilson@company.com", "07666666666", "2022-09-05", null},
                    {7, 8, "Operations Analyst", "Daniel", "Taylor", "1991-12-03", "daniel.taylor@company.com", "07777777777", "2020-11-12", null},
                    {8, 9, "Finance Assistant", "Rebecca", "Moore", "1996-07-21", "rebecca.moore@company.com", "07888888888", "2023-04-17", "2024-12-20"}
            });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "ModelId", "Name", "ManufacturerId", "AssetTypeId" },
                values: new object[,]
                {
                    {1, "Latitude 5420", 1, 1},
                    {2, "ThinkPad X1 Carbon", 3, 1},
                    {3, "MacBook Pro", 4, 1},
                    {4, "EliteDesk 800", 2, 2},
                    {5, "Inspiron Desktop", 1, 2},
                    {6, "Windows 11 Pro", 5, 4},
                    {7, "Microsoft Office 365", 5, 5},
                    {8, "Cisco Catalyst 9300", 6, 7},
                    {9, "Cisco ISR 4000", 6, 6},
                    {10, "UltraSharp Monitor", 1, 9},
                    {11, "Magic Keyboard", 4, 10},
                    {12, "Galaxy Tab S8", 9, 14}
            });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "AssetId", "Tag", "Name", "ModelId", "Description" },
                values: new object[,]
                {
                    {1, 10001, "Dell Latitude Laptop - John", 1, "Assigned laptop"},
                    {2, 10002, "Lenovo ThinkPad Laptop - Sarah", 2, "Finance laptop"},
                    {3, 10003, "MacBook Pro - Manager", 3, "Executive device"},
                    {4, 10004, "HP EliteDesk Desktop", 4, "Office workstation"},
                    {5, 10005, "Dell Inspiron Desktop", 5, "General use"},
                    {6, 10006, "Windows 11 License", 6, "OS license"},
                    {7, 10007, "Office 365 License", 7, "Software"},
                    {8, 10008, "Cisco Switch", 8, "Network switch"},
                    {9, 10009, "Cisco Router", 9, "Branch router"},
                    {10, 10010, "Dell Monitor", 10, "24 inch"},
                    {11, 10011, "Apple Keyboard", 11, "Wireless"},
                    {12, 10012, "Samsung Tablet", 12, "Mobile device"}
            });

            migrationBuilder.InsertData(
                table: "AssetAssignment",
                columns: new[] { "AssetAssignmentId", "AssetId", "EmployeeId", "AssignmentDate", "ReturnDate" },
                values: new object[,]
                {
                    {1, 1, 4, "2023-01-10", null},
                    {2, 2, 5, "2023-02-15", null},
                    {3, 3, 3, "2023-03-01", null},
                    {4, 4, 1, "2022-06-20", null},
                    {5, 5, 2, "2022-08-10", null},
                    {6, 10, 4, "2023-01-10", null},
                    {7, 11, 4, "2023-01-10", null},
                    {8, 12, 6, "2023-05-12", null},
                    {9, 1, 2, "2022-01-01", "2022-12-31"},
                    {10, 8, 2, "2021-04-01", "2023-01-01"}
            });

            migrationBuilder.InsertData(
                table: "SupportTickets",
                columns: new[] { "SupportTicketId", "AssetAssignmentId", "StatusId", "PriorityId", "ResolutionId", "Title", "Description", "Comments", "UserId", "CreationDate", "CloseDate" },
                values: new object[,]
                {
                    {1, 1, 2, 3, 1, "Laptop overheating", "Gets hot", null, 4, "2024-01-10", null},
                    {2, 2, 4, 2, 3, "Keyboard issue", "Keys fail", "Replaced", 5, "2024-01-05", "2024-01-08"},
                    {3, 3, 5, 1, 1, "Software install", null, "Completed", 3, "2024-01-02", "2024-01-03"},
                    {4, 4, 3, 2, 2, "Slow PC", "Performance issue", "Pending upgrade", 1, "2024-01-12", null},
                    {5, 6, 4, 2, 4, "Monitor flicker", "Display issue", "Settings fixed", 4, "2024-01-06", "2024-01-07"}
            });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupportTickets");

            migrationBuilder.DropTable(
                name: "AssetAssignment");

            migrationBuilder.DropTable(
                name: "Priorities");

            migrationBuilder.DropTable(
                name: "Resolutions");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Models");

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
