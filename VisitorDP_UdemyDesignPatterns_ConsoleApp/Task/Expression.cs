using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDP_UdemyDesignPatterns_ConsoleApp.Task
{
    public abstract class Expression
    {
        public abstract void Accept(ExpressionVisitor ev);
    }
}
