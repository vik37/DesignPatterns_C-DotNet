using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDP_UdemyDesignPatterns_ConsoleApp.Task
{
    public class MultiplicationExpression : Expression
    {
        public readonly Expression LHS, RHS;
        public MultiplicationExpression(Expression lhs, Expression rhs)
        {
            LHS = lhs;
            RHS = rhs;
        }
        public override void Accept(ExpressionVisitor ev)
        {
            ev.Visit(this);
        }
    }
}
