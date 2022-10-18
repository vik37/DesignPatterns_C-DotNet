using System;
using System.Collections.Generic;
using System.Text;
using TamplateMethodDP_UdemyDesignPatterns_ConsoleApp.Task;
using Xunit;

namespace TestDP_Methods.TemplateMethodTesting
{
    public class TemplateMethodDPTest
    {
        [Fact]
        public void TemplateMethodDB_TestTheTask_ImpaseTest()
        {
            var c1 = new Creature(1, 2);
            var c2 = new Creature(1, 2);
            CardGame game = new TemporaryCardDamageGame(new[] { c1, c2 });
            Assert.Equal(-1, game.Combat(0, 1));
            Assert.Equal(-1, game.Combat(0, 1));
        }
        [Fact]
        public void TemplateMethodDB_TestTheTask_TemporaryMurderTest()
        {
            var c1 = new Creature(1, 1);
            var c2 = new Creature(2, 2);
            CardGame game = new TemporaryCardDamageGame(new[] { c1, c2 });
            Assert.Equal(1, game.Combat(0, 1));
        }
        [Fact]
        public void TemplateMethodDB_TestTheTask_DoubleMurderTest()
        {
            var c1 = new Creature(2, 2);
            var c2 = new Creature(2, 2);
            CardGame game = new TemporaryCardDamageGame(new[] { c1, c2 });
            Assert.Equal(-1, game.Combat(0, 1));
        }
        [Fact]
        public void TemplateMethodDB_TestTheTask_PermanentDamageDeathTest()
        {
            var c1 = new Creature(1, 2);
            var c2 = new Creature(1, 3);
            CardGame game = new PermanentCardDamage(new[] { c1, c2 });
            Assert.Equal(-1, game.Combat(0, 1));
            Assert.Equal(1, game.Combat(0, 1));
        }
    }
}
