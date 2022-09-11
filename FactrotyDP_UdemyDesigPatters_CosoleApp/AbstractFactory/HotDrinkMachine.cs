using FactrotyDP_UdemyDesigPatters_CosoleApp.AbstractFactory.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactrotyDP_UdemyDesigPatters_CosoleApp.AbstractFactory
{
    public class HotDrinkMachine
    {
        public enum AvailableDrink
        {
            Coffe, Tea
        }
        private Dictionary<AvailableDrink, IHotDrinkFactory> factories = 
            new Dictionary<AvailableDrink, IHotDrinkFactory>();
        public HotDrinkMachine()
        {
            foreach (AvailableDrink drink in Enum.GetValues(typeof(AvailableDrink)))
            {
                var factory = (IHotDrinkFactory)Activator.CreateInstance(
                        Type.GetType("FactrotyDP_UdemyDesigPatters_CosoleApp.AbstractFactory." + Enum.GetName(typeof(AvailableDrink), drink) + "Factory")
                    );
                factories.Add(drink, factory);  
            }
        }
        public IHotDrink MakeDrink(AvailableDrink drink, int amount)
        {
            return factories[drink].Prepare(amount);
        }
    }
}
