using StrategyDP_UdemyDesignPatterns_ConsoleApp.DynamicAndStaticStrategy;
using StrategyDP_UdemyDesignPatterns_ConsoleApp.DynamicAndStaticStrategy.Enums;
using System;

namespace StrategyDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dynamic and Static Strategy
            var tp = new TextProccessor();
            tp.SetOutpuFormat(OutputFormat.Markdown);
            tp.AppendList(new[] { "foo", "bar", "baz" });
            Console.WriteLine(tp);

            tp.Clear();
            tp.SetOutpuFormat(OutputFormat.Html);
            tp.AppendList(new[] { "foo", "bar", "baz" });
            Console.WriteLine(tp);
            #endregion

            #region Equality and Comparation Strategies

            #endregion

            #region Task

            #endregion
            Console.ReadLine();
        }
    }
}
