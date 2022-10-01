using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility_UdemyDesignPatterns_ConsoleApp.BrokenChain
{
    public class DoubleAttackModifier : CreatureModifier
    {
        public DoubleAttackModifier(Game game, Creature creature) : base(game, creature)
        {
        }

        protected override void Handle(object sender, Query q)
        {
            if(q.CreatureName == creature.Name
                && q.WhatToQuery == Query.Argument.Attack)
            {
                q.Value *= 2;
            }
        }
    }
}
