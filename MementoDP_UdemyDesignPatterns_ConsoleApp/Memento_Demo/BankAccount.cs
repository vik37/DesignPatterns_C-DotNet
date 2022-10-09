using System;
using System.Collections.Generic;
using System.Text;

namespace MementoDP_UdemyDesignPatterns_ConsoleApp.Memento_Demo
{
    public class BankAccount
    {
        private int balance;
        public BankAccount(int balance)
        {
            this.balance = balance;
        }
        public Memento Deposit(int amount)
        {
            balance += amount;
            return new Memento(balance);
        }
        public void Restore(Memento m)
        {
            balance = m.Balance;
        }
        public override string ToString()
        {
            return $"{nameof(balance)}: {balance}";
        }
    }
}
