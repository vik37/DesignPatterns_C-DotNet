using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDP_UdemyDesignPatterns_ConsoleApp.ReflectiveVisitor
{
    public class DoubleExpression : Expression
    {
        public double Value;
        public DoubleExpression(double value)
        {
            Value = value;
        }

    }
}
