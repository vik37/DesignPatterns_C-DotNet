using System;
using System.Collections.Generic;
using System.Text;
using VisitorDP_UdemyDesignPatterns_ConsoleApp.ReflectiveVisitor.Interfaces;

namespace VisitorDP_UdemyDesignPatterns_ConsoleApp.ReflectiveVisitor
{
    public class DoubleExpression : Expression
    {
        public double Value;
        public DoubleExpression(double value)
        {
            Value = value;
        }

        public override void Accept(IExpressionVisitor visitor)
        {
            #region Classic Visitor (Double Dispatch)
            visitor.Visit(this);
            #endregion
        }
    }
}
