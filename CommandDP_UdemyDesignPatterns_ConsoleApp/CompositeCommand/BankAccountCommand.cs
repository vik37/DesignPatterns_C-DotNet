using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDP_UdemyDesignPatterns_ConsoleApp.CompositeCommand
{
    public class BankAccountCommand : ICommand
    {
        private BankAccount account;
        private Action action;
        private int amount;
        public BankAccountCommand(BankAccount account, Action action, int amount)
        {
            this.account = account;
            this.action = action;
            this.amount = amount;
        }

        public bool Success { get; set; }

        public void Call()
        {
            switch (action)
            {
                case Action.Deposite:
                    account.Deposite(amount);
                    Success = true;
                    break;
                case Action.Withdrow:
                    Success = account.Withdrow(amount);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void Undo()
        {
            if (!Success) return;
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

        public enum Action
        {
            Deposite, Withdrow
        }
    }
}
