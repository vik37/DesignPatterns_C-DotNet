using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDP_UdemyDesignPatterns_ConsoleApp.Visitor
{
    public class AdditionExpression : Expression
    {
        private Expression Left, Right;
        public AdditionExpression(Expression left, Expression right)
        {
            Left = left;
            Right = right;
        }

        public override void Print(StringBuilder sb)
        {
            sb.Append("(");
            Left.Print(sb);
            sb.Append("+");
            Right.Print(sb);
            sb.Append(')');
        }
    }
}
