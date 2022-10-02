using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDP_UdemyDesignPatterns_ConsoleApp.CompositeCommand
{
    public class BankAccount
    {
        private int balance;
        private int overdraftLimit = -500;
        public void Deposite(int amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount}$, balance is now {balance}$");
        }
        public bool Withdrow(int amount)
        {
            if (balance - amount >= overdraftLimit)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew {amount}$, balance is now {balance}$");
                return true;
            }
            else return false;
        }
        public override string ToString()
        {
            return $"{nameof(balance)}: {balance}$";
        }
    }
}
