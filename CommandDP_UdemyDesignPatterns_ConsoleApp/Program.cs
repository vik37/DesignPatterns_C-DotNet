//using CommandDP_UdemyDesignPatterns_ConsoleApp.Command;
using CommandDP_UdemyDesignPatterns_ConsoleApp.CompositeCommand;
using System;
using System.Collections.Generic;
using System.Linq;
//using Action = CommandDP_UdemyDesignPatterns_ConsoleApp.Command.Action;

namespace CommandDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Command
            //var ba = new BankAccount();
            //var commands = new List<BankAccountCommand>()
            //{
            //    new BankAccountCommand(ba, Action.Deposite, 100),
            //    new BankAccountCommand(ba, Action.Withdrow, 50)
            //};
            //Console.WriteLine(ba);
            //foreach (var c in commands)
            //{
            //    c.Call();
            //}
            //Console.WriteLine(ba);
            //foreach (var c in Enumerable.Reverse(commands))
            //{
            //    c.Undo();
            //}
            //Console.WriteLine(ba);
            #endregion

            #region Composite and Command dp
            var from = new BankAccount();
            from.Deposite(100);
            var to = new BankAccount();

            var mtc = new MoneyTransferCommand(from, to, 1000);
            mtc.Call();
            Console.WriteLine(from);
            Console.WriteLine(to);
            Console.WriteLine("------------  changed his mind about the transfer  :)  ------------");
            mtc.Undo();
            Console.WriteLine(from);
            Console.WriteLine(to);
            #endregion
            Console.ReadLine();
        }
    }
}
