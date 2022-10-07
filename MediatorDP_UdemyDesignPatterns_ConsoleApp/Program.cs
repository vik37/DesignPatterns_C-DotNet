using MediatorDP_UdemyDesignPatterns_ConsoleApp.Chat_Rooms;
using System;

namespace MediatorDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Chat Room
            var room = new ChatRoom();

            var jane = new Person("Jane");
            var john = new Person("John");

            room.Join(john);
            room.Join(jane);

            john.Say("Hi");
            jane.Say("Well, Hallo There");

            var simon = new Person("Simon");
            room.Join(simon);
            simon.Say("Hi everyone! ");

            jane.PrivateMessage("Simon", "Glad you could join us!");
            #endregion
            Console.ReadLine();
        }
    }
}
