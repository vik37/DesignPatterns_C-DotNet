using System;

namespace FactoryDP_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonFactory pf1 = new PersonFactory();
            pf1.CreatePerson("Viktor");
            pf1.CreatePerson("Marko");
            pf1.CreatePerson("Davor");

            Console.ReadLine();
        }
    }
}
