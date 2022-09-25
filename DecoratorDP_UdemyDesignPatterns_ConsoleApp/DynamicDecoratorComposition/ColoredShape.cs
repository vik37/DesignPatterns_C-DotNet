using DecoratorDP_UdemyDesignPatterns_ConsoleApp.DynamicDecoratorComposition.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDP_UdemyDesignPatterns_ConsoleApp.DynamicDecoratorComposition
{
    public class ColoredShape : IShape
    {
        private IShape shape;
        private string color;
        public ColoredShape(IShape shape, string color)
        {
            this.shape = shape;
            this.color = color;
        }

        public string AsString()
        {
            return $"{shape.AsString()} has color {color}";
        }
    }
}
