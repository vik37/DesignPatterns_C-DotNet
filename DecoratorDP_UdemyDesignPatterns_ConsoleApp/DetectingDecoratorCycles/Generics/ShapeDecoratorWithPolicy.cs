using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDP_UdemyDesignPatterns_ConsoleApp.DetectingDecoratorCycles.Generics
{
    // can determine one policy for all classes
    public class ShapeDecoratorWithPolicy<T> : ShapeDecorator<T, ThrowOnCyclePolicy>
    {
        public ShapeDecoratorWithPolicy(Shape shape) : base(shape)
        { }
    }
}
