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
            ICar car = new CarProxy(new Driver(12));
            car.Drive();
            #endregion
            Console.ReadLine();
        }
    }
}
