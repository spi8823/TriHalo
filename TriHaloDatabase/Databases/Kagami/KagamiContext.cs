using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace TriHaloDatabase.Databases.Kagami
{
    class KagamiContext : DbContext
    {
        public DbSet<Jinja> Jinjas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = @"server=localhost;database=Kagura;userid=root;pwd=root;sslmode=none;";
            optionsBuilder.UseMySQL(connection);
        }
    }
}
