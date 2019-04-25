using dir_watch_transfer_web.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dir_watch_transfer_web.DB.Config
{
    public class SymbolicLinkConfig : IEntityTypeConfiguration<SymbolicLink>
    {
        public void Configure(EntityTypeBuilder<SymbolicLink> builder)
        {
            builder.ToTable(nameof(SymbolicLink));

            builder.HasKey(p => p.ID);

            builder.Property(p => p.Source);
            builder.Property(p => p.Target);
            builder.Property(p => p.Recursive);
            builder.Property(p => p.WatchFileName);
            builder.Property(p => p.WatchDirectoryName);
            builder.Property(p => p.WatchSize);
            builder.Property(p => p.WatchLastWrite);
            builder.Property(p => p.WatchLastAccess);
            builder.Property(p => p.WatchCreationTime);
            builder.Property(p => p.WatchSecurity);

            builder.Ignore(a => a.Monitor);
        }
    }
}
