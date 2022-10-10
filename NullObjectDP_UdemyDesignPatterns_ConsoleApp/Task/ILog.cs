using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectDP_UdemyDesignPatterns_ConsoleApp.Task
{
    public interface ILog
    {
        // maximum # of elements in the log
        int RecordLimit { get; }

        // number of elements already in the log
        int RecordCount { get; set; }

        // expected to increment RecordCount
        void LogInfo(string message);
    }
}
