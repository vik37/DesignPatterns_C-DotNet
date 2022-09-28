using ProxyDP_UdemyDesignPatterns_ConsoleApp.PropertyProxy;
using ProxyDP_UdemyDesignPatterns_ConsoleApp.ProtectionProxy;
using ProxyDP_UdemyDesignPatterns_ConsoleApp.ProtectionProxy.Interfaces;
using System;

namespace ProxyDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            // Protection Proxy
            //ICar car = new CarProxy(new Driver(12));
            //car.Drive();
            #endregion

            #region
            // Property Proxy
            var c = new Creature();
            c.Agility = 10; // c.set_agility(10) will not work;
                            // c.Agility = new Property<int>(10)

            c.Agility = 10; 
            // If we assign value twice, we're only actually assigning once.
            #endregion
            Console.ReadLine();
        }
    }
}
