using DirWatchTransfer.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dir_watch_transfer_web.DB.Config
{
    public class ScheduledSyncConfig : IEntityTypeConfiguration<ScheduledSync>
    {
        public void Configure(EntityTypeBuilder<ScheduledSync> builder)
        {
            builder.ToTable(nameof(ScheduledSync));

            builder.HasKey(p => p.ID);

            builder.Property(p => p.SymbolicLinkID);
            builder.Property(p => p.Enabled).HasDefaultValue(false);
            builder.Property(p => p.LastSync);
            builder.Property(p => p.Interval).HasDefaultValue(60);
        }
    }
}
