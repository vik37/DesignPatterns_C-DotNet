using DecoratorDP_UdemyDesignPatterns_ConsoleApp.DynamicDecoratorComposition.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDP_UdemyDesignPatterns_ConsoleApp.DynamicDecoratorComposition
{
    public class Square : IShape
    {
        private float side;
        public Square(float side)
        {
            this.side = side;
        }

        public string AsString() => $"A square with side {side}";
        
    }
}
