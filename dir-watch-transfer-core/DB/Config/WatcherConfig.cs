using DirWatchTransfer.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DirWatchTransfer.Core.DB.Config
{
    public class WatcherConfig : IEntityTypeConfiguration<Watcher>
    {
        public void Configure(EntityTypeBuilder<Watcher> builder)
        {
            builder.HasKey(p => p.ID);

            builder.Property(p => p.SymbolicLinkID);
            builder.Property(p => p.Recursive);
            builder.Property(p => p.WatchFileName);
            builder.Property(p => p.WatchDirectoryName);
            builder.Property(p => p.WatchSize);
            builder.Property(p => p.WatchLastWrite);
            builder.Property(p => p.WatchLastAccess);
            builder.Property(p => p.WatchCreationTime);
            builder.Property(p => p.WatchSecurity);

            builder.Ignore(p => p.Monitor);
        }
    }
}
