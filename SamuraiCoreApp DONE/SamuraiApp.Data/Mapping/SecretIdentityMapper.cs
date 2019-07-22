using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SamuraiApp.Domain;

namespace SamuraiApp.Data.Mapping
{
    public class SecretIdentityMapper : IEntityTypeConfiguration<SecretIdentity>
    {
        public void Configure(EntityTypeBuilder<SecretIdentity> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.RealName)
                .HasMaxLength(40);
        }
    }
}
