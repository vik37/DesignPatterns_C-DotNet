using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDP_UdemyDesignPatterns_ConsoleApp.CompositeCommand
{
    public interface ICommand
    {
        void Call();
        void Undo();
        public bool Success { get; set; }
    }
}
