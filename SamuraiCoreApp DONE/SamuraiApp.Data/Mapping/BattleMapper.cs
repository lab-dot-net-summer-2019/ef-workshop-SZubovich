using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SamuraiApp.Domain;

namespace SamuraiApp.Data.Mapping
{
    public class BattleMapper : IEntityTypeConfiguration<Battle>
    {
        public void Configure(EntityTypeBuilder<Battle> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Name)
                .HasMaxLength(120);
        }
    }
}