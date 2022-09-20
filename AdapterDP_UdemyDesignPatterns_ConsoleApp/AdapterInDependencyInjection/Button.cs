using AdapterDP_UdemyDesignPatterns_ConsoleApp.AdapterInDependencyInjection.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDP_UdemyDesignPatterns_ConsoleApp.AdapterInDependencyInjection
{
    public class Button
    {
        private ICommand command;
        private string name;
        public Button(ICommand command, string name)
        {
            if (command == null)
            {
                throw new ArgumentNullException(paramName: nameof(command));
            }
            if (name == null)
            {
                throw new ArgumentNullException(paramName: nameof(name));
            }
            this.command = command;
            this.name = name;
        }
        public void Click()
        {
            command.Execute();
        }
        public void PrintMe()
        {
            Console.WriteLine($"I am a Button {name}");
        }
    }
}
