using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadeDP_UdemyDesignPatterns_ConsoleApp.Task_Homework.Facade
{
    public class Verifier
    {
        public bool Verify(List<List<int>> array)
        {
            if (!array.Any()) return false;

            var expected = array.First().Sum();

            return array.All(t => t.Sum() == expected);
        }
    }
}
