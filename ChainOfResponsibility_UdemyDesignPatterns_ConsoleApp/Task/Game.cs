using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility_UdemyDesignPatterns_ConsoleApp.Task
{
    public class Game
    {
        public IList<Creature> Creatures;
        public Game()
        {
            this.Creatures = new List<Creature>();
        }
    }
}
