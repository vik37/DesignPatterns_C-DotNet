using System;
using System.Diagnostics;
using UDemy_DesignnPattersAndPrinciples_ConsoleApp.SingleResponsibbility;

namespace UDemy_DesignnPattersAndPrinciples_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            // Single Responsibility Principle

            var j = new Journal();
            j.AddEntry("I was try to cry!");
            j.AddEntry("I ate a bbug!");

            
            Console.WriteLine(j);
            var p = new Persistence();
            string filename = @"journal.txt";
            p.SaveToFile(j, filename, true);
           // Process.Start(filename);
            Console.ReadLine();
            #endregion
        }
    }
}
