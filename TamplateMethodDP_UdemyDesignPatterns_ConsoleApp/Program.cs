using System;
using TamplateMethodDP_UdemyDesignPatterns_ConsoleApp.Task;
using TamplateMethodDP_UdemyDesignPatterns_ConsoleApp.TemplateMethod;

namespace TamplateMethodDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Template Method
            //var chess = new Chess();
            //chess.Run();
            #endregion
            //var c1 = new Creature(4, 2);
            //var c2 = new Creature(3, 5);
            //CardGame game = new TemporaryCardDamageGame(new[] { c1, c2 });
            //Console.WriteLine(game.Combat(0, 1));

            var c1 = new Creature(1, 2);
            var c2 = new Creature(1, 3);
            CardGame game = new PermanentCardDamage(new[] { c1, c2 });
            Console.WriteLine(game.Combat(0, 1));
            #region Task

            #endregion
            Console.ReadLine();
        }
    }
}
