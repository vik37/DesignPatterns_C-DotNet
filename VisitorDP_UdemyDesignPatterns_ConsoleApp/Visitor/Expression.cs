using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDP_UdemyDesignPatterns_ConsoleApp.Visitor
{
    public abstract class Expression
    {
        public abstract void Print(StringBuilder sb);
    }
}
