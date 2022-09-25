using DecoratorDP_UdemyDesignPatterns_ConsoleApp.MultipleInheritanceWithInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDP_UdemyDesignPatterns_ConsoleApp.MultipleInheritanceWithInterfaces
{
    public class Bird : IBird
    {
        public int Weight { get; set; }

        public void Fly()
        {
            Console.WriteLine($"Soaring in the sky with weight {Weight}");
        }
    }
}
