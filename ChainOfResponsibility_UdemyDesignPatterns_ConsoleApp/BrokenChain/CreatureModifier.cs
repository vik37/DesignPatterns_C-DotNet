using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace ChainOfResponsibility_UdemyDesignPatterns_ConsoleApp.BrokenChain
{
    public abstract class CreatureModifier : IDisposable
    {
        protected Game game;
        protected Creature creature;
        public CreatureModifier(Game game, Creature creature)
        {
            this.game = game;
            this.creature = creature;
            game.Queries += Handle;
        }
        protected abstract void Handle(object sender, Query q);
        public void Dispose()
        {
            game.Queries -= Handle;
        }
    }
}
