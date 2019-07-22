using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SamuraiApp.Domain;

namespace SamuraiApp.Data.Mapping
{
    public class SamuraiMapper : IEntityTypeConfiguration<Samurai>
    {
        public void Configure(EntityTypeBuilder<Samurai> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id)
                .HasColumnName("SamuraiId");

            builder.Property(s => s.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();

            builder
                .HasMany(s => s.Quotes)
                .WithOne(s => s.Samurai)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(s => s.SamuraiId);

            builder
                .HasMany(sb => sb.SamuraiBattles)
                .WithOne(s => s.Samurai)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(s => s.SamuraiId);

            builder
                .HasOne(s => s.SecretIdentity)
                .WithOne(s => s.Samurai)
                .IsRequired();

            builder
                .HasOne(s => s.Clan)
                .WithMany(s => s.Samurais)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(s => s.ClanId);

            builder.Property(s => s.ClanId)
                .HasColumnName("ClanId");
        }
    }
}