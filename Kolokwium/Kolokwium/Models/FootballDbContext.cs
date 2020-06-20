using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Models
{
    public class FootballDbContext : DbContext
    {
        public DbSet<Championship> Championships { get; set; }
        public DbSet<Championship_Team> Championship_Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Player_Team> Player_Teams { get; set; }
        public DbSet<Team> Teams { get; set; }
        public FootballDbContext()
        {

        }

        public FootballDbContext(DbContextOptions options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
