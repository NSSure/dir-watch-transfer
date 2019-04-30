using DirWatchTransfer.Core.DB.Config;
using DirWatchTransfer.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DirWatchTransfer.Core.DB
{
    public class DirWatchTransferContext : DbContext
    {
        public DbSet<SymbolicLink> SymbolicLink { get; set; }
        public DbSet<Watcher> Watcher { get; set; }
        public DbSet<ScheduledSync> ScheduledSync { get; set; }
        public DbSet<ActivityHistory> ActivityHistory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=DirWatchTransferContext");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new SymbolicLinkConfig());
            modelBuilder.ApplyConfiguration(new ActivityHistoryConfig());
            modelBuilder.ApplyConfiguration(new ScheduledSyncConfig());
            modelBuilder.ApplyConfiguration(new WatcherConfig());
        }

        public static void Initialize()
        {
            using (DirWatchTransferContext context = new DirWatchTransferContext())
            {
                List<string> pendingMigrations = context.Database.GetPendingMigrations().ToList();

                if (pendingMigrations.Count != 0)
                {
                    context.Database.Migrate();
                }
            }
        }
    }
}
