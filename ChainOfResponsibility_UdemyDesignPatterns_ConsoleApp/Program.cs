﻿using System;

namespace ChainOfResponsibility_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Method Chain
            var goblin = new Creature("Goblin", 2, 2);
            Console.WriteLine(goblin);
            var root = new CreatureModifier(goblin);
            //root.Add(new NoBonusesModifier(goblin));
            Console.WriteLine("Let's doubled the goblin's attack");
            root.Add(new DoubleAttack(goblin));
            Console.WriteLine("Let's increase the goblin's defence");
            root.Add(new IncreasedDeffenceModifier(goblin));
            root.Handle();
            Console.WriteLine(goblin);
            #endregion
            Console.ReadLine();
        }
    }
}