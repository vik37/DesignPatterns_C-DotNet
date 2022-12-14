//using ChainOfResponsibility_UdemyDesignPatterns_ConsoleApp.MethodChain;
//using ChainOfResponsibility_UdemyDesignPatterns_ConsoleApp.BrokenChain;
using ChainOfResponsibility_UdemyDesignPatterns_ConsoleApp.Task;
using System;

namespace ChainOfResponsibility_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Method Chain
            //var goblin = new Creature("Goblin", 2, 2);
            //Console.WriteLine(goblin);
            //var root = new CreatureModifier(goblin);
            ////root.Add(new NoBonusesModifier(goblin));
            //Console.WriteLine("Let's doubled the goblin's attack");
            //root.Add(new DoubleAttack(goblin));
            //Console.WriteLine("Let's increase the goblin's defence");
            //root.Add(new IncreasedDeffenceModifier(goblin));
            //root.Handle();
            //Console.WriteLine(goblin);
            #endregion

            #region Broken Chain
            //var game = new Game();
            //var goblin = new Creature(game, "Goblin", 2, 2);
            //Console.WriteLine(goblin);
            //using(new DoubleAttackModifier(game, goblin))
            //{
            //    Console.WriteLine(goblin);
            //    using(new IncreaseModifier(game, goblin))
            //    {
            //        Console.WriteLine(goblin);
            //    }
            //}
            //Console.WriteLine(goblin);
            #endregion

            #region Task
            var game = new Game();
            var goblin = new Goblin(game);
            game.Creatures.Add(goblin);
            var goblin2 = new Goblin(game);
            game.Creatures.Add(goblin2);
            var GoblinKing = new GoblinKing(game);
            game.Creatures.Add(GoblinKing);
             
            foreach (var creatures in game.Creatures)
            {
                Console.WriteLine(creatures);
            }
            #endregion
            Console.ReadLine();
        }
    }
}
