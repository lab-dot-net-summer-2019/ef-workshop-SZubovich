using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SamuraiApp.Domain;

namespace SamuraiApp.Data.Mapping
{
    public class ClanMapper : IEntityTypeConfiguration<Clan>
    {
        public void Configure(EntityTypeBuilder<Clan> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("ClanIn");

            builder.Property(c => c.Name)
                .HasMaxLength(30);
            
            builder
                .HasMany(c => c.Samurais)
                .WithOne(s => s.Clan)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(s => s.ClanId);
        }
    }
}
