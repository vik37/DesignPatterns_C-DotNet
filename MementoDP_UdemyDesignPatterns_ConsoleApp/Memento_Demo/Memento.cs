using System;
using System.Collections.Generic;
using System.Text;

namespace MementoDP_UdemyDesignPatterns_ConsoleApp.Memento_Demo
{
    public class Memento
    {
        public int Balance { get; set; }
        public Memento(int balance)
        {
            Balance = balance;
        }
    }
}
