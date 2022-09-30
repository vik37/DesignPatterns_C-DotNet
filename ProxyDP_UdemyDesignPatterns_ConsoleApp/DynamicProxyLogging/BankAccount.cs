﻿using ProxyDP_UdemyDesignPatterns_ConsoleApp.DynamicProxyLogging.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyDP_UdemyDesignPatterns_ConsoleApp.DynamicProxyLogging
{
    public class BankAccount : IBankAccount
    {
        private int balance;
        private int overdraftLimit = 500;
        public void Deposit(int amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount}, balance is now {balance}");
        }

        public bool Withdraw(int amount)
        {
            if(balance - amount >= overdraftLimit)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew {amount}, balance is now {balance}");
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return $"{nameof(balance)}: {balance}";
        }
    }
}
