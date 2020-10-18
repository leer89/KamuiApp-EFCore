using System;
using KakashiApp.Data;
using KakashiApp.Domain;
using System.Linq;

namespace ConsoleApp
{
    internal class Program
    {
        private static NinjaContext context = new NinjaContext();

        private static void Main(string[] args)
        {
            context.Database.EnsureCreated(); // read provider and connection string defined in context class
            GetNinjas("Before Add: "); // gets all ninjas in database
            AddNinja(); // add ninja
            GetNinjas("After Add: "); // get ninja that was just added
            Console.Write("Press any key...");
            Console.ReadKey();
        }

        private static void AddNinja()
        {
            var ninja = new Ninja { Name = "Naruto" };
            context.Ninjas.Add(ninja); // in-memory collection of ninjas
            context.SaveChanges(); // save data to database 
        }

        private static void GetNinjas(string text)
        {
            var ninjas = context.Ninjas.ToList(); // tolist linq method forces method to execute and return objects
            Console.WriteLine($"{text}: Ninja count is {ninjas.Count}");
            foreach (var ninja in ninjas) 
            {
                Console.WriteLine(ninja.Name);
            }
        }
    }
}
