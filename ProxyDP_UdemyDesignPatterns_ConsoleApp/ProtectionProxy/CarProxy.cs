using ProxyDP_UdemyDesignPatterns_ConsoleApp.ProtectionProxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyDP_UdemyDesignPatterns_ConsoleApp.ProtectionProxy
{
    public class CarProxy : ICar
    {
        private Driver driver;
        private Car car = new Car();
        public CarProxy(Driver driver)
        {
            this.driver = driver;
        }

        public void Drive()
        {
            if(driver.Age >= 16)
            {
                car.Drive();
            }
            else
            {
                Console.WriteLine("too yung");
            }
        }
    }
}
