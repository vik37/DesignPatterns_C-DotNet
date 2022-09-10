using System;

namespace BuilderDP_Homework
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int")
                                                .AddField("IsItGirl","boolean");
            Console.WriteLine(cb.ToString());
            Console.ReadLine();
        }
    }
}
