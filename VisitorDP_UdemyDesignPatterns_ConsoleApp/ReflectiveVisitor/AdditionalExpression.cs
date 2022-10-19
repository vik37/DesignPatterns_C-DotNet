using System;
using System.Collections.Generic;
using System.Text;
using VisitorDP_UdemyDesignPatterns_ConsoleApp.ReflectiveVisitor.Interfaces;

namespace VisitorDP_UdemyDesignPatterns_ConsoleApp.ReflectiveVisitor
{
    public class AdditionalExpression : Expression
    {
        public Expression Left, Right;
        public AdditionalExpression(Expression left, Expression right)
        {
            Left = left;
            Right = right;
        }

        public override void Accept(IExpressionVisitor visitor)
        {
            #region Classic Visitor (Double Dispatch)
            visitor.Visit(this);
            #endregion
        }
    }
}
