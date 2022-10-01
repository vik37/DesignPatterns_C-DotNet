using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility_UdemyDesignPatterns_ConsoleApp.BrokenChain
{
    public class Query
    {
        public string CreatureName;
        public enum Argument
        {
            Attack, Defence
        }
        public Argument WhatToQuery;
        public int Value;
        public Query(string creatureName, Argument whatToQuery, int value)
        {
            CreatureName = creatureName;
            WhatToQuery = whatToQuery;
            Value = value;
        }
    }
}
