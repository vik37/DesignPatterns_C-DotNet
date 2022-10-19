using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using VisitorDP_UdemyDesignPatterns_ConsoleApp.ReductionsAndTransformations.Interfaces;

namespace VisitorDP_UdemyDesignPatterns_ConsoleApp.ReductionsAndTransformations
{
    public class SquareTransformer : ITransformer<Expression>
    {
        public Expression Transform(DoubleExpression de)
        {
            return new DoubleExpression(de.Value * de.Value);
        }

        public Expression Transform(AdditionalExpression ae)
        {
            return new AdditionalExpression(
                    ae.Left.Reduce(this), ae.Right.Reduce(this));
        }
    }
}
