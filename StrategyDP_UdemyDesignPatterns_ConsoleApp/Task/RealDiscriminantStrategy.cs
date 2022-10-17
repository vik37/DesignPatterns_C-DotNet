using StrategyDP_UdemyDesignPatterns_ConsoleApp.Task.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDP_UdemyDesignPatterns_ConsoleApp.Task
{
    public class RealDiscriminantStrategy : IDiscriminantStrategy
    {
        public double CalculateDiscriminant(double a, double b, double c)
        {
            double result = b * b - 4 * a * c;
            return result > 0 ? result : double.NaN;
        }
    }
}
