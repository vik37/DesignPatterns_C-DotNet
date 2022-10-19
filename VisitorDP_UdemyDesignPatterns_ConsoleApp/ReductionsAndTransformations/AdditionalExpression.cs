using System;
using System.Collections.Generic;
using System.Text;
using VisitorDP_UdemyDesignPatterns_ConsoleApp.ReductionsAndTransformations.Interfaces;

namespace VisitorDP_UdemyDesignPatterns_ConsoleApp.ReductionsAndTransformations
{
    public class AdditionalExpression : Expression
    {
        public readonly Expression Left, Right;
        public AdditionalExpression(Expression left, Expression right)
        {
            Left = left;
            Right = right;
        }

        public override T Reduce<T>(ITransformer<T> transformer)
        {
            return transformer.Transform(this);
        }
    }
}
