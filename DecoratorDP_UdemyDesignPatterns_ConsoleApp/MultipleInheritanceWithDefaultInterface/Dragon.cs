using DecoratorDP_UdemyDesignPatterns_ConsoleApp.MultipleInheritanceWithDefaultInterface.Interfacec;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDP_UdemyDesignPatterns_ConsoleApp.MultipleInheritanceWithDefaultInterface
{
    public class Dragon : IBird, ILizard
    {
        public int Age { get; set; }
    }
}
