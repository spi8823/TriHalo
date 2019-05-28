using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TriHaloDatabase.Databases.Kagami;

namespace TriHaloDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var context = new KagamiContext())
            {
                context.Jinjas.Add(new Jinja { ID = 0, Name = "test" });
                context.SaveChanges();
            }

            using (var context = new KagamiContext())
            {
                foreach(var jinja in context.Jinjas)
                {
                    Console.WriteLine(jinja.Name);
                }
            }
        }
    }
}
