using SingletonDP_UdemyDesignPatterns_ConsoleApp.AmbientContext;
using SingletonDP_UdemyDesignPatterns_ConsoleApp.Monostate;
using SingletonDP_UdemyDesignPatterns_ConsoleApp.PerThread_Singleton;
using SingletonDP_UdemyDesignPatterns_ConsoleApp.Singleton_Implementation;
using System;
using System.Text;
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
            //var t1 = Task.Factory.StartNew(() =>
            //{
            //    Console.WriteLine("t1: " + PerThreadSingleton.Instance.Id);
            //});
            //var t2 = Task.Factory.StartNew(() =>
            //{
            //    Console.WriteLine("t2: " + PerThreadSingleton.Instance.Id);
            //    Console.WriteLine("t2: " + PerThreadSingleton.Instance.Id);
            //});
            //Task.WaitAll(t1,t2);

            #endregion

            #region
            // Ambient Context
            var house = new Building();
            // ground floor
            using(new BuildingContext(3000))
            {
                //BuildingContext.WallHeight = 3000;
                house.Walls.Add(new Wall(new Point(0, 0), new Point(5000, 0)));
                house.Walls.Add(new Wall(new Point(0, 0), new Point(0, 4000)));
                using(new BuildingContext(3500))
                {
                    // 1st Floor
                    //BuildingContext.WallHeight = 3500;
                    house.Walls.Add(new Wall(new Point(0, 0), new Point(6000, 0)));
                    house.Walls.Add(new Wall(new Point(0, 0), new Point(0, 4000)));
                }                
                // ground floor
                //BuildingContext.WallHeight = 3000;
                house.Walls.Add(new Wall(new Point(5000, 0), new Point(5000, 4000)));
            }
            Console.WriteLine(house);

            #endregion
            Console.ReadLine();
        }
    }
}
