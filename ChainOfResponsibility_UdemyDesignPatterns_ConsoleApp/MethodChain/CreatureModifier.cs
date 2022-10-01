using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility_UdemyDesignPatterns_ConsoleApp.MethodChain
{
    public class CreatureModifier
    {
        protected Creature creature;
        protected CreatureModifier next; // Linked List
        public CreatureModifier(Creature creature)
        {
            this.creature = creature;
        }
        public void Add(CreatureModifier cm)
        {
            if (next != null) next.Add(cm);
            else next = cm;
        }
        public virtual void Handle() => next?.Handle();
    }
}
