using System;
using System.Collections.Generic;
using System.Text;
using VisitorDP_UdemyDesignPatterns_ConsoleApp.ReductionsAndTransformations.Interfaces;

namespace VisitorDP_UdemyDesignPatterns_ConsoleApp.ReductionsAndTransformations
{
    public class PrintTransformer : ITransformer<string>
    {
        public string Transform(DoubleExpression de)
        {
            return de.Value.ToString();
        }
        public string Transform(AdditionalExpression ae)
        {
            return $"({ae.Left.Reduce(this)} + {ae.Right.Reduce(this)})";
        }
    }
}
