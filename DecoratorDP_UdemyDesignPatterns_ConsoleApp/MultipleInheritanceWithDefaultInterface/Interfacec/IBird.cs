using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDP_UdemyDesignPatterns_ConsoleApp.MultipleInheritanceWithDefaultInterface.Interfacec
{
    public interface IBird : ICreature
    {
        void Fly()
        {
            if(Age >= 10)
            {
                Console.WriteLine("I am fly");
            }
        }
    }
}
