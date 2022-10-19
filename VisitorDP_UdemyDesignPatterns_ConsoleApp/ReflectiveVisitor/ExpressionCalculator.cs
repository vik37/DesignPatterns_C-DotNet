using System;
using System.Collections.Generic;
using System.Text;
using VisitorDP_UdemyDesignPatterns_ConsoleApp.ReflectiveVisitor.Interfaces;

namespace VisitorDP_UdemyDesignPatterns_ConsoleApp.ReflectiveVisitor
{
    #region Classic Visitor (Double Dispatch)
    public class ExpressionCalculator : IExpressionVisitor
    {
        public double Result;
        public void Visit(DoubleExpression de)
        {
            Result = de.Value;
        }

        public void Visit(AdditionalExpression ae)
        {
            ae.Left.Accept(this);
            var a = Result;
            ae.Right.Accept(this);
            var b = Result;
            Result = a + b; 
        }
    }
    #endregion
}
