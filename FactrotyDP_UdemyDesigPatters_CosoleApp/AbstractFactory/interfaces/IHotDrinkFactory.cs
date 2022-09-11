using System;
using System.Collections.Generic;
using System.Text;

namespace FactrotyDP_UdemyDesigPatters_CosoleApp.AbstractFactory.interfaces
{
    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }
}
