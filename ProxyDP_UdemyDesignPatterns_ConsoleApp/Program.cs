//using ProxyDP_UdemyDesignPatterns_ConsoleApp.PropertyProxy;
using ProxyDP_UdemyDesignPatterns_ConsoleApp.CompositeProxy;
using ProxyDP_UdemyDesignPatterns_ConsoleApp.DynamicProxyLogging;
using ProxyDP_UdemyDesignPatterns_ConsoleApp.DynamicProxyLogging.Interfaces;
using ProxyDP_UdemyDesignPatterns_ConsoleApp.DynamicProxyLogging.Logger;
using ProxyDP_UdemyDesignPatterns_ConsoleApp.ProtectionProxy;
using ImpromptuInterface;
using ProxyDP_UdemyDesignPatterns_ConsoleApp.ProtectionProxy.Interfaces;
using ProxyDP_UdemyDesignPatterns_ConsoleApp.ValueProxy;
using System;
using ProxyDP_UdemyDesignPatterns_ConsoleApp.Task;

namespace ProxyDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Protection Proxy
            //ICar car = new CarProxy(new Driver(12));
            //car.Drive();
            #endregion

            #region Property Proxy
            //var c = new Creature();
            //c.Agility = 10; // c.set_agility(10) will not work;
            // c.Agility = new Property<int>(10)

            //c.Agility = 10;
            // If we assign value twice, we're only actually assigning once.
            //c.Letter = 'A';
            //c.Letter = 'B';
            #endregion

            #region Value Proxy
            //Console.WriteLine(10f * 5.Percent());
            //Console.WriteLine(2.Percent() + 3.Percent()); //5%
            #endregion

            #region Composite Proxy SoA/AoS
            // Combination of Proxy and Composite Design Patterns

            //var creatures = new Creature[100]; // AoS = Array of Structures
            //foreach (Creature c in creatures)
            //{
            //    c.X++;
            //}

            //var creatures2 = new Creatures(100); // SoA = Structure of Arrays
            //foreach (Creatures.CreatureProxy c in creatures2)
            //{
            //    c.X++;
            //}
            #endregion

            #region Dynamic Proxy Logging 
            // var ba = new BankAccount();
            //var ba = Log<BankAccount>.As<IBankAccount>();
            //ba.Deposit(100);
            //ba.Withdraw(50);
            //Console.WriteLine(ba);
            //Console.WriteLine(ba.Info);
            #endregion

            #region Task
            Person p1 = new Person();
            p1.Age = 17;
            var rp = new ResponsiblePerson(p1);
            Console.WriteLine(rp.Drive());
            Console.WriteLine(rp.Drink());
            Console.WriteLine(rp.DrinkAndDrive());
            #endregion
            Console.ReadLine();
        }
    }
}
