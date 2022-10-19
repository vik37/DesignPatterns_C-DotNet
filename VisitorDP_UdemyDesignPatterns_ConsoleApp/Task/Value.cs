using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDP_UdemyDesignPatterns_ConsoleApp.Task
{
    public class Value : Expression
    {
        public readonly int TheValue;
        public Value(int theValue)
        {
            TheValue = theValue;
        }

        public override void Accept(ExpressionVisitor ev)
        {
            ev.Visit(this);
        }
    }
}
