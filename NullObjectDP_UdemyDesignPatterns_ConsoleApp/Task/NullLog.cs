using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectDP_UdemyDesignPatterns_ConsoleApp.Task
{
    public class NullLog : ILog
    {
        public int RecordLimit { get; }

        public int RecordCount { get; set; }

        public void LogInfo(string message)
        { }
    }
}
