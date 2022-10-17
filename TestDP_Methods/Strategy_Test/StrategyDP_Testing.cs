using StrategyDP_UdemyDesignPatterns_ConsoleApp.Task;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Xunit;

namespace TestDP_Methods.Strategy_Test
{
    public class StrategyDP_Testing
    {
        [Theory]
        [InlineData(1,4,5,-2,1,-2,-1)]
        [InlineData(1, 10, 16, -2, 0, -8, 0)]
        public void StrategyTask_TestOrdinaryDiscriminantStrategy(
                    double a, double b, double c, 
                    double item1_exp1, double item1_exp2, double item2_exp1, double item2_exp2)
        {
            var strategy = new OrdinaryDiscriminantStrategy();
            var solver = new QuadraticEquationSolver(strategy);
            var result = solver.Solve(a,b,c);
            Assert.Equal(result.Item1, new Complex(item1_exp1,item1_exp2));
            Assert.Equal(result.Item2, new Complex(item2_exp1,item2_exp2));
        }
        [Theory]
        [InlineData(1, 10, 16, -2, 0, -8, -0)]
        [InlineData(1, 4, 5, double.NaN,double.NaN,double.NaN,double.NaN)]
        public void StrategyTask_TestRealDiscriminantStrategy(
                    double a, double b, double c,
                    double item1_exp1, double item1_exp2, double item2_exp1, double item2_exp2)
        {
            var strategy = new RealDiscriminantStrategy();
            var solver = new QuadraticEquationSolver(strategy);
            var result = solver.Solve(a, b, c);
            Assert.Equal(result.Item1, new Complex(item1_exp1, item1_exp2));
            Assert.Equal(result.Item2, new Complex(item2_exp1, item2_exp2));           
        }
        [Fact]
        public void StrategyTask_TestIsNun()
        {
            var strategy = new RealDiscriminantStrategy();
            var solver = new QuadraticEquationSolver(strategy);
            var results = solver.Solve(1, 4, 5);
            Assert.True(double.IsNaN(results.Item1.Real));
            Assert.True(double.IsNaN(results.Item1.Imaginary));
            Assert.True(double.IsNaN(results.Item2.Real));
            Assert.True(double.IsNaN(results.Item2.Imaginary));
        }
    }
}
