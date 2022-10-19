using System;
using System.Text;
using VisitorDP_UdemyDesignPatterns_ConsoleApp.AcyclicVisitor;
//using VisitorDP_UdemyDesignPatterns_ConsoleApp.ReductionsAndTransformations;
//using VisitorDP_UdemyDesignPatterns_ConsoleApp.ReflectiveVisitor;
//using VisitorDP_UdemyDesignPatterns_ConsoleApp.Visitor;

namespace VisitorDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Intrusive Visitor
            //var e = new AdditionExpression(
            //    new DoubleExpression(1),
            //    new AdditionExpression(
            //        new DoubleExpression(2),
            //        new DoubleExpression(3))
            //    );
            //var sb = new StringBuilder();
            //e.Print(sb);
            //Console.WriteLine(sb);
            #endregion

            #region Reflective Visitor
            //var sb = new StringBuilder();
            //var e = new AdditionalExpression(
            //    new DoubleExpression(1),
            //    new AdditionalExpression(
            //        new DoubleExpression(2),
            //        new DoubleExpression(3))
            //    );
            //ExpressionPrinter.Print(e, sb);
            //Console.WriteLine(sb);
            #endregion

            #region Classic Visitor (Double Dispatch)
            //var e = new AdditionalExpression(
            //    new DoubleExpression(1),
            //    new AdditionalExpression(
            //        new DoubleExpression(2),
            //        new DoubleExpression(3))
            //    );
            //var ep = new ExpressionPrinterForVisitor();
            //ep.Visit(e);
            //Console.WriteLine(ep);

            //var calc = new ExpressionCalculator();
            //calc.Visit(e);
            //Console.WriteLine($"{ep} = {calc.Result}");
            #endregion

            #region Reductions and Transformations
            //var exp = new AdditionalExpression(
            //    new DoubleExpression(1), new DoubleExpression(2));
            //var et = new EvaluationTransformer();
            //var result = exp.Reduce(et);
            //var pt = new PrintTransformer();
            //var text = exp.Reduce(pt);
            //Console.WriteLine($"{text} = {result}");

            //var st = new SquareTransformer();
            //Expression newExp = exp.Reduce(st);
            //text = newExp.Reduce(pt);
            //Console.WriteLine($"{text}");
            #endregion

            #region Acyclic Visitor
            var e = new AdditionExpression(
                left: new DoubleExpression(1),
                right: new AdditionExpression(
                    left: new DoubleExpression(2),
                    right: new DoubleExpression(3)));
            var ep = new ExpressionPrinter();
            ep.Visit(e);
            Console.WriteLine(ep.ToString());
            #endregion
            Console.ReadLine();
        }
    }
}
