using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDP_UdemyDesignPatterns_ConsoleApp.WeakEventPattern
{
    public class Button
    {
        public event EventHandler Clicked;
        public void Fired()
        {
            Clicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
