using StateDP_UdemyDesignPatterns_ConsoleApp.Task;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestDP_Methods.StateDP_Test
{
    public class TestingStateDesignPattern
    {
        [Fact]
        public void Test_TheTask()
        {
            var cml = new CombinationLock(new[] { 1, 2, 3, 4, 5 });
            Assert.Equal("LOCKED",cml.Status);
            cml.EnterDigit(1);
            Assert.Equal("1",cml.Status);
            cml.EnterDigit(2);
            Assert.Equal("12", cml.Status);
            cml.EnterDigit(3);
            Assert.Equal("123", cml.Status);
            cml.EnterDigit(4);
            Assert.Equal("1234", cml.Status);
            cml.EnterDigit(5);
            Assert.Equal("OPEN", cml.Status);
        }
        [Fact]
        public void Test_TheTaskWithError()
        {
            var cml = new CombinationLock(new[] { 1, 2, 3, 4, 5 });
            Assert.Equal("LOCKED", cml.Status);
            cml.EnterDigit(1);
            Assert.Equal("1", cml.Status);
            cml.EnterDigit(2);
            Assert.Equal("12", cml.Status);
            cml.EnterDigit(4);
            Assert.Equal("ERROR", cml.Status);
            cml.EnterDigit(4);
            Assert.Equal("ERROR", cml.Status);
            cml.EnterDigit(5);
            Assert.Equal("ERROR", cml.Status);
        }
    }
}
