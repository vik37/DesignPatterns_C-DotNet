//using PrototypeDP_UdemyDesignPatterns_ConsoleApp.IClonableIsBad;
//using PrototypeDP_UdemyDesignPatterns_ConsoleApp.ConstructorCopy;
using PrototypeDP_UdemyDesignPatterns_ConsoleApp.Homework;
using PrototypeDP_UdemyDesignPatterns_ConsoleApp.PrototypeInheritance;
using System;

namespace PrototypeDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            // IClonable interface is bad.
            //var john = new Person(new string[] { "John", "Smith" }, new Address("London Road", 4));            
            //var jane = john;
            //jane.Names[0] = "Jane";
            //var jane = (Person)john.Clone();
            //jane.Address.HouseNumber = 321;
            //Console.WriteLine(john);
            //Console.WriteLine(jane);
            #endregion

            #region
            // Constructor Copy

            //var john = new Person(new string[] { " Jürgen", "Klopp" }, 
            //                            new Address("FK Liverpool Road", 4));
            //var jane = new Person(john);
            //jane.Address.StreetName = "Nokshir Real Madrid.";
            //Console.WriteLine(john);
            //Console.WriteLine(jane);
            #endregion

            #region
            // Explicit: Deep Copy Interface.

            //var john = new Person(new string[] { " Jürgen", "Klopp" },
            //                            new Address("FK Liverpool Road", 4));
            //var jane = john.DeepCopy();
            //jane.Address.HouseNumber = 23;
            //Console.WriteLine(john);
            //Console.WriteLine(jane);

            #endregion

            #region
            // Prototype Inheritance.
            //var john = new Employee();
            //john.Names = new string[] { "John", "Doe" };
            //john.Address = new Address
            //{
            //    HouseNumber = 123,
            //    StreetName = "London Road"
            //};
            //john.Salery = 321000;
            //var copy = john.DeepCopy();

            //copy.Names[0] = "Smith";
            //copy.Address.HouseNumber++;
            //copy.Salery = 123000;
            //Console.WriteLine(john);
            //Console.WriteLine(copy);
            #endregion

            #region
            // Homework

            var line1 = new Line(new Point(1, 2), new Point(5, 6));
            var line2 = line1.DeepCopy();

            line2.Start.X = 50000;
            Console.WriteLine($"Line 1: Start {line1.Start.X}, {line1.Start.Y} ");
            Console.WriteLine($"Line 1: End {line1.End.X}, {line1.End.Y} ");

            Console.WriteLine($"Line 2: Start {line2.Start.X}, {line2.Start.Y} ");
            Console.WriteLine($"Line 2: End {line2.End.X}, {line2.End.Y} ");

            #endregion
            Console.ReadLine();
        }
    }
}
