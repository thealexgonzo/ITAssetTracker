using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITAssetTracker.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AssetHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssetHistories",
                columns: table => new
                {
                    AssetHistoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AssetId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "INTEGER", nullable: false),
                    UpdatedByUserId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Comments = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetHistories", x => x.AssetHistoryId);
                    table.ForeignKey(
                        name: "FK_AssetHistories_Assets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Assets",
                        principalColumn: "AssetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssetHistories_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetHistories_Users_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssetHistories_AssetId",
                table: "AssetHistories",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetHistories_CreatedByUserId",
                table: "AssetHistories",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetHistories_UpdatedByUserId",
                table: "AssetHistories",
                column: "UpdatedByUserId");

            migrationBuilder.InsertData(
    table: "AssetHistories",
    columns: new[]
    {
        "AssetHistoryId",
        "AssetId",
        "CreatedByUserId",
        "UpdatedByUserId",
        "CreatedDate",
        "UpdatedDate",
        "Comments"
    },
    values: new object[,]
    {
        {
            1,
            1,
            1,
            1,
            new DateTime(2024, 01, 10, 9, 30, 0),
            new DateTime(2024, 01, 10, 9, 30, 0),
            "Asset record created."
        },
        {
            2,
            1,
            1,
            2,
            new DateTime(2024, 03, 02, 14, 15, 0),
            new DateTime(2024, 03, 05, 10, 45, 0),
            "Status updated from Available to Assigned."
        },
        {
            3,
            1,
            2,
            2,
            new DateTime(2024, 05, 12, 11, 0, 0),
            new DateTime(2024, 05, 12, 11, 0, 0),
            "Assigned to Sarah Johnson in Finance department."
        },
        {
            4,
            2,
            1,
            3,
            new DateTime(2024, 02, 14, 8, 20, 0),
            new DateTime(2024, 02, 18, 16, 30, 0),
            "Serial number corrected after procurement review."
        },
        {
            5,
            2,
            3,
            1,
            new DateTime(2024, 06, 01, 13, 10, 0),
            new DateTime(2024, 06, 03, 9, 0, 0),
            "Warranty expiry updated after supplier confirmation."
        },
        {
            6,
            3,
            2,
            2,
            new DateTime(2024, 04, 18, 15, 45, 0),
            new DateTime(2024, 04, 18, 15, 45, 0),
            "Asset sent for repair due to reported hardware issue."
        },
        {
            7,
            3,
            3,
            1,
            new DateTime(2024, 04, 28, 10, 0, 0),
            new DateTime(2024, 04, 30, 14, 20, 0),
            "Repair completed and asset returned to Available status."
        }
    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetHistories");
        }
    }
}
