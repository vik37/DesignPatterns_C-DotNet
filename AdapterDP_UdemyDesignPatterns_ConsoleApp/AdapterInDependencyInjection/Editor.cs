using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDP_UdemyDesignPatterns_ConsoleApp.AdapterInDependencyInjection
{
    public class Editor
    {
        private IEnumerable<Button> buttons;
        public IEnumerable<Button> Buttons { get { return buttons; } }
        public Editor(IEnumerable<Button> buttons)
        {
            this.buttons = buttons;
        }
        public void ClickAll()
        {
            foreach (var button in buttons)
            {
                button.Click();
            }
        }
    }
}
