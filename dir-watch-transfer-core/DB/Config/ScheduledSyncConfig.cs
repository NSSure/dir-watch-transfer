using DirWatchTransfer.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DirWatchTransfer.Core.DB.Config
{
    public class ScheduledSyncConfig : IEntityTypeConfiguration<ScheduledSync>
    {
        public void Configure(EntityTypeBuilder<ScheduledSync> builder)
        {
            builder.HasKey(p => p.ID);

            builder.Property(p => p.SymbolicLinkID);
            builder.Property(p => p.Enabled);
            builder.Property(p => p.LastSync);
            builder.Property(p => p.Interval);
        }
    }
}
