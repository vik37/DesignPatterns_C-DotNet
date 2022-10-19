using System;
using System.Collections.Generic;
using System.Text;
using VisitorDP_UdemyDesignPatterns_ConsoleApp.AcyclicVisitor.Interfaces;

namespace VisitorDP_UdemyDesignPatterns_ConsoleApp.AcyclicVisitor
{
    public class DoubleExpression : Expression
    {
        public double Value;
        public DoubleExpression(double value)
        {
            Value = value;
        }
        public override void Accept(IVisitor visitor)
        {
            if (visitor is IVisitor<DoubleExpression> typed)
            {
                typed.Visit(this);
            }
        }
    }
}
