using BuilderDP_UdemyDesignPatterns_ConsoleApp.HtmlBuilder;
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
            var builder = new HtmlBuilderTags("ul");
            builder.AddChild("li","Hello").AddChild("li", "World");
            Console.WriteLine(builder.ToString());
            #endregion
            Console.ReadLine();
        }
    }
}
