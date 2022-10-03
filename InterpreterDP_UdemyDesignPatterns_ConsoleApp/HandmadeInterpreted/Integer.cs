using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterDP_UdemyDesignPatterns_ConsoleApp.HandmadeInterpreted
{
    public class Integer : IElement
    {
        public int Value { get; }
        public Integer(int value)
        {
            Value = value;
        }
    }
}
