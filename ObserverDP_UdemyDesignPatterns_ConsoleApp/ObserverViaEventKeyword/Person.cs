using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDP_UdemyDesignPatterns_ConsoleApp.ObserverViaEventKeyword
{
    public class Person
    {
        public void CatchACold()
        {
            FallsIll?.Invoke(this, new FalsIlEventArgs { Address = "123 London Road"});
        }
        public event EventHandler<FalsIlEventArgs> FallsIll;
    }
}
