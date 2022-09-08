using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDP_UdemyDesignPatterns_ConsoleApp.FunctionalBuilder
{
    public class Person
    {
        public string Name, Company, Position;

        public override string ToString()
        {
            return $" Name: {Name} \n Company: {Company} \n Position: {Position}";
        }
    }
}
