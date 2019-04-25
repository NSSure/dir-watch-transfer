using DirWatchTransfer.DB.Config;
using DirWatchTransfer.Entity;
using Microsoft.EntityFrameworkCore;

namespace DirWatchTransfer.DB
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
        }
    }
}
