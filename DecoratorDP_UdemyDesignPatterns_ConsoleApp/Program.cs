//using DecoratorDP_UdemyDesignPatterns_ConsoleApp.MultipleInheritanceWithInterfaces;
//using DecoratorDP_UdemyDesignPatterns_ConsoleApp.DynamicDecoratorComposition;
using Autofac;
using DecoratorDP_UdemyDesignPatterns_ConsoleApp.DecoratorInDI;
using DecoratorDP_UdemyDesignPatterns_ConsoleApp.DecoratorInDI.Interfaces;
using DecoratorDP_UdemyDesignPatterns_ConsoleApp.DetectingDecoratorCycles;
using DecoratorDP_UdemyDesignPatterns_ConsoleApp.DetectingDecoratorCycles.Dynamic;
using DecoratorDP_UdemyDesignPatterns_ConsoleApp.MultipleInheritanceWithDefaultInterface;
using DecoratorDP_UdemyDesignPatterns_ConsoleApp.MultipleInheritanceWithDefaultInterface.Interfacec;
using System;
using System.Data.Common;

namespace DecoratorDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            // DataAdapter-Decorator
            //var d = new Dragon();
            //d.Weight = 200;
            //d.Fly();
            //d.Crowl();           
            #endregion

            #region
            // Multiple Inheritance With Default Interface
            //Dragon d = new Dragon() {Age=5 };
            //if(d is IBird bird)
            //{
            //    bird.Fly();
            //}
            //if(d is ILizard lizard)
            //{
            //    lizard.Crawl();
            //}
            #endregion

            #region
            // Dynamic Decorator Composition
            //var square = new Square(1.23f);
            //Console.WriteLine(square.AsString());
            //var redSquare = new ColoredShape(square, "red");
            //Console.WriteLine(redSquare.AsString());
            //var redHalfTransperentSquare = new TransparentShape(redSquare, 50f);
            //Console.WriteLine(redHalfTransperentSquare.AsString()); 
            #endregion

            #region
            // Detecting Decorator Cycles.
            //var circle = new Circle(2);
            //var colored1 = new ColoredShape(circle, "red");
            //var colored2 = new ColoredShape(circle, "blue");

            //Console.WriteLine(circle.AsString());
            //Console.WriteLine(colored1.AsString());
            //Console.WriteLine(colored2.AsString());
            #endregion

            #region
            // Decorator in Dependency Injection
            var cb = new ContainerBuilder();
            cb.RegisterType<ReportingService>().Named<IReportingService>("reporting");
            cb.RegisterDecorator<IReportingService>(
                    (context, service) => new ReportingServiceWithLogging(service), "reporting"
                );

            using(var container = cb.Build())
            {
                var r = container.Resolve<IReportingService>();
                r.Report();
            }
            #endregion
            Console.ReadLine();
        }
    }
}
