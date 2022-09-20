using AdapterDP_UdemyDesignPatterns_ConsoleApp.GenericValueAdapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDP_UdemyDesignPatterns_ConsoleApp.GenericValueAdapter
{
    public static class Dimensions
    {
        public class Two : IInteger
        {
            public int Value => 2;
        }
        public class Three : IInteger
        {
            public int Value => 3;
        }
    }
}
