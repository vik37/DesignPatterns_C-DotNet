using System;
using System.Collections.Generic;
using System.Text;
using VisitorDP_UdemyDesignPatterns_ConsoleApp.ReflectiveVisitor.Interfaces;

namespace VisitorDP_UdemyDesignPatterns_ConsoleApp.ReflectiveVisitor
{
    public abstract class Expression
    {
        #region Classic Visitor (Double Dispatch)
        public abstract void Accept(IExpressionVisitor visitor);
        #endregion
    }
}
