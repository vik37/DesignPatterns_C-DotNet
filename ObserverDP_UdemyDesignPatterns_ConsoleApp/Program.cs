using ObserverDP_UdemyDesignPatterns_ConsoleApp.ObserverViaEventKeyword;
using System;

namespace ObserverDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Observer via 'event' Keyword
            var person = new Person();
            person.FallsIll += CallDoctor;
            person.CatchACold();
            person.FallsIll -= CallDoctor;
            #endregion
            Console.ReadLine();
        }

        #region Observer via 'event' Keyword
        public static void CallDoctor(object sender, FalsIlEventArgs eventArgs)
        {
            Console.WriteLine($"A doctor has been called to {eventArgs.Address}");
        }
        #endregion
    }
}
