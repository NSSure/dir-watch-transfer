using dir_watch_transfer_web.DB.Config;
using dir_watch_transfer_web.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace dir_watch_transfer_web.DB
{
    public class DirWatchTransferContext : DbContext
    {
        public DbSet<SymbolicLink> SymbolicLink { get; set; }

        protected async override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=DirWatchTransferContext");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new SymbolicLinkConfig());
        }
    }
}
