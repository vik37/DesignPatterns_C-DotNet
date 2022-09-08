using BuilderDP_UdemyDesignPatterns_ConsoleApp.FunctionalBuilder;
using BuilderDP_UdemyDesignPatterns_ConsoleApp.HtmlBuilder;
using BuilderDP_UdemyDesignPatterns_ConsoleApp.PersonBuilder;
using BuilderDP_UdemyDesignPatterns_ConsoleApp.StepwiseBuilder;
using BuilderDP_UdemyDesignPatterns_ConsoleApp.StepwiseBuilder.enums;
using System;
using System.Text;

namespace BuilderDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            // Simple.
            //string hello = "hello";
            //var sb = new StringBuilder();
            //sb.Append("<p>");
            //sb.Append(hello);
            //sb.Append("</p>");
            //Console.WriteLine(sb);

            //var words = new string[] { "Hello", "World" };
            //sb.Clear();
            //sb.Append("<ul>");
            //foreach (var word in words)
            //{
            //    sb.AppendFormat("<li>{0}</li>", word);
            //}
            //sb.Append("</ul>");
            //Console.WriteLine(sb);
            #endregion
            #region
            // With builder design pattern.
            //var builder = new HtmlBuilderTags("ul");
            //builder.AddChild("li","Hello").AddChild("li", "World");
            //Console.WriteLine(builder.ToString());
            #endregion
            #region
            // Recursive generics fluent interface
            //var me = Person.New.Called("Viktor")
            //                    .WorskAsA("Software Developer")
            //                    .Build();
            //Console.WriteLine(me);
            #endregion
            #region
            // Stepwise Builder
            //var car = CarBuilder.Create() // Will get (return) ISpecifyCarType.
            //                    .OfType(CarType.Crossover)  // Will get (return) ISpecifyWheelSize.
            //                    .WithWeels(18) // Will get (return) IBuildCar.
            //                    .Build();
            //Console.WriteLine(car);
            #endregion
            #region
            // Functional Builder DP
            var person = new PersonBuild()
                                .Called("Sarah")
                                .WorksAs("Software Developer")
                                .Build();
            Console.WriteLine(person);
            #endregion
            Console.ReadLine();
        }
    }
}
