using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TamplateMethodDP_UdemyDesignPatterns_ConsoleApp.TemplateMethod
{
    public abstract class Game
    {
        public void Run()
        {
            Start();
            while(!HaveWinner)
                TakeTurn();
            Console.WriteLine($"Player {WinninPlayer} wins.");
        }
        protected int currentPlayer;
        protected readonly int numberOfPlayer;
        protected Game(int numberOfPlaters)
        {
            this.numberOfPlayer = numberOfPlaters;
        }

        protected abstract void Start();
        protected abstract void TakeTurn();
        protected abstract bool HaveWinner { get; }
        protected abstract int WinninPlayer { get; }
    }
}
