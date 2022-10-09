using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorDP_UdemyDesignPatterns_ConsoleApp.Task_Mediator
{
    public class Participant
    {
        public int Value { get; set; } = 0;
        public List<int> SaidValues = new List<int>();
        private readonly Mediator mediator;
        public Participant(Mediator mediator)
        {            
            mediator.Participants.Add(this);
            this.mediator = mediator;
        }
        public void Say(int n)
        {
            SaidValues.Add(n);
            mediator.Broadcast();
        }
    }
}
