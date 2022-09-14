using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDP_UdemyDesignPatterns_ConsoleApp.Homework
{
    public class Point : IPrototype<Point>
    {
        public int X, Y;

        public Point() { }       
        
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Point(Point other)
        {
            X = other.X;
            Y = other.Y;
        }

        public Point DeepCopy()
        {
            return  new Point(X, Y);
        }
    }
}
