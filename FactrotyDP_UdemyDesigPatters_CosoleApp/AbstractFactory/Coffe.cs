using FactrotyDP_UdemyDesigPatters_CosoleApp.AbstractFactory.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactrotyDP_UdemyDesigPatters_CosoleApp.AbstractFactory
{
    internal class Coffe : IHotDrink
    {
        public void Consum()
        {
            Console.WriteLine("This coffe is sensational!");
        }
    }
}
