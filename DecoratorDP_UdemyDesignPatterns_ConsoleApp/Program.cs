//using DecoratorDP_UdemyDesignPatterns_ConsoleApp.MultipleInheritanceWithInterfaces;
using DecoratorDP_UdemyDesignPatterns_ConsoleApp.MultipleInheritanceWithDefaultInterface;
using DecoratorDP_UdemyDesignPatterns_ConsoleApp.MultipleInheritanceWithDefaultInterface.Interfacec;
using System;
using System.Data.Common;

namespace DecoratorDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            // DataAdapter-Decorator
            //var d = new Dragon();
            //d.Weight = 200;
            //d.Fly();
            //d.Crowl();           
            #endregion

            #region
            // Multiple Inheritance With Default Interface
            Dragon d = new Dragon() {Age=5 };
            if(d is IBird bird)
            {
                bird.Fly();
            }
            if(d is ILizard lizard)
            {
                lizard.Crawl();
            }
            #endregion
            Console.ReadLine();
        }
    }
}
