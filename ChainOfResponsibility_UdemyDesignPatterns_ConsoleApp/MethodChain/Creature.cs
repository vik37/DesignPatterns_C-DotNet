using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility_UdemyDesignPatterns_ConsoleApp.MethodChain
{
    public class Creature
    {
        public string Name;
        public int Attack, Defence;
        public Creature(string name, int attack, int defence)
        {
            Name = name;
            Attack = attack;
            Defence = defence;
        }
        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Attack)}: {Attack}, {nameof(Defence)}: {Defence}";
        }
    }
}
