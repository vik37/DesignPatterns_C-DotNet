using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectDP_UdemyDesignPatterns_ConsoleApp.NullObject_Demo
{
    public class BankAccount
    {
        private ILog log;
        private int balance;
        public BankAccount(ILog log)
        {
            this.log = log;
        }
        public void Deposit(int amount)
        {
            balance += amount;
            log.Info($"Deposited {amount}, balance is now {balance}");
        }
    }
}
