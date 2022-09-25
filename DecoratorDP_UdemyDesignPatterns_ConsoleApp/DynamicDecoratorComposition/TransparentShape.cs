using DecoratorDP_UdemyDesignPatterns_ConsoleApp.DynamicDecoratorComposition.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDP_UdemyDesignPatterns_ConsoleApp.DynamicDecoratorComposition
{
    public class TransparentShape : IShape
    {
        private IShape shape;
        private float transparency;
        public TransparentShape(IShape shape, float transparency)
        {
            this.shape = shape;
            this.transparency = transparency;
        }

        public string AsString() => $"{shape.AsString()} has {transparency}% transparency";
    }
}
