using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickAPI.Models
{
    public class DnDContext : DbContext
    {
        public DnDContext(DbContextOptions<DnDContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Monster>().HasOne(m => m.Type);
            modelBuilder.Entity<Monster>().HasOne(m => m.Stats);
            modelBuilder.Entity<Class>();

            modelBuilder.Seed();
        }

        public DbSet<Monster> Monsters { get; set; }
        public DbSet<Stats> Stats { get; set; }
        public DbSet<Types> Types { get; set; }
        public DbSet<Class> Classes { get; set; }



    }
}
