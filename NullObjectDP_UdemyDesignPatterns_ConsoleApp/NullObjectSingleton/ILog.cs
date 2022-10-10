using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectDP_UdemyDesignPatterns_ConsoleApp.NullObjectSingleton
{
    public interface ILog
    {
        void Warn();
        public static ILog Null => NullLog.Instance;
        private sealed class NullLog : ILog
        {
            private static Lazy<NullLog> instance = new Lazy<NullLog>(() => new NullLog());
                 
            public static ILog Instance => instance.Value;
            private NullLog() { }

            public void Warn()
            { }
        }
    }
}
