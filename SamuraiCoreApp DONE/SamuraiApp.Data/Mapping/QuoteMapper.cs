using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SamuraiApp.Domain;

namespace SamuraiApp.Data.Mapping
{
    public class QuoteMapper : IEntityTypeConfiguration<Quote>
    {
        public void Configure(EntityTypeBuilder<Quote> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Text)
                .HasColumnName("QuoteText")
                .HasColumnType("nvarchar")
                .HasMaxLength(50);
        }
    }
}
