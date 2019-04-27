using DirWatchTransfer.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DirWatchTransfer.Core.DB.Config
{
    public class SymbolicLinkConfig : IEntityTypeConfiguration<SymbolicLink>
    {
        public void Configure(EntityTypeBuilder<SymbolicLink> builder)
        {
            builder.HasKey(p => p.ID);

            builder.Property(p => p.Name);
            builder.Property(p => p.Source);
            builder.Property(p => p.Target);
        }
    }
}
