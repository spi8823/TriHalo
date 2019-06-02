using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;

namespace TriHaloDatabase.Kagami
{
    public class KagamiContext : DbContext
    {
        public DbSet<Individual> Individuals { get; set; }
        public DbSet<Couple> Couples { get; set; }
        public DbSet<Jinja> Jinjas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("Kagami");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
