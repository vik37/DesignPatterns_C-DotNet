using CommandDP_UdemyDesignPatterns_ConsoleApp.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using Action = CommandDP_UdemyDesignPatterns_ConsoleApp.Command.Action;

namespace CommandDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Command
            var ba = new BankAccount();
            var commands = new List<BankAccountCommand>()
            {
                new BankAccountCommand(ba, Action.Deposite, 100),
                new BankAccountCommand(ba, Action.Withdrow, 50)
            };
            Console.WriteLine(ba);
            foreach (var c in commands)
            {
                c.Call();
            }
            Console.WriteLine(ba);
            foreach (var c in Enumerable.Reverse(commands))
            {
                c.Undo();
            }
            Console.WriteLine(ba);
            #endregion
            Console.ReadLine();
        }
    }
}
