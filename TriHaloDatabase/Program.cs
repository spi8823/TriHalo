using System;
using Microsoft.EntityFrameworkCore;

namespace TriHaloDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using(var context = new Kagami.KagamiContext())
            {
                //context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                context.Individuals.Add(new Kagami.Individual() { BirthYear = 1200 });
                context.SaveChanges();
            }
        }
    }
}
