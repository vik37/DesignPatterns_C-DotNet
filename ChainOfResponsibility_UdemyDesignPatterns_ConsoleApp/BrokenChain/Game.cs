using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility_UdemyDesignPatterns_ConsoleApp.BrokenChain
{
    public class Game
    {
        public event EventHandler<Query> Queries;
        public void PerformQuery(object sender, Query q)
        {
            Queries?.Invoke(sender, q);
        }
    }
}
