using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDP_UdemyDesignPatterns_ConsoleApp.AcyclicVisitor.Interfaces
{
    public interface IVisitor<TVisitable>
    {
        void Visit(TVisitable obj);
    }
    public interface IVisitor
    { }
}
