using Autofac;
using NullObjectDP_UdemyDesignPatterns_ConsoleApp.Task;
//using NullObjectDP_UdemyDesignPatterns_ConsoleApp.NullObjectSingleton;
//using NullObjectDP_UdemyDesignPatterns_ConsoleApp.NullObject_Demo;
using System;

namespace NullObjectDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Null Object
            //var cb = new ContainerBuilder();
            //cb.RegisterType<BankAccount>();
            //cb.RegisterType<NullLog>().As<ILog>();
            //using(var c = cb.Build())
            //{
            //    var ba = c.Resolve<BankAccount>();
            //    ba.Deposit(100);
            //}
            #endregion

            #region Null object Singleton
            //ILog log = ILog.Null;
            ILog log = new NullLog();
            var acc = new Account(log);
            acc.SomeOperation();

            #endregion
            Console.ReadLine();
        }
    }
}
