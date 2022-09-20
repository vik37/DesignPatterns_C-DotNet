using AdapterDP_UdemyDesignPatterns_ConsoleApp.AdapterInDependencyInjection.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDP_UdemyDesignPatterns_ConsoleApp.AdapterInDependencyInjection
{
    public class OpenCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Opening a file");
        }
    }
}
