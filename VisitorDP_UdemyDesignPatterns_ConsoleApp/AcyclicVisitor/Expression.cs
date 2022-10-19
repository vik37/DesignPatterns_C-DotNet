using System;
using System.Collections.Generic;
using System.Text;
using VisitorDP_UdemyDesignPatterns_ConsoleApp.AcyclicVisitor.Interfaces;

namespace VisitorDP_UdemyDesignPatterns_ConsoleApp.AcyclicVisitor
{
    public abstract class Expression
    {
        public virtual void Accept(IVisitor visitor)
        {
            if(visitor is IVisitor<Expression> typed)
            {
                typed.Visit(this);
            }
        }
    }
}
