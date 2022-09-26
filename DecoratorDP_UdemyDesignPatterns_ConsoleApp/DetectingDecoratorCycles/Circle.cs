using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDP_UdemyDesignPatterns_ConsoleApp.DetectingDecoratorCycles
{
    public sealed class Circle : Shape
    {
        private float radius;
        public Circle() : this(0)
        {

        }
        public Circle(float radius)
        {
            this.radius = radius;
        }
        public void Resize(float factor)
        {
            radius *= factor;
        }
        public override string AsString() => $"A circle of radius {radius}";
    }
}
