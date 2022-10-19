using System;
using System.Collections.Generic;
using System.Text;
using VisitorDP_UdemyDesignPatterns_ConsoleApp.ReflectiveVisitor.Interfaces;

namespace VisitorDP_UdemyDesignPatterns_ConsoleApp.ReflectiveVisitor
{
    #region Classic Visitor (Double Dispatch)
    public class ExpressionPrinterForVisitor : IExpressionVisitor
    {
        private StringBuilder sb = new StringBuilder();
        public void Visit(DoubleExpression de)
        {
            sb.Append(de.Value);
        }

        public void Visit(AdditionalExpression ae)
        {
            sb.Append("(");
            ae.Left.Accept(this);
            sb.Append("+");
            ae.Right.Accept(this);
            sb.Append(')');
        }
        public override string ToString()
        {
            return sb.ToString();
        }
    }
    #endregion
}
