using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyDP_UdemyDesignPatterns_ConsoleApp.PropertyProxy
{
    public class Creature
    {
        private Property<int> agility = new Property<int>();
        private Property<char> letter = new Property<char>();
        public int Agility
        {
            get => agility.Value;
            set => agility.Value = value;
        }
        public char Letter
        {
            get => letter.Value;
            set => letter.Value = value;
        }
    }
}
