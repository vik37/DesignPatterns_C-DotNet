using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDP_UdemyDesignPatterns_ConsoleApp.Command
{
    public class BankAccountCommand : ICommand
    {
        private BankAccount account;
        private Action action;
        private int amount;
        private bool succeded;
        public BankAccountCommand(BankAccount account, Action action, int amount)
        {
            this.account = account;
            this.action = action;
            this.amount = amount;
        }

        public void Call()
        {
            switch (action)
            {
                case Action.Deposite:
                    account.Deposite(amount);
                    succeded = true;
                    break;
                case Action.Withdrow:
                    succeded = account.Withdrow(amount);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        public void Undo()
        {
            if(!succeded) return;
            switch (action)
            {
                case Action.Deposite:
                    account.Withdrow(amount);
                    break;
                case Action.Withdrow:
                    account.Deposite(amount);
                    break;
                default:
                    break;
            }
        }
    }
}
