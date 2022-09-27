using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadeDP_UdemyDesignPatterns_ConsoleApp.Task_Homework.Facade
{
    //makes an array of random digits (suitably constrained) of a particular length.
    public class Generator
    {
        private static readonly Random random = new Random();

        public List<int> Generate(int count)
        {
            return Enumerable.Range(0, count)
              .Select(_ => random.Next(1, 6))
              .ToList();
        }
    }
}
