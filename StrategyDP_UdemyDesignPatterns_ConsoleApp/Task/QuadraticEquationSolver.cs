using StrategyDP_UdemyDesignPatterns_ConsoleApp.Task.Interfaces;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace StrategyDP_UdemyDesignPatterns_ConsoleApp.Task
{
    public class QuadraticEquationSolver
    {
        private readonly IDiscriminantStrategy strategy;
        public QuadraticEquationSolver(IDiscriminantStrategy strategy)
        {
            this.strategy = strategy;
        }
        public Tuple<Complex, Complex> Solve(double a, double b, double c)
        {
            var disc = new Complex(strategy.CalculateDiscriminant(a, b, c), 0);
            var root = Complex.Sqrt(disc);
            return Tuple.Create(
                  (-b + root) / (2 * a),
                  (-b - root) / (2 * a)
                );
        }
    }
}
