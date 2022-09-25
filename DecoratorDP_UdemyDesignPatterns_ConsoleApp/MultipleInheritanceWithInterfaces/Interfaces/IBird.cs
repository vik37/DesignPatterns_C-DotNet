using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDP_UdemyDesignPatterns_ConsoleApp.MultipleInheritanceWithInterfaces.Interfaces
{
    public interface IBird
    {
        int Weight { get; set; }
        public void Fly();
    }
}
