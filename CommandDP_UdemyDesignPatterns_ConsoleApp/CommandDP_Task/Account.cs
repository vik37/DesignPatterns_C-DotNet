using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDP_UdemyDesignPatterns_ConsoleApp.CommandDP_Task
{
    public class Account
    {
        public int Balance { get; set; }

        public void Process(BankCommand c)
        {
            switch (c.TheAction)
            {
                case BankCommand.Action.Deposit:
                    Balance += c.Amount;
                    c.Success = true;
                    break;
                case BankCommand.Action.Withdraw:
                    c.Success = Balance >= c.Amount;
                    if (c.Success) Balance -= c.Amount;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        public override string ToString()
        {
            return $"{nameof(Balance)}: {Balance}";
        }
    }
}
