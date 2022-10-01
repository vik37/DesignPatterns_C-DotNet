using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility_UdemyDesignPatterns_ConsoleApp.MethodChain
{
    internal class NoBonusesModifier : CreatureModifier
    {
        public NoBonusesModifier(Creature creature) : base(creature)
        {
        }
        public override void Handle()
        {

        }
    }
}
