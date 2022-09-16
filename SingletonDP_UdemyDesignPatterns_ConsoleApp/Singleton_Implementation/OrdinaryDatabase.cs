using MoreLinq;
using SingletonDP_UdemyDesignPatterns_ConsoleApp.Singleton_Implementation.interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SingletonDP_UdemyDesignPatterns_ConsoleApp.Singleton_Implementation
{
    public class OrdinaryDatabase : IDatabase
    {
        private Dictionary<string, int> capitals;
        private OrdinaryDatabase()
        {
            Console.WriteLine("Initializing Database");
            capitals = File.ReadAllLines(
                Path.Combine(
              "UDemy_DesignnPattersAndPrinciples_ConsoleApp\\SingletonDP_UdemyDesignPatterns_ConsoleApp\\Singleton_Implementation",
                                "capitals.txt")
                            )
                            .Batch(2)
                            .ToDictionary(
                             list => list.ElementAt(0).Trim(),
                             list => int.Parse(list.ElementAt(1).Trim()));
        }

        public int GetPopulation(string name)
        {
           return capitals[name];
        }
    }
}
