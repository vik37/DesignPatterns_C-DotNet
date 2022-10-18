using ChainOfResponsibility_UdemyDesignPatterns_ConsoleApp.Task;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestDP_Methods.ChainOfResponsibility_Test
{
    
    public class ChangeOfResponsibilityDPTest
    {
        [Theory]
        // Here should pass
        [InlineData(1,1)]
        // Here should failed
        //[InlineData(1,2)]
        //[InlineData(2,1)]
        public void CreatureGameTestGoblin_Test(int attack, int defence)
        {
            // Arrange

            // Action
            var game = new Game();
            var goblin = new Goblin(game);
            game.Creatures.Add(goblin);
            //  Assert
            Assert.Equal(goblin.Attack,attack);
            Assert.Equal(goblin.Defence, defence);
        }
        [Fact]
        public void CreatureGameTestGoblinWithKingGoblin_Test()
        {
            // Arrange
            int attack = 1;
            int defence = 1;
            // Action
            var game = new Game();
            var goblin = new Goblin(game);
            game.Creatures.Add(goblin);
            //  Assert
            Assert.Equal(goblin.Attack, attack);
            Assert.Equal(goblin.Defence, defence);

            // -------------------------------------

            // Arrange
            attack = 2;
            defence = 3;
            // Action
            var goblin2 = new Goblin(game);
            game.Creatures.Add(goblin2);
            var GoblinKing = new GoblinKing(game);
            game.Creatures.Add(GoblinKing);
            //  Assert
            Assert.Equal(goblin.Attack, attack);
            Assert.Equal(goblin.Defence, defence);
        }
    }
}
