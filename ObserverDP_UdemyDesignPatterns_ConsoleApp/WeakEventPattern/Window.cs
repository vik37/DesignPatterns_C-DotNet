using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDP_UdemyDesignPatterns_ConsoleApp.WeakEventPattern
{
    public class Window
    {
        public Window(Button button)
        {
            button.Clicked += ButtonClicked;

            // Part of a indowsBase assembly - Dot Net Framework 4.5
            //WeakEventManager<Button,EventArgs>
            //    .AddHandler(button, "clicked",ButtonClicked)
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            Console.WriteLine("Button clicked (window handler)");
        }
        ~Window()
        {
            Console.WriteLine("Window finalized");
        }
    }
}
