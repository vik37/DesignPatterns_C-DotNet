using DecoratorDP_UdemyDesignPatterns_ConsoleApp.MultipleInheritanceWithInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDP_UdemyDesignPatterns_ConsoleApp.MultipleInheritanceWithInterfaces
{
    public class Lizard : ILizard
    {
        public int Weight { get; set; }
        public void Crowl()
        {
            Console.WriteLine($"Crawling in the dirt with weight {Weight}");
        }
    }
}
