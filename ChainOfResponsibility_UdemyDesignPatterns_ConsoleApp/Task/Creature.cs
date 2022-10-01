using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility_UdemyDesignPatterns_ConsoleApp.Task
{
    public abstract class Creature
    {
        protected Game game;
        protected readonly int baseAttack;
        protected readonly int baseDefense;
        protected Creature(Game game, int baseAttack, int baseDefence)
        {
            this.game = game;
            this.baseAttack = baseAttack;
            this.baseDefense = baseDefence;
        }
        public virtual int Attack { get; set; }
        public virtual int Defence { get; set; }
        public abstract void Query(object obj, StatQuery q);
        public override string ToString()
        {
            return $"{nameof(Attack)}: {Attack}, {nameof(Defence)}: {Defence}";
        }
    }
}
