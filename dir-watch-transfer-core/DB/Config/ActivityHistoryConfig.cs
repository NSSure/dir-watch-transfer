using DirWatchTransfer.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DirWatchTransfer.Core.DB.Config
{
    public class ActivityHistoryConfig : IEntityTypeConfiguration<ActivityHistory>
    {
        public void Configure(EntityTypeBuilder<ActivityHistory> builder)
        {
            builder.HasKey(p => p.ID);

            builder.Property(p => p.Title);
            builder.Property(p => p.Description);
            builder.Property(p => p.DateAdded);
        }
    }
}
