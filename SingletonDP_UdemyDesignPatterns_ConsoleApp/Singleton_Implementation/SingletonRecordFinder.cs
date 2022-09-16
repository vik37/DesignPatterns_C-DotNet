using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDP_UdemyDesignPatterns_ConsoleApp.Singleton_Implementation
{
    public class SingletonRecordFinder
    {
        public int GetTotalPopulation(IEnumerable<string> names)
        {
            int result = 0;
            foreach (var name in names)
            {
                result += SingletonDatabase.Instance.GetPopulation(name);
            }
            return result;
        }
    }
}
