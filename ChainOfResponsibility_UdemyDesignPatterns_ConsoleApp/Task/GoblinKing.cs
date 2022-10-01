using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility_UdemyDesignPatterns_ConsoleApp.Task
{
    public class GoblinKing : Goblin
    {
        public GoblinKing(Game game) : base(game, 3, 3)
        { }
        public override void Query(object obj, StatQuery q)
        {
            if (!ReferenceEquals(obj, this) && q.Statistics == Statistics.Attack)
            {
                q.Result++; 
            }
            else base.Query(obj, q);
        }

    }
}
