using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDP_UdemyDesignPatterns_ConsoleApp.Command
{
    public interface ICommand
    {
        void Call();
        void Undo();
    }
}
