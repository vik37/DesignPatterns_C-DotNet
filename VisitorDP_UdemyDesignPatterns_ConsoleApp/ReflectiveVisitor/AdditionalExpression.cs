using System;
using System.Collections.Generic;
using System.Text;

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


    }
}
