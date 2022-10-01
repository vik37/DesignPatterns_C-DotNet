using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace ChainOfResponsibility_UdemyDesignPatterns_ConsoleApp.MethodChain
{
    public class IncreasedDeffenceModifier : CreatureModifier
    {
        public IncreasedDeffenceModifier(Creature creature) : base(creature)
        {
        }
        public override void Handle()
        {
            Console.WriteLine($"Increasing {creature.Name}'s defence");
            creature.Defence += 3;
            base.Handle();
        }
    }
}
