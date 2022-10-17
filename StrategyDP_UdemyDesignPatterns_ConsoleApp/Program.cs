using StrategyDP_UdemyDesignPatterns_ConsoleApp.DynamicAndStaticStrategy;
using StrategyDP_UdemyDesignPatterns_ConsoleApp.DynamicAndStaticStrategy.Enums;
using StrategyDP_UdemyDesignPatterns_ConsoleApp.EqualityAndComparation;
using StrategyDP_UdemyDesignPatterns_ConsoleApp.Task;
using StrategyDP_UdemyDesignPatterns_ConsoleApp.Task.Interfaces;
using System;
using System.Collections.Generic;

namespace StrategyDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dynamic Strategy
            //var tp = new TextProccessor();
            //tp.SetOutpuFormat(OutputFormat.Markdown);
            //tp.AppendList(new[] { "foo", "bar", "baz" });
            //Console.WriteLine(tp);

            //tp.Clear();
            //tp.SetOutpuFormat(OutputFormat.Html);
            //tp.AppendList(new[] { "foo", "bar", "baz" });
            //Console.WriteLine(tp);
            #endregion

            #region Static Strategy
            //var tpMark = new TextProccessor<MarkdownListStrategy>();
            //tpMark.AppendList(new[] { "foo", "bar", "baz" });
            //Console.WriteLine(tpMark);
            //Console.WriteLine("-----------------------------");
            //var tpHtml = new TextProccessor<HtmlListStrategy>();
            //tpHtml.AppendList(new[] { "foo", "bar", "baz" });
            //Console.WriteLine(tpHtml);
            #endregion

            #region Equality and Comparation Strategies
            //var people = new List<Person>();

            //people.Sort();  // default strategy

            //people.Sort((x,y) => x.Name.CompareTo(y.Name));  // strategy by lambda
            //people.Sort(Person.NameComparer);

            // Strategy using by Dot Net Framework. 
            #endregion

            #region Task
            IDiscriminantStrategy ordinaryStrategy = new OrdinaryDiscriminantStrategy();
            var solver = new QuadraticEquationSolver(ordinaryStrategy);
            var result = solver.Solve(1, 4, 5);
            Console.WriteLine(result);
            var realStrategy = new RealDiscriminantStrategy();
            solver = new QuadraticEquationSolver(realStrategy);
            result = solver.Solve(1, -4, 5);
            Console.WriteLine(result);
            #endregion
            Console.ReadLine();
        }
    }
}
