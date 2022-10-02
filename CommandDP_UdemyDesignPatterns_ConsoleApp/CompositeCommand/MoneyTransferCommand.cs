using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDP_UdemyDesignPatterns_ConsoleApp.CompositeCommand
{
    public class MoneyTransferCommand : CompositeBankAccountCommand
    {
        public MoneyTransferCommand(BankAccount from, BankAccount to, int amount)
        {
            AddRange(new[]
            {
                new BankAccountCommand(from,BankAccountCommand.Action.Withdrow,
                                        amount),
                new BankAccountCommand(to,BankAccountCommand.Action.Deposite,
                                        amount)
            });
        }
        public override void Call()
        {
            BankAccountCommand last = null;
            foreach (var cmd in this)
            {
                if(last == null || last.Success)
                {
                    cmd.Call();
                    last = cmd;
                }
                else
                {
                    cmd.Undo();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Transfer failed!!!");
                    Console.ResetColor();
                    break;
                }
            }
        }
    }
}
