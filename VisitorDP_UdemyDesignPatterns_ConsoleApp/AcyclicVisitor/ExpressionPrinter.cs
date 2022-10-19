﻿using System;
using System.Collections.Generic;
using System.Text;
using VisitorDP_UdemyDesignPatterns_ConsoleApp.AcyclicVisitor.Interfaces;

namespace VisitorDP_UdemyDesignPatterns_ConsoleApp.AcyclicVisitor
{
    public class ExpressionPrinter : IVisitor, 
        IVisitor<Expression>,
        IVisitor<DoubleExpression>,
        IVisitor<AdditionExpression>
    {
        private StringBuilder sb = new StringBuilder();
        public void Visit(Expression obj)
        {
            
        }
        public void Visit(DoubleExpression obj)
        {
            sb.Append(obj.Value);
        }
        public void Visit(AdditionExpression obj)
        {
            sb.Append("(");
            obj.Left.Accept(this);
            sb.Append("+");
            obj.Right.Accept(this);
            sb.Append(")");
        }
        public override string ToString()
        {
            return sb.ToString();
        }
    }
}
