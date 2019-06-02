using System;

namespace TriHaloDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using(var context = new Kagami.KagamiContext())
            {
                context.Individuals.Add(new Kagami.Individual() { Name = "hoge" });
            }
        }
    }
}
