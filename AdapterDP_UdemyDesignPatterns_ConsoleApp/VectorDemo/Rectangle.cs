using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDP_UdemyDesignPatterns_ConsoleApp.VectorDemo
{
    public class Rectangle : VectorRectangle
    {
        public Rectangle(int x, int y, int width, int height)
        {
            Add(new Line(new Point(x, y), new Point(x + width, y)));
            Add(new Line(new Point(x + width, y), new Point(x + width, y + width)));
            Add(new Line(new Point(x, y), new Point(x + height, y)));
            Add(new Line(new Point(x, y + height), new Point(x + height, y + height)));
        }
    }
}
