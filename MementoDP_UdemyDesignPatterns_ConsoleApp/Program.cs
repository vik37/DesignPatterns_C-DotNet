//using MementoDP_UdemyDesignPatterns_ConsoleApp.Memento_Demo;
using MementoDP_UdemyDesignPatterns_ConsoleApp.Task;
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
            //var ba = new BankAccount(100);
            //ba.Deposit(50);
            //ba.Deposit(25);
            //Console.WriteLine(ba);

            //ba.Undo();
            //Console.WriteLine($"1st Undo: {ba}");
            //ba.Undo();
            //Console.WriteLine($"2nd Undo: {ba}");
            //ba.Redo();
            //Console.WriteLine($"1st Redo: {ba}");
            #endregion

            #region Task
            var tm1 = new TokenMachine();
            tm1.AddToken(1);
            var m1 = tm1.AddToken(2);
            tm1.AddToken(3);
            tm1.Revert(m1);
            Console.WriteLine(tm1.Tokens.Count);
            Console.WriteLine(tm1.Tokens[0].Value);
            Console.WriteLine(tm1.Tokens[1].Value);

            Console.WriteLine("------------------------------");
            //---------------------------------------

            var tm2 = new TokenMachine();
            var token = new Token(111);
            tm2.AddToken(token);
            var m2 = tm2.AddToken(222);
            token.Value = 333;
            tm2.Revert(m2);
            Console.WriteLine(tm2.Tokens.Count);
            Console.WriteLine(tm2.Tokens[0].Value);
            #endregion
            Console.ReadLine();
        }
    }
}
