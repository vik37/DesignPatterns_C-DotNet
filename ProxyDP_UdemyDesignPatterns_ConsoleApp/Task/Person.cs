using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyDP_UdemyDesignPatterns_ConsoleApp.Task
{
    public class Person
    {
        public int Age { get; set; }

        public string Drink()
        {
            return "drinking";
        }

        public string Drive()
        {
            return "driving";
        }

        public string DrinkAndDrive()
        {
            return "driving while drunk";
        }
    }
}
