using StateDP_UdemyDesignPatterns_ConsoleApp.ClassicImplementation;
using System;

namespace StateDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classic Implementation
            var ls = new Switch();
            ls.On();
            ls.Off();
            ls.Off();
            #endregion
            Console.ReadLine();
        }
    }
}
