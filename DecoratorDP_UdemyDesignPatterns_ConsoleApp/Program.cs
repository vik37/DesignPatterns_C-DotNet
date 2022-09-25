using DecoratorDP_UdemyDesignPatterns_ConsoleApp.MultipleInheritanceWithInterfaces;
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
            var d = new Dragon();
            d.Weight = 200;
            d.Fly();
            d.Crowl();
            
            #endregion
            Console.ReadLine();
        }
    }
}
