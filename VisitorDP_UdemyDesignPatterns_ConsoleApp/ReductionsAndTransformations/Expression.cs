using System;
using System.Collections.Generic;
using System.Text;
using VisitorDP_UdemyDesignPatterns_ConsoleApp.ReductionsAndTransformations.Interfaces;

namespace VisitorDP_UdemyDesignPatterns_ConsoleApp.ReductionsAndTransformations
{
    public abstract class Expression
    {
        public abstract T Reduce<T>(ITransformer<T> transformer);
    }
}
