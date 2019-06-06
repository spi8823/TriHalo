using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.InMemory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace TriHaloDatabase.Kagami
{
    public class KagamiContext : DbContext
    {
        public DbSet<Individual> Individuals { get; set; }
        public DbSet<Couple> Couples { get; set; }
        public DbSet<Jinja> Jinjas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase("Kagami");
            var connection = @"server=192.168.99.100;database=Kagami;userid=root;pwd=root;sslmode=required;";
            optionsBuilder.UseMySQL(connection, options =>
            {
                options.MigrationsHistoryTable("__EFMigrationsHistory");
            });
            base.OnConfiguring(optionsBuilder);
        }
    }
}
