using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility_UdemyDesignPatterns_ConsoleApp.BrokenChain
{
    public class Creature
    {
        private Game game;
        public string Name;
        private int attack, defence;
        public Creature(Game game, string name, int attack, int defence)
        {
            this.game = game;
            Name = name;
            this.attack = attack;
            this.defence = defence;
        }
        public int Attack
        {
            get
            {
                var q = new Query(Name, Query.Argument.Attack,attack);
                game.PerformQuery(this, q);
                return q.Value;
            }
        }
        public int Deffence
        {
            get
            {
                var q = new Query(Name, Query.Argument.Defence, attack);
                game.PerformQuery(this, q);
                return q.Value;
            }
        }
        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Attack)}: {Attack}, {nameof(Deffence)}: {Deffence}";
        }
    }
}
