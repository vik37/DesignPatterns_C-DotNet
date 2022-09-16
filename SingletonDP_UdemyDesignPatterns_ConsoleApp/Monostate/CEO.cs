using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDP_UdemyDesignPatterns_ConsoleApp.Monostate
{
    public class CEO
    {
        private static string name;
        private static int age;
        public string Name 
        {
            get => name; 
            set => name = value;
        }
        public int Age 
        { 
            get => age; 
            set => age = value; 
        }
        public override string ToString()
        {
            return $"{nameof(Name)}: {Name} | {nameof(Age)}: {Age}";
        }
    }
}
