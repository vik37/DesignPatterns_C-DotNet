using MoreLinq.Extensions;
using SingletonDP_UdemyDesignPatterns_ConsoleApp.Singleton_Implementation.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SingletonDP_UdemyDesignPatterns_ConsoleApp.Singleton_Implementation
{
    public class SingletonDatabase : IDatabase
    {
        private Dictionary<string, int> capitals;
        private static int instanceCount; //0
        public static int Count => instanceCount;
        private SingletonDatabase()
        {
            instanceCount++;
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
        //private static SingletonDatabase instance = new SingletonDatabase();
        private static Lazy<SingletonDatabase> instance = 
            new Lazy<SingletonDatabase>(() => new SingletonDatabase());
        public static SingletonDatabase Instance => instance.Value;
        public int GetPopulation(string name)
        {
            return capitals[name];
        }

    }
}
