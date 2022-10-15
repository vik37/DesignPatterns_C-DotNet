using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDP_UdemyDesignPatterns_ConsoleApp.Task
{
    public class Rat : IDisposable
    {
        public int Attack = 1;
        private readonly Game game;
        public Rat(Game game)
        {
            this.game = game;
            game.RatEnters += (sender, args) =>
            {
                if (sender != this)
                {
                    ++Attack;
                    game.FireRat(this, (Rat)sender);
                }
            };
            game.EventRat += (sender, rat) =>
            {
                if (rat == this)
                    ++Attack;
            };
            game.RatDies += (sender, rat) => --Attack;
            game.FireRatEnter(this);
        }
        
        public void Dispose()
        {
            game.FireRatDies(this);
        }
    }
}
