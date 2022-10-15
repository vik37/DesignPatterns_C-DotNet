using ObserverDP_UdemyDesignPatterns_ConsoleApp.Task;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestDP_Methods.Observable_Test
{
    public class ObservableDPTest
    {
        [Fact]
        public void ObservableTest_TheTest()
        {
            // Test the Test
            // Should pass
            //Assert.Equal(1, 1);

            // Should failed
            //Assert.Equal(1, 3);

            // Testing Observable Task - should failed
            //var game = new Game();

            //var rat1 = new Rat(game);
            //Assert.Equal(1, rat1.Attack);
            //var rat2 = new Rat(game);
            //Assert.Equal(1, rat1.Attack);
            //Assert.Equal(2, rat2.Attack);

            // Testing Observable Task - should pass
            var game = new Game();

            var rat1 = new Rat(game);
            Assert.Equal(1, rat1.Attack);
            var rat2 = new Rat(game);
            Assert.Equal(2, rat1.Attack);
            Assert.Equal(2, rat2.Attack);
            using (var rat3 = new Rat(game))
            {
                Assert.Equal(3, rat1.Attack);
                Assert.Equal(3, rat2.Attack);
                Assert.Equal(3, rat3.Attack);
            }
            Assert.Equal(2, rat1.Attack);
            Assert.Equal(2, rat2.Attack);
        }
        
    }
}
