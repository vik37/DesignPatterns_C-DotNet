using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility_UdemyDesignPatterns_ConsoleApp.Task
{
    public class Goblin : Creature
    {
        public Goblin(Game game) : base(game, 1, 1)
        { }
        protected Goblin(Game game, int baseAttack, int baseDefense)
            : base(game, baseAttack, baseDefense)
        { }
        public override void Query(object obj, StatQuery q)
        {
            if(ReferenceEquals(obj, this))
            {
                switch (q.Statistics)
                {
                    case Statistics.Attack:
                        q.Result += baseAttack;
                        break;
                    case Statistics.Defense:
                        q.Result += baseDefense;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            else
            {
                if(q.Statistics == Statistics.Defense)
                {
                    q.Result++;
                }
            }
        }
        public override int Attack 
        { 
            get
            {
                var q = new StatQuery { Statistics = Statistics.Attack };
                foreach (var c in game.Creatures)
                {
                    c.Query(this, q);
                }
                return q.Result;
            }
        }
        public override int Defence 
        { 
            get
            {
                var q = new StatQuery { Statistics = Statistics.Defense };
                foreach (var c in game.Creatures)
                {
                    c.Query(this, q);
                }
                return q.Result;
            } 
        }
    }
}
