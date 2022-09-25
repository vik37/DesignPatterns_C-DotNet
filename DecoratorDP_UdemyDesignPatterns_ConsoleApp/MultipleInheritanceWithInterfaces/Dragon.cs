using DecoratorDP_UdemyDesignPatterns_ConsoleApp.MultipleInheritanceWithInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDP_UdemyDesignPatterns_ConsoleApp.MultipleInheritanceWithInterfaces
{
    public class Dragon : IBird, ILizard
    {
        private Bird Bird = new Bird();
        private Lizard Lizard = new Lizard();
        private int weight;

        public int Weight {
            get { return weight; }
            set { 
                    weight = value; 
                    Bird.Weight = value;
                    Lizard.Weight = value;
                }
        }

        public void Crowl()
        {
            Lizard.Crowl();
        }

        public void Fly()
        {
            Bird.Fly();
        }
    }
}
