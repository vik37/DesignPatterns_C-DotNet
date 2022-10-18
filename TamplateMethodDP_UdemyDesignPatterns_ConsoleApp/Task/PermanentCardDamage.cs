using System;
using System.Collections.Generic;
using System.Text;

namespace TamplateMethodDP_UdemyDesignPatterns_ConsoleApp.Task
{
    public class PermanentCardDamage : CardGame
    {
        public PermanentCardDamage(Creature[] creatures) : base(creatures)
        {
        }

        protected override void Hit(Creature attacker, Creature other)
        {
            other.Health -= attacker.Attack;
        }
    }
}
