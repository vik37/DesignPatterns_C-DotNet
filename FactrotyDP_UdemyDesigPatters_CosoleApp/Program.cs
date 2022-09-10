using FactrotyDP_UdemyDesigPatters_CosoleApp.PointExample;
using System;

namespace FactrotyDP_UdemyDesigPatters_CosoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Factory Method Pattern.
            var point = Point.NewPolarPoint(1.0, Math.PI / 2);
            Console.WriteLine(point);
            Console.ReadLine();
        }
    }
}
