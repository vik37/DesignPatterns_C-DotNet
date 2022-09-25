using DecoratorDP_UdemyDesignPatterns_ConsoleApp.DynamicDecoratorComposition.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDP_UdemyDesignPatterns_ConsoleApp.DynamicDecoratorComposition
{
    public class Circle : IShape
    {
        private float radius;
        public Circle(float radius)
        {
            this.radius = radius;
        }        

        public void Resize(float factor)
        {
            radius *= factor;
        }
        public string AsString() => $"A circle with radius {radius}";
    }
}
