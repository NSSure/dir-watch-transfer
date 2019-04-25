using DirWatchTransfer.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DirWatchTransfer.DB.Config
{
    public class SymbolicLinkConfig : IEntityTypeConfiguration<SymbolicLink>
    {
        public void Configure(EntityTypeBuilder<SymbolicLink> builder)
        {
            builder.ToTable(nameof(SymbolicLink));

            builder.HasKey(p => p.ID);

            builder.Property(p => p.Name);
            builder.Property(p => p.Source);
            builder.Property(p => p.Target);
        }
    }
}
