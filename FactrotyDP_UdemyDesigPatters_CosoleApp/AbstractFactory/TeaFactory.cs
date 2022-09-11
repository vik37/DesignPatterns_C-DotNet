using FactrotyDP_UdemyDesigPatters_CosoleApp.AbstractFactory.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactrotyDP_UdemyDesigPatters_CosoleApp.AbstractFactory
{
    internal class TeaFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Put in a tea bag, boil water, pour {amount} ml, add lemon and enjoy!");
            return new Tea();
        }
    }
}
