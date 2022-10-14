using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ObserverDP_UdemyDesignPatterns_ConsoleApp.ObservableCollections
{
    public class Market  // observable
    {
        public BindingList<float> Prices = new BindingList<float>();
        public void AddPrice(float price)
        {
            Prices.Add(price);
        }
    }
}
