using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace TriHaloDatabase.Databases.Kagami
{
    class KagamiContext : DbContext
    {
        public DbSet<Jinja> Jinjas { get; set; }
        public DbSet<Individual> Individuals { get; set; }
        public DbSet<Couple> Couples { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = @"server=192.168.99.100;database=Kagami;userid=root;pwd=root;sslmode=required;";
            optionsBuilder.UseMySQL(connection);
        }
    }
}
