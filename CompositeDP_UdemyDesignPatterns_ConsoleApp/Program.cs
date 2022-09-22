using CompositeDP_UdemyDesignPatterns_ConsoleApp.GeometricShapes;
using System;

namespace CompositeDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            // Geometric Shapes
            var drawing = new GraphicObject { Name = "My Drawing" };
            drawing.Children.Add(new Circle { Color = "Red" });
            drawing.Children.Add(new Square { Color = "Yellow" });

            var group = new GraphicObject();
            group.Children.Add(new Circle { Color="Blue"});
            group.Children.Add(new Square { Color = "Blue" });
            drawing.Children.Add(group);

            Console.WriteLine(drawing);
            #endregion
            Console.ReadLine();
        }
    }
}
