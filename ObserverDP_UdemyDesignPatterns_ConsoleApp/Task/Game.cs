using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDP_UdemyDesignPatterns_ConsoleApp.Task
{
    public class Game
    {
        public event EventHandler RatEnters, RatDies;
        public event EventHandler<Rat> EventRat;
        public void FireRatEnter(object sender)
        {
            RatEnters?.Invoke(sender, EventArgs.Empty);
        }
        public void FireRatDies(object sender)
        {
            RatDies?.Invoke(sender, EventArgs.Empty);
        }
        public void FireRat(object sender, Rat rat)
        {
            EventRat?.Invoke(sender, rat);
        }

    }
}
