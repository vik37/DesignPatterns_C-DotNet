using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDP_UdemyDesignPatterns_ConsoleApp.AmbientContext
{
    public class Wall
    {
        public Point Start, End;
        public int Height;
        public Wall(Point start, Point end)
        {
            Start = start;
            End = end;
            Height = BuildingContext.Current.WallHeight;
        }
        public override string ToString()
        {
            return $"{nameof(Start)}: {Start} | {nameof(End)}: {End} | {nameof(Height)}: {Height}";
        }
    }
}
