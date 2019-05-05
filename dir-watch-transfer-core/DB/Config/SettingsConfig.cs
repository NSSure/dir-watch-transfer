using DirWatchTransfer.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DirWatchTransfer.Core.DB.Config
{
    public class SettingsConfig : IEntityTypeConfiguration<Settings>
    {
        public void Configure(EntityTypeBuilder<Settings> builder)
        {
            builder.HasKey(p => p.ID);

            builder.Property(p => p.EnableNotifications);
            builder.Property(p => p.EnableNewSymbolicLinkNotifications);
            builder.Property(p => p.EnableNewWatcherNotifications);
            builder.Property(p => p.EnableNewSyncNotifications);
            builder.Property(p => p.EnableWatcherFileSyncsNotifications);
            builder.Property(p => p.EnableForcedDirectoryCopiesNotifications);
            builder.Property(p => p.LogNewSymbolicLinks);
            builder.Property(p => p.LogNewWatchers);
            builder.Property(p => p.LogNewSyncs);
            builder.Property(p => p.LogWatcherFileSyncs);
            builder.Property(p => p.LogForcedDirectoryCopies);
            builder.Property(p => p.LogFilePath);
            builder.Property(p => p.LogFileFormat);
        }
    }
}
