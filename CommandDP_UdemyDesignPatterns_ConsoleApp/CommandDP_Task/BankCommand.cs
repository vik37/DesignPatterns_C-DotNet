using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDP_UdemyDesignPatterns_ConsoleApp.CommandDP_Task
{
    public class BankCommand
    {
        public enum Action
        {
            Deposit,
            Withdraw
        }

        public Action TheAction;
        public int Amount;
        public bool Success;
    }
}
