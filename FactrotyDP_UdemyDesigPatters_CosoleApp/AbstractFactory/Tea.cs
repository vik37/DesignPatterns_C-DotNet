using FactrotyDP_UdemyDesigPatters_CosoleApp.AbstractFactory.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactrotyDP_UdemyDesigPatters_CosoleApp.AbstractFactory
{
    internal class Tea : IHotDrink
    {
        public void Consum()
        {
            Console.WriteLine("This tea is nice but I'd prefer it with milk.");
        }
    }
}
