using AdapterDP_UdemyDesignPatterns_ConsoleApp.GenericValueAdapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDP_UdemyDesignPatterns_ConsoleApp.GenericValueAdapter
{
    public class VectorOfFloat<TSelf, D> : Vector<TSelf, float, D>
        where D : IInteger, new()
        where TSelf : Vector<TSelf,float,D>, new()
    {
        public override string ToString()
        {
            return $"{string.Join(",", Data)}"; 
        }
    }
}
