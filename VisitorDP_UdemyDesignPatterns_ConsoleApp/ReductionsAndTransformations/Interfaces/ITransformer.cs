using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDP_UdemyDesignPatterns_ConsoleApp.ReductionsAndTransformations.Interfaces
{
    public interface ITransformer<out T>
    {
        T Transform(DoubleExpression de);
        T Transform(AdditionalExpression ae);
    }
}
