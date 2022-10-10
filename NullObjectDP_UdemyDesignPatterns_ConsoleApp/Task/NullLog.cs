using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectDP_UdemyDesignPatterns_ConsoleApp.Task
{
    public class NullLog : ILog
    {
        public int RecordLimit { get; } = int.MaxValue;

        public int RecordCount { get; set; } = int.MaxValue;

        public void LogInfo(string message)
        {
            ++RecordCount;
        }
    }
}
