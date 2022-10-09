using MementoDP_UdemyDesignPatterns_ConsoleApp.Memento_Demo;
using System;

namespace MementoDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Memento
            //var ba = new BankAccount(100);
            //var m1 = ba.Deposit(50); // 150
            //var m2 = ba.Deposit(25); // 175
            //Console.WriteLine(ba);

            //ba.Restore(m1);
            //Console.WriteLine(ba);

            //ba.Restore(m2);
            //Console.WriteLine(ba);
            #endregion

            #region Undo and Redo
            var ba = new BankAccount(100);
            ba.Deposit(50);
            ba.Deposit(25);
            Console.WriteLine(ba);

            ba.Undo();
            Console.WriteLine($"1st Undo: {ba}");
            ba.Undo();
            Console.WriteLine($"2nd Undo: {ba}");
            ba.Redo();
            Console.WriteLine($"1st Redo: {ba}");
            #endregion  
            Console.ReadLine();
        }
    }
}
