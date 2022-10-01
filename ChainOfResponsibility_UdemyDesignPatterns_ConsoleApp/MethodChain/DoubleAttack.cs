using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility_UdemyDesignPatterns_ConsoleApp.MethodChain
{
    public class DoubleAttack : CreatureModifier
    {
        public DoubleAttack(Creature creature) : base(creature)
        {
        }
        public override void Handle()
        {
            Console.WriteLine($"Doubling {creature.Name}'s creatures attack");
            creature.Attack *= 2;
            base.Handle();
        }
    }
}
