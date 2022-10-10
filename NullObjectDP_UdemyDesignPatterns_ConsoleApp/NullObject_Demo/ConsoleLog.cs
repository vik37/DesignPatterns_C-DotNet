using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace NullObjectDP_UdemyDesignPatterns_ConsoleApp.NullObject_Demo
{
    public class ConsoleLog : ILog
    {
        public void Info(string msg)
        {
            WriteLine(msg);
        }

        public void Warn(string msg)
        {
            WriteLine("WARNING!!! " + msg);
        }
    }
}
