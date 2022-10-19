using System;
using System.Collections.Generic;
using System.Text;
using VisitorDP_UdemyDesignPatterns_ConsoleApp.ReductionsAndTransformations.Interfaces;

namespace VisitorDP_UdemyDesignPatterns_ConsoleApp.ReductionsAndTransformations
{
    public class DoubleExpression : Expression
    {
        public  readonly double Value;
        public DoubleExpression(double value)
        {
            Value = value;
        }
        public override T Reduce<T>(ITransformer<T> transformer)
        {
            return transformer.Transform(this);
        }
    }
}
