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

            Ignore(a => a.Watcher);
        }
    }
}
