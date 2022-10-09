using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDP_UdemyDesignPatterns_ConsoleApp.Task_Mediator_2
{
    public class Participant
    {
        private readonly Mediator mediator;
        public int Value { get; set; }

        public Participant(Mediator mediator)
        {
            this.mediator = mediator;
            mediator.Alert += Mediator_Alert;
        }

        private void Mediator_Alert(object sender, int e)
        {
            if (sender != this)
                Value += e;
        }

        public void Say(int n)
        {
            mediator.Broadcast(this, n);
        }
    }
}
