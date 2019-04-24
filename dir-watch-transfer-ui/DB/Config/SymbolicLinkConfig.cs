using dir_watch_transfer_ui.Model;
using System.Data.Entity.ModelConfiguration;

namespace dir_watch_transfer_ui.DB.Config
{
    public class SymbolicLinkConfig : EntityTypeConfiguration<SymbolicLink>
    {
        public SymbolicLinkConfig()
        {
            this.ToTable(nameof(SymbolicLink));

            this.Property(p => p.Source);
            this.Property(p => p.Target);
            this.Property(p => p.Recursive);
            this.Property(p => p.WatchFileName);
            this.Property(p => p.WatchDirectoryName);
            this.Property(p => p.WatchSize);
            this.Property(p => p.WatchLastWrite);
            this.Property(p => p.WatchLastAccess);
            this.Property(p => p.WatchCreationTime);
            this.Property(p => p.WatchSecurity);

            Ignore(a => a.Monitor);
        }
    }
}
