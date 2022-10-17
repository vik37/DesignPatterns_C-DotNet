using StrategyDP_UdemyDesignPatterns_ConsoleApp.Task.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDP_UdemyDesignPatterns_ConsoleApp.Task
{
    public class OrdinaryDiscriminantStrategy : IDiscriminantStrategy
    {
        public double CalculateDiscriminant(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }
    }
}
