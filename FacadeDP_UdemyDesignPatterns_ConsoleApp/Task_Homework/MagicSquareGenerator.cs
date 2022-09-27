using FacadeDP_UdemyDesignPatterns_ConsoleApp.Task_Homework.Facade;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDP_UdemyDesignPatterns_ConsoleApp.Task_Homework
{
    public class MagicSquareGenerator
    {
        public List<List<int>> Generate(int size)
        {
            var g = new Generator();
            var s = new Splitter();
            var v = new Verifier();

            var square = new List<List<int>>();

            do
            {
                square = new List<List<int>>();
                for (int i = 0; i < size; ++i)
                    square.Add(g.Generate(size));
            } while (!v.Verify(s.Split(square)));

            return square;
        }
        
    }
}
