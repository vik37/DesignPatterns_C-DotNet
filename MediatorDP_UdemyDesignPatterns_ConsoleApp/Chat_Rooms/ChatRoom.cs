using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorDP_UdemyDesignPatterns_ConsoleApp.Chat_Rooms
{
    public class ChatRoom
    {
        private List<Person> people = new List<Person>();
        public void Join(Person p)
        {
            string joinMsg = $"{p.Name} join the chat";
            Broadcast("room", joinMsg);

            p.Room = this;
            people.Add(p);

        }
        public void Broadcast(string source, string message)
        {
            foreach (var p in people)
            {
                if(p.Name != source)
                    p.Receive(source, message);
            }
        }
        public void Message(string source, string destination, string message)
        {
            people.FirstOrDefault(p => p.Name == destination)
                ?.Receive(source, message);
        }
    }
}
