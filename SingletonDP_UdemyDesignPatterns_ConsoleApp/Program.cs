using SingletonDP_UdemyDesignPatterns_ConsoleApp.Singleton_Implementation;
using System;

namespace SingletonDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            // Singleton Implementation
            var db = SingletonDatabase.Instance;
            string city = "Tokyo";
            Console.WriteLine($"{city} has population {db.GetPopulation(city)}");

            #endregion
            Console.ReadLine();
        }
    }
}
