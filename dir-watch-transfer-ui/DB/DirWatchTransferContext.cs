using dir_watch_transfer_ui.DB.Config;
using dir_watch_transfer_ui.Model;
using SQLite.CodeFirst;
using System.Data.Entity;

namespace dir_watch_transfer_ui.DB
{
    public class DirWatchTransferContext : DbContext
    {
        public DbSet<SymbolicLink> SymbolicLink { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SqliteDropCreateDatabaseAlways<DirWatchTransferContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);

            modelBuilder.Configurations.Add(new SymbolicLinkConfig());
        }
    }
}
