using FactrotyDP_UdemyDesigPatters_CosoleApp.AbstractFactory.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactrotyDP_UdemyDesigPatters_CosoleApp.AbstractFactory
{
    internal class CoffeFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Grind some beans, boil water, pour {amount} ml, add cream and suger and enjoy!");
            return new Coffe();
        }
    }
}
