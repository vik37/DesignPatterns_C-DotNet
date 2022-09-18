using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SingletonDP_UdemyDesignPatterns_ConsoleApp.PerThread_Singleton
{
    public sealed class PerThreadSingleton
    {
        private static ThreadLocal<PerThreadSingleton> instance
            = new ThreadLocal<PerThreadSingleton>(
                () => new PerThreadSingleton());
        public int Id;
        private PerThreadSingleton() 
        {
            Id = Thread.CurrentThread.ManagedThreadId;
        }
        public static PerThreadSingleton Instance => instance.Value;
    }
}
