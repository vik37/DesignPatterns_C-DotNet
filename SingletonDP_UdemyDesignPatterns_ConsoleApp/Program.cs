using SingletonDP_UdemyDesignPatterns_ConsoleApp.Monostate;
using SingletonDP_UdemyDesignPatterns_ConsoleApp.PerThread_Singleton;
using SingletonDP_UdemyDesignPatterns_ConsoleApp.Singleton_Implementation;
using System;
using System.Threading.Tasks;

namespace SingletonDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            // Singleton Implementation
            //var db = SingletonDatabase.Instance;
            //string city = "Tokyo";
            //Console.WriteLine($"{city} has population {db.GetPopulation(city)}");
            #endregion

            #region
            // Monostate
            //var ceo = new CEO();
            //ceo.Name = "Adam Smith";
            //ceo.Age = 55;

            //var ceo2 = new CEO();
            //Console.WriteLine(ceo2);

            #endregion

            #region
            // Per-Thread -Singleton
            var t1 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("t1: " + PerThreadSingleton.Instance.Id);
            });
            var t2 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("t2: " + PerThreadSingleton.Instance.Id);
                Console.WriteLine("t2: " + PerThreadSingleton.Instance.Id);
            });
            Task.WaitAll(t1,t2);

            #endregion
            Console.ReadLine();
        }
    }
}
