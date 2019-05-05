using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DirWatchTransfer.Core.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivityHistory",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    EntityID = table.Column<int>(nullable: false),
                    Data = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityHistory", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ScheduledSync",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SymbolicLinkID = table.Column<int>(nullable: false),
                    Enabled = table.Column<bool>(nullable: false),
                    LastSync = table.Column<DateTime>(nullable: false),
                    Interval = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduledSync", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EnableNotifications = table.Column<bool>(nullable: false),
                    EnableNewSymbolicLinkNotifications = table.Column<bool>(nullable: false),
                    EnableNewWatcherNotifications = table.Column<bool>(nullable: false),
                    EnableNewSyncNotifications = table.Column<bool>(nullable: false),
                    EnableWatcherFileSyncsNotifications = table.Column<bool>(nullable: false),
                    EnableForcedDirectoryCopiesNotifications = table.Column<bool>(nullable: false),
                    LogNewSymbolicLinks = table.Column<bool>(nullable: false),
                    LogNewWatchers = table.Column<bool>(nullable: false),
                    LogNewSyncs = table.Column<bool>(nullable: false),
                    LogWatcherFileSyncs = table.Column<bool>(nullable: false),
                    LogForcedDirectoryCopies = table.Column<bool>(nullable: false),
                    LogFilePath = table.Column<string>(nullable: true),
                    LogFileFormat = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SymbolicLink",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Source = table.Column<string>(nullable: true),
                    Target = table.Column<string>(nullable: true),
                    CopyCount = table.Column<int>(nullable: false),
                    AttributeCount = table.Column<int>(nullable: false),
                    FileNameCount = table.Column<int>(nullable: false),
                    DirectoryNameCount = table.Column<int>(nullable: false),
                    SizeCount = table.Column<int>(nullable: false),
                    LastWriteCount = table.Column<int>(nullable: false),
                    LastAccessCount = table.Column<int>(nullable: false),
                    CreationTimeCount = table.Column<int>(nullable: false),
                    SecurityCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SymbolicLink", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Watcher",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SymbolicLinkID = table.Column<int>(nullable: false),
                    Recursive = table.Column<bool>(nullable: false),
                    WatchFileName = table.Column<bool>(nullable: false),
                    WatchDirectoryName = table.Column<bool>(nullable: false),
                    WatchSize = table.Column<bool>(nullable: false),
                    WatchLastWrite = table.Column<bool>(nullable: false),
                    WatchLastAccess = table.Column<bool>(nullable: false),
                    WatchCreationTime = table.Column<bool>(nullable: false),
                    WatchSecurity = table.Column<bool>(nullable: false),
                    AttributeCount = table.Column<int>(nullable: false),
                    CopyCount = table.Column<int>(nullable: false),
                    FileNameCount = table.Column<int>(nullable: false),
                    DirectoryNameCount = table.Column<int>(nullable: false),
                    SizeCount = table.Column<int>(nullable: false),
                    LastWriteCount = table.Column<int>(nullable: false),
                    LastAccessCount = table.Column<int>(nullable: false),
                    CreationTimeCount = table.Column<int>(nullable: false),
                    SecurityCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Watcher", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityHistory");

            migrationBuilder.DropTable(
                name: "ScheduledSync");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "SymbolicLink");

            migrationBuilder.DropTable(
                name: "Watcher");
        }
    }
}
