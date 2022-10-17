using StrategyDP_UdemyDesignPatterns_ConsoleApp.Task.Interfaces;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

// Consider the quadratic equation and its canonical solution:

//The part b^2-4*a*c is called the discriminant.
//Suppose we want to provide an API with two different strategies for calculating the discriminant:

//In OrdinaryDiscriminantStrategy, If the discriminant is negative, we return it as-is. This is OK,
//since our main API returns Complex  numbers anyway.
//In RealDiscriminantStrategy , if the discriminant is negative, the return value is NaN (not a number).
//NaN propagates throughout the calculation, so the equation solver gives two NaN values.
//Please implement both of these strategies as well as the equation solver itself.
//With regards to plus-minus in the formula, please return the + result as the first element and - as the second.

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
