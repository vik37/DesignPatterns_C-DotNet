using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDP_UdemyDesignPatterns_ConsoleApp.ObserverViaSpecialInterfaces
{
    public class Observer : IObserver<Event>
    {
        public Observer()
        {
            var person = new Person();
            IDisposable sub = person.Subscribe(this);

            person.FallIll();            
        }
        public static void MainObserver(string[] args)
        {

        }
        public void OnCompleted()
        { }

        public void OnError(Exception error)
        { }

        public void OnNext(Event value)
        {
            if(value is FallsIllEvent args)
            {
                Console.WriteLine($"If doctor is required at {args.Address}");
            }
        }
    }
}
