using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDP_UdemyDesignPatterns_ConsoleApp.DetectingDecoratorCycles.Generics
{
    public abstract class ShapeDecorator<TSelf, TCyclePolicy> : ShapeDecorator
        where TCyclePolicy : ShapeDecoratorCyclePolicy, new()
    {
        protected readonly TCyclePolicy policy = new TCyclePolicy();
        public ShapeDecorator(Shape shape):base(shape)
        {
            if(policy.TypeAdditioAllowed(typeof(TSelf), types))
            {
                types.Add(typeof(TSelf));
            }
        }
    }
}
