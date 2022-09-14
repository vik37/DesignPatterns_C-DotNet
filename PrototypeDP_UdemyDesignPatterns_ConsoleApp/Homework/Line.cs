using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDP_UdemyDesignPatterns_ConsoleApp.Homework
{
    public class Line : IPrototypeDP<Line>
    {
        public Point Start, End;
        public Line() { }       
        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }
        public Line(Line other)
        {
            Start = new Point(other.Start);
            End = new Point(other.End);
        }
        public Line DeepCopy()
        {
            return new Line(Start.DeepCopy(),End.DeepCopy());
        }
    }
}
