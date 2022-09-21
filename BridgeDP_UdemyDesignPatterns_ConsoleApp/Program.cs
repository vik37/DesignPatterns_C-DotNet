using Autofac;
//using BridgeDP_UdemyDesignPatterns_ConsoleApp.BridgeDp;
//using BridgeDP_UdemyDesignPatterns_ConsoleApp.BridgeDp.Interfaces;
using BridgeDP_UdemyDesignPatterns_ConsoleApp.Homework;
using BridgeDP_UdemyDesignPatterns_ConsoleApp.Homework.Interfaces;
using System;

namespace BridgeDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            // ridge D.P.
            // Bridge DP - witout Dependency Injection

            //IRenderer renderer = new RasterRenderer();
            //var renderer = new VectorRenderer();
            //var circle = new Circle(renderer, 5);
            //circle.Drow();
            //circle.Resize(2);
            //circle.Drow();

            // -------------------------------------
            // Bridge DP - with Dependency Injection

            //var cb = new ContainerBuilder();
            //cb.RegisterType<VectorRenderer>().As<IRenderer>()
            //        .SingleInstance();
            //cb.Register((c, p) =>
            //                new Circle(c.Resolve<IRenderer>(), p.Positional<float>(0)));
            //using(var c = cb.Build())
            //{
            //    var circle = c.Resolve<Circle>(
            //            new PositionalParameter(0,5.0f));
            //    circle.Drow();
            //    circle.Resize(2);
            //    circle.Drow();
            //}

            #endregion

            #region
            // Bridge Design Pattern - Homework
            var square = new Square(new VectorRenderer()).ToString();
            Console.WriteLine(square);

            #endregion
            Console.ReadLine();
        }
    }
}
