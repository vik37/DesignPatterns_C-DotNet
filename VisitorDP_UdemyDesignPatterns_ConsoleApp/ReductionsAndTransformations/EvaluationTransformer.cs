using System;
using System.Collections.Generic;
using System.Text;
using VisitorDP_UdemyDesignPatterns_ConsoleApp.ReductionsAndTransformations.Interfaces;

namespace VisitorDP_UdemyDesignPatterns_ConsoleApp.ReductionsAndTransformations
{
    public class EvaluationTransformer : ITransformer<double>
    {
        public double Transform(DoubleExpression de) => de.Value;

        public double Transform(AdditionalExpression ae)
        {
            return ae.Left.Reduce(this) + ae.Right.Reduce(this);
        }
    }
}
