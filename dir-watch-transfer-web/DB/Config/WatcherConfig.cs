using DirWatchTransfer.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DirWatchTransfer.DB.Config
{
    public class WatcherConfig : IEntityTypeConfiguration<Watcher>
    {
        public void Configure(EntityTypeBuilder<Watcher> builder)
        {
            builder.ToTable(nameof(Watcher));

            builder.HasKey(p => p.ID);

            builder.Property(p => p.SymbolicLinkID);
            builder.Property(p => p.Recursive);
            builder.Property(p => p.WatchFileName).HasDefaultValue(false);
            builder.Property(p => p.WatchDirectoryName).HasDefaultValue(false);
            builder.Property(p => p.WatchSize).HasDefaultValue(false);
            builder.Property(p => p.WatchLastWrite).HasDefaultValue(true);
            builder.Property(p => p.WatchLastAccess).HasDefaultValue(false);
            builder.Property(p => p.WatchCreationTime).HasDefaultValue(false);
            builder.Property(p => p.WatchSecurity).HasDefaultValue(false);

            builder.Ignore(p => p.Monitor);
        }
    }
}
