using AdapterDP_UdemyDesignPatterns_ConsoleApp.AdapterInDependencyInjection.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace AdapterDP_UdemyDesignPatterns_ConsoleApp.AdapterInDependencyInjection
{
    public class SaveCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Saving a file");
        }
    }
}
