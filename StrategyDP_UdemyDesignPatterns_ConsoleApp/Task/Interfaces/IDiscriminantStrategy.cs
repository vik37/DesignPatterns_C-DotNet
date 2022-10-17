using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDP_UdemyDesignPatterns_ConsoleApp.Task.Interfaces
{
    public interface IDiscriminantStrategy
    {
        double CalculateDiscriminant(double a, double b, double c);
    }
}
