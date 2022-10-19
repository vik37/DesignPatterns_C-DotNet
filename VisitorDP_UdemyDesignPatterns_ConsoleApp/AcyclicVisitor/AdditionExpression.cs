using System;
using System.Collections.Generic;
using System.Text;
using VisitorDP_UdemyDesignPatterns_ConsoleApp.AcyclicVisitor.Interfaces;

namespace VisitorDP_UdemyDesignPatterns_ConsoleApp.AcyclicVisitor
{
    public class AdditionExpression : Expression
    {
        public Expression Left, Right;
        public AdditionExpression(Expression left, Expression right)
        {
            Left = left;
            Right = right;
        }
        public override void Accept(IVisitor visitor)
        {
            if (visitor is IVisitor<AdditionExpression> typed)
            {
                typed.Visit(this);
            }
        }
    }
}
