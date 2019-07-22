using Microsoft.EntityFrameworkCore;
using SamuraiApp.Domain;
using SamuraiApp.Data.Mapping;

namespace SamuraiApp.Data
{
    public class SamuraiContext:DbContext
    {
        public SamuraiContext()
        {
        }

        public SamuraiContext(DbContextOptions<SamuraiContext> options)
            : base(options)
        { }        

        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Battle> Battles { get; set; }
        public DbSet<Clan> Clans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BattleMapper());
            modelBuilder.ApplyConfiguration(new ClanMapper());
            modelBuilder.ApplyConfiguration(new SamuraiMapper());
            modelBuilder.ApplyConfiguration(new SamuraiBattleMapper());
            modelBuilder.ApplyConfiguration(new SecretIdentityMapper());
            modelBuilder.ApplyConfiguration(new QuoteMapper());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(
                 "Server=(localdb)\\MSSQLLocalDB;Database=SamuraiAppDataCore;Trusted_Connection=True;", b => b.MigrationsAssembly("SamuraiApp.Data"));
        }
    }
}
