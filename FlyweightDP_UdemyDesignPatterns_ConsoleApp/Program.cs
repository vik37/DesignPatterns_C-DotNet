using FlyweightDP_UdemyDesignPatterns_ConsoleApp.RepeatingUsername;
using JetBrains.dotMemoryUnit;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlyweightDP_UdemyDesignPatterns_ConsoleApp
{
    [TestFixture]
    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region
            // Repeating User Names

            #endregion
            Console.ReadLine();
        }
        [Test]
        public void TestUser()
        {
            var firstNames = Enumerable.Range(0, 100).Select(_ => RandomString());
            var lastNames = Enumerable.Range(0, 100).Select(_ => RandomString());

            var users = new List<User>();
            foreach (var firstName in firstNames)
            {
                foreach (var lastName in lastNames)
                {
                    users.Add(new User($"{firstName} {lastName}"));
                }
            }
            ForseGC();

            dotMemory.Check(memory =>
            {
                Console.WriteLine(memory.SizeInBytes);
            });
        }
        [Test]
        public void TestUser2()
        {
            var firstNames = Enumerable.Range(0, 100).Select(_ => RandomString());
            var lastNames = Enumerable.Range(0, 100).Select(_ => RandomString());

            var users = new List<User2>();
            foreach (var firstName in firstNames)
            {
                foreach (var lastName in lastNames)
                {
                    users.Add(new User2($"{firstName} {lastName}"));
                }
            }
            ForseGC();

            dotMemory.Check(memory =>
            {
                Console.WriteLine(memory.SizeInBytes);
            });
        }
        private void ForseGC()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
        private string RandomString()
        {
            Random r = new Random();
            return new string(
                    Enumerable.Range(0, 10)
                    .Select(i => (char)('a' + r.Next(26)))
                    .ToArray());
        }
    }
}
