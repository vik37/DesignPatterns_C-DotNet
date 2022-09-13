using PrototypeDP_UdemyDesignPatterns_ConsoleApp.IClonableIsBad;
using System;

namespace PrototypeDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            // IClonable interface is bad.
            var john = new Person(new string[] { "John", "Smith" }, new Address("London Road", 4));
            

            //var jane = john;
            //jane.Names[0] = "Jane";
            var jane = (Person)john.Clone();
            jane.Address.HouseNumber = 321;
            Console.WriteLine(john);
            Console.WriteLine(jane);
            #endregion
            Console.ReadLine();
        }
    }
}
