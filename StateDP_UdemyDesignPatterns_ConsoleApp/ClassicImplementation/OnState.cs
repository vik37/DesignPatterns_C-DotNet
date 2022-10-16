using System;
using System.Collections.Generic;
using System.Text;

namespace StateDP_UdemyDesignPatterns_ConsoleApp.ClassicImplementation
{
    public class OnState : State
    {
        public OnState()
        {
            Console.WriteLine("Light turned on.");
        }
        public override void Off(Switch sw)
        {
            Console.WriteLine("Turning light off...");
            sw.State = new OffState();
        }
    }
}
