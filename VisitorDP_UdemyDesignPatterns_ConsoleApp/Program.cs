using System;
using System.Text;
using VisitorDP_UdemyDesignPatterns_ConsoleApp.Visitor;

namespace VisitorDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Intrusive Visitor
            var e = new AdditionExpression(
                new DoubleExpression(1),
                new AdditionExpression(
                    new DoubleExpression(2),
                    new DoubleExpression(3))
                );
            var sb = new StringBuilder();
            e.Print(sb);
            Console.WriteLine(sb);
            #endregion
            Console.ReadLine();
        }
    }
}
