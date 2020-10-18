using Microsoft.EntityFrameworkCore;
using KakashiApp.Domain;

namespace KakashiApp.Data
{
    public class NinjaContext : DbContext // inherits from Microsoft's EFCore DB Context
    {
        public DbSet<Ninja> Ninjas { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Clan> Clans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source = (localdb)\\MSSQLLocalDb; Initial Catalog = KakashiAppData"); // input connection string
        }
    }
}
