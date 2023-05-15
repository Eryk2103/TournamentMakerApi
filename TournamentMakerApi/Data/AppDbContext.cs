using Microsoft.EntityFrameworkCore;
using TournamentMakerApi.Models;

namespace TournamentMakerApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<SportCategory> SportCategories { get; set; }
    }
}
